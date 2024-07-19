using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloMesa;
using Rubinho_s_Bar___Tchelos.WinApp._1._2_MóduloMesa;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloMesa
{
    public class ControladorMesa : ControladorBase, IControladorDetalhar
    {

        public IRepositorioMesa repositorioMesas;
        public IRepositorioComanda repositorioComanda;
        public IRepositorioProduto repositorioProduto;

        public TabelaMesaControl tabelaMesas;


        public override string TipoCadastro => "Mesas";
        public override string ToolTipAdicionar => "Adicionar uma nova mesa no salão";
        public override string ToolTipExcluir => "Remover uma mesa do salão";

        public ControladorMesa(IRepositorioMesa repositorioMesas, IRepositorioComanda repositorioComanda, IRepositorioProduto repositorioProduto)
        {
            this.repositorioMesas = repositorioMesas;
            this.repositorioComanda = repositorioComanda;
            this.repositorioProduto = repositorioProduto;
        }
        public override void Adicionar()
        {

            int EnumeradorDeMesas = repositorioMesas.SelecionarTodos().Count() * 10;

            List<Mesa> listaDeMesas = repositorioMesas.SelecionarTodos();

            Mesa buscador = listaDeMesas.Find(x => x.NumeroDaMesa == EnumeradorDeMesas)!;

            if (buscador != null)
                EnumeradorDeMesas += 1;

            Mesa novaMesa = new Mesa(EnumeradorDeMesas);

            repositorioMesas.Cadastrar(novaMesa);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"Uma nova mesa foi adicionada com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaMesas.ObterRegistroSelecionado();

            Mesa mesaSelecionada = repositorioMesas.SelecionarPorId(idSelecionado);

            if (mesaSelecionada == null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Não é possível realizar esta ação sem nenhuma mesa selecionada");
                return;
            }
            DialogResult result = MessageBox.Show(
                $"Você realmente deseja excluir a mesa Numero {mesaSelecionada.NumeroDaMesa}?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                repositorioMesas.Excluir(mesaSelecionada.Id);
                CarregarRegistros();
                TelaPrincipalForm.Instancia.AtualizarRodape("O mesa foi removida com sucesso");
                return;
            }


        }

        public override void CarregarRegistros()
        {
            List<Mesa> mesas = repositorioMesas.SelecionarTodos();
            List<Comanda> comandas = repositorioComanda.SelecionarTodos();
            List<Produto> produtos = repositorioProduto.SelecionarTodos();

            tabelaMesas.AtualizarRegistros(mesas, comandas, produtos);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaMesas == null)
                tabelaMesas = new TabelaMesaControl();

            CarregarRegistros();

            return tabelaMesas;
        }

        void carregarListaComandas(TelaDetalheMesaForm tela, Mesa mesa)
        {
            List<Comanda> repositorio = repositorioComanda.SelecionarTodos().FindAll(m => m.Mesa.Id == mesa.Id);


            tela.carregarComandas(repositorio);
        }

        public void DetalharMesa()
        {
            int idSelecionado = tabelaMesas.ObterRegistroSelecionado();

            Mesa mesaSelecionada = repositorioMesas.SelecionarPorId(idSelecionado);

            if (mesaSelecionada == null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Não é possível realizar esta ação sem nenhuma mesa selecionada");
                return;
            }

            TelaDetalheMesaForm tela = new TelaDetalheMesaForm();

            carregarListaComandas(tela, mesaSelecionada);

            DialogResult result = tela.ShowDialog();

            if (result != DialogResult.OK) return;
        }
    }
}
