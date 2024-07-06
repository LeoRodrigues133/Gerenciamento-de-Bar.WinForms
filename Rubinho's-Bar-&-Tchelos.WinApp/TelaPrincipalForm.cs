using Rubinho_s_Bar___Tchelos.Infra.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.WinApp._MóduloPessoas;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloPedido;

namespace Rubinho_s_Bar___Tchelos.WinApp
{

    public partial class TelaPrincipalForm : Form
    {

        ControladorBase controlador;

        RepositorioPessoasEmOrm repositorioPessoas;


        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();

            toolStripTipo.Text = string.Empty;

            Instancia = this;
            repositorioPessoas = new RepositorioPessoasEmOrm();

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
            controlador = new ControladorPessoas(repositorioPessoas);

            ConfigurarTelaPrincipal(controlador);
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorPedido();

            ConfigurarTelaPrincipal(controlador);
        }
    }
}
