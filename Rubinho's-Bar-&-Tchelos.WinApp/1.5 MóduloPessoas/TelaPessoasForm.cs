using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;


namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPessoas
{
    public partial class TelaPessoasForm : Form
    {
        public List<Garçom> repositorioPessoas = new();
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

        public TelaPessoasForm()
        {
            InitializeComponent();

            Array Cargos = Enum.GetValues(typeof(EnumCargo));

            foreach (EnumCargo x in Cargos)
                cmbCargo.Items.Add(x);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {



            string Nome = txtNome.Text;

            string Cpf = txtCpf.Text;

            EnumCargo Cargo = (EnumCargo)cmbCargo.SelectedItem;

            garçom = new Garçom(Nome, Cpf, Cargo);
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
            if (e.KeyCode != Keys.Back)
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
                else if (e.KeyCode == Keys.Back && txtCpf.Text.Length == 11)
                    txtCpf.Text = txtCpf.Text.Substring(0, txtCpf.Text.Length - 1);

                else if (e.KeyCode == Keys.Back && txtCpf.Text.Length == 6)
                    txtCpf.Text = txtCpf.Text.Substring(0, txtCpf.Text.Length - 1);

                else if (e.KeyCode == Keys.Back && txtCpf.Text.Length == 3)
                    txtCpf.Text = txtCpf.Text.Substring(0, txtCpf.Text.Length - 1);

            //MEU   DEUS    QUE     DOR     FOI     FAZER   ISSO!!!!
        }
    }
}
