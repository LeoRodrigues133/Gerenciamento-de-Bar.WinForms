using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloProduto;
using Rubinho_s_Bar___Tchelos.WinApp._1._3_MóduloPedido;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPedido
{
    public class ControladorComanda : ControladorBase, IControladorEditavel, IControladorConcluir, IControladorVisualizarExtratos
    {
        IRepositorioMesa repositorioMesas;
        IRepositorioComanda repositorioPedido;
        IRepositorioPessoas repositorioPessoas;
        IRepositorioProduto repositorioProdutos;

        TabelaComandaControl tabelaPedido;

        public override string TipoCadastro => "Pedidos";
        public string ToolTipEditar => "Editar um pedido existente";
        public override string ToolTipExcluir => "Excluir um pedido existente";
        public override string ToolTipAdicionar => "Cadastrar um novo pedido";

        public ControladorComanda(IRepositorioPessoas repositorioPessoas, IRepositorioMesa repositorioMesas, IRepositorioComanda repositorioPedido, IRepositorioProduto repositorioProdutos)
        {
            this.repositorioPessoas = repositorioPessoas;
            this.repositorioMesas = repositorioMesas;
            this.repositorioPedido = repositorioPedido;
            this.repositorioProdutos = repositorioProdutos;
        }
        public override void Adicionar()
        {
            TelaComandaForm tela = new TelaComandaForm(this);

            CarregarDados(tela);

            DialogResult resultado = tela.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Comanda novaComanda = tela.Comanda;

            novaComanda.CalcularValor(novaComanda.Pedidos);

            repositorioPedido.Cadastrar(novaComanda);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novaComanda.Id}\" foi criado com sucesso!");
        }

        void IControladorEditavel.Editar()
        {
            TelaComandaForm tela = new TelaComandaForm(this);

            tela.TravarDados();
            CarregarDados(tela);
            CarregarPedidos(tela);

            int idSelecionado = tabelaPedido.ObterRegistroSelecionado();

            Comanda Selecionado = repositorioPedido.SelecionarPorId(idSelecionado);

            if (idSelecionado == null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(
                "Não é possível realizar esta ação sem um registro selecionado");
                return;
            }

            tela.Comanda = Selecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Comanda comandaEditada = tela.Comanda;


            repositorioPedido.Editar(Selecionado.Id, comandaEditada);

            comandaEditada.CalcularValor(comandaEditada.Pedidos);
            CarregarRegistros();

        }

        public override void Excluir()
        {
            int idSelecionado = tabelaPedido.ObterRegistroSelecionado();

            Comanda Selecionado = repositorioPedido.SelecionarPorId(idSelecionado);

            if (Selecionado == null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(
                    "Não é possível realizar esta ação sem um registro selecionado");
                return;
            }

            DialogResult resultado = MessageBox.Show(
            $"Você deseja realmente remover a comanda \"{Selecionado.Id}\"?",
            "Confirmar remoção",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                repositorioPedido.Excluir(Selecionado.Id);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Você excluiu a comanda {Selecionado.Id}!");
                CarregarRegistros();
                return;
            }


        }

        public override UserControl ObterListagem()
        {
            if (tabelaPedido == null)
                tabelaPedido = new TabelaComandaControl();

            CarregarRegistros();

            return tabelaPedido;
        }


        public void CarregarPedidos(TelaComandaForm telaPedido)
        {
            int Selecionado = tabelaPedido.ObterRegistroSelecionado();
            Comanda comandaSelecionada = repositorioPedido.SelecionarPorId(Selecionado);

            List<Pedido> pedidos = comandaSelecionada.Pedidos;

            telaPedido.CarregarListProdutos(pedidos);
        }

        public override void CarregarRegistros()
        {
            List<Comanda> comandas = repositorioPedido.SelecionarTodos();

            tabelaPedido.AtualizarRegistros(comandas);
        }

        public void Concluir()
        {
            int idSelecionado = tabelaPedido.ObterRegistroSelecionado();

            Comanda contaSelecionada = repositorioPedido.SelecionarPorId(idSelecionado);

            if (contaSelecionada == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (contaSelecionada.Status == EnumStatusPagamento.Fechada)
            {
                MessageBox.Show(
                    "Você não pode concluir uma conta já concluída!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;

            }

            TelaFechamentoComandas telaFechamento = new TelaFechamentoComandas();

            telaFechamento.Comanda = contaSelecionada;

            DialogResult resultado = telaFechamento.ShowDialog();

            if (resultado != DialogResult.OK)
                return;


            Comanda registroEditado = telaFechamento.Comanda;

            repositorioPedido.Editar(idSelecionado, registroEditado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"A Conta de Id \"{registroEditado.Id}\" foi fechada com sucesso!");
        }

        public void VisualizarExtratos()
        {
            TelaExtratoForm tela = new TelaExtratoForm(this);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
                CarregarComandas(tela);

        }

        public void CarregarComandas(TelaExtratoForm telaExtrato)
        {
            List<Comanda> comandas = repositorioPedido.SelecionarTodos();

            telaExtrato.BuscarTodasAsComandas(comandas);
        }

        public List<Comanda> MostrarExtratos(EnumPeriodos periodo)
        {
            List<Comanda> comandas = repositorioPedido.SelecionarTodos();

            DateTime Agora = DateTime.Now;
            DateTime DataInicio = Agora;

            switch (periodo)
            {
                case EnumPeriodos.Dia:
                    DataInicio = Agora.Date;
                    break;
                case EnumPeriodos.Semana:
                    DataInicio = Agora.AddDays(-((int)Agora.DayOfWeek)).Date; 
                    break;
                case EnumPeriodos.Mes:
                    DataInicio = new DateTime(Agora.Year, Agora.Month, 1);
                    break;
            }

            var extratos = comandas.Where(c => c.Status == EnumStatusPagamento.Fechada && c.DataConclusao >= DataInicio && c.DataConclusao <= Agora).ToList();

            return extratos;
        }

        public void CarregarDados(TelaComandaForm telaPedido)
        {
            List<Mesa> mesas = repositorioMesas.SelecionarTodos();
            List<Garçom> garçoms = repositorioPessoas.SelecionarTodos();
            List<Produto> produtos = repositorioProdutos.SelecionarTodos();


            telaPedido.CarregarComboBoxProdutos(produtos);
            telaPedido.CarregarComboBoxPedido(garçoms, mesas);
        }

    }
}
