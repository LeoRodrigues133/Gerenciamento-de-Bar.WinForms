using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloProduto;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloMesa;
using Rubinho_s_Bar___Tchelos.WinApp._MóduloPessoas;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloMesa;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloProduto;
using Rubinho_s_Bar___Tchelos.WinApp._1._3_MóduloPedido;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPedido
{
    public class ControladorComanda : ControladorBase, IControladorEditavel, IControladorVisualizarExtrato
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

            repositorioPedido.Cadastrar(novaComanda);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novaComanda.Id}\" foi criado com sucesso!");
        }

        void IControladorEditavel.Editar()
        {
            TelaComandaForm tela = new TelaComandaForm(this);

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



        public void CarregarDados(TelaComandaForm telaPedido)
        {
            TelaProdutoForm telaProduto = new();

            List<Mesa> mesas = repositorioMesas.SelecionarTodos();
            List<Garçom> garçoms = repositorioPessoas.SelecionarTodos();
            List<Produto> produtos = repositorioProdutos.SelecionarTodos();

            telaPedido.CarregarComboBoxProdutos(produtos);
            telaPedido.CarregarComboBoxPedido(garçoms, mesas);
        }
        
        public void carregarComandas(TelaExtratoForm telaExtrato)
        {
            List<Comanda> comandas = repositorioPedido.SelecionarTodos();

            telaExtrato.CarregarComandas(comandas);
        }

        public override void CarregarRegistros()
        {
            List<Comanda> comandas = repositorioPedido.SelecionarTodos();

            tabelaPedido.AtualizarRegistros(comandas);
        }

        public void MostrarExtrato()
        {
            TelaExtratoForm telaExtrato = new TelaExtratoForm();

            DialogResult resultado = telaExtrato.ShowDialog();

            if (resultado != DialogResult.OK) return;
        }
    }
}
