using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Infra.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Infra.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Infra.MóduloProduto;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloMesa;
using Rubinho_s_Bar___Tchelos.WinApp._MóduloPessoas;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloMesa;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloPedido;

namespace Rubinho_s_Bar___Tchelos.WinApp
{

    public partial class TelaPrincipalForm : Form
    {

        ControladorBase controlador;

        RepositorioPessoasEmOrm repositorioPessoas;
        RepositorioMesaEmOrm repositorioMesa;
        RepositorioPedidoEmOrm repositorioPedido;
        RepositorioProdutoEmOrm repositorioProduto;

        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();

            toolStripTipo.Text = string.Empty;

            Instancia = this;

            BotecoDbContext dbContext = new();

            repositorioMesa = new RepositorioMesaEmOrm(dbContext);
            repositorioPedido = new RepositorioPedidoEmOrm(dbContext);
            repositorioProduto = new RepositorioProdutoEmOrm(dbContext);
            repositorioPessoas = new RepositorioPessoasEmOrm(dbContext);



        }

        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            toolStripTipo.Text = "Gerenciamento de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is IControladorEditavel;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            if (controladorSelecionado is IControladorEditavel)
                btnEditar.Enabled = true;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;


        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagem = controladorSelecionado.ObterListagem();
            listagem.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagem);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorEditavel controladorEditavel)
                controladorEditavel.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorPessoas();

            ConfigurarTelaPrincipal(controlador);
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorPedido();

            ConfigurarTelaPrincipal(controlador);
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladoMesa();

            ConfigurarTelaPrincipal(controlador);
        }
    }
}
