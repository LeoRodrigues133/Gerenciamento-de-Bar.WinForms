using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;


namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPessoas
{
    public partial class TelaPessoasForm : Form
    {
        List<Garçom> repositorioPessoas;
        Garçom garçom;

        public Garçom Garçom
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
            }
            get => garçom;
        }

        public TelaPessoasForm(List<Garçom> RepositorioPessoas)
        {
            InitializeComponent();
            this.repositorioPessoas = RepositorioPessoas;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;

            string Cpf = txtCpf.Text;

            garçom = new Garçom(Nome, Cpf);

            if (!garçom.VerificarDualidade(repositorioPessoas, garçom))
            {
                MessageBox.Show(
                    "Não é possivel realizar a ação, já existe um registo com este cpf cadastrado",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                DialogResult = DialogResult.Cancel;
            }

            TelaPrincipalForm.Instancia.AtualizarRodape("Um novo funcionário foi registrado.");

        }

        private void txtCpf_MaskCPF(object sender, KeyEventArgs e)
        {
            TextBox txt = txtCpf;

            if (txt.TextLength == 3 || txt.TextLength == 7)
            {
                txtCpf.Text += ".";
                txtCpf.SelectionStart = txtCpf.Text.Length;
            }

            else if (txt.TextLength == 11)
            {
                txtCpf.Text += "-";
                txtCpf.SelectionStart = txtCpf.Text.Length;
            }

            //MEU   DEUS    QUE     DOR     FOI     FAZER   ISSO!!!!

        }
    }
}
