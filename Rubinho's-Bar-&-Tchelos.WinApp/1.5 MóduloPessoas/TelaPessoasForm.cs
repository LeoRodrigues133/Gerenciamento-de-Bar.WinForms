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


            Garçom a = new("Tchelo", "123.111.123-89", EnumCargo.Garçom);
            Garçom b = new("Tchelo", "123.222.123-89", EnumCargo.Tchelo);
            Garçom c = new("Tchelo", "123.333.123-89", EnumCargo.Tchelo);
            Garçom d = new("Tchelo", "123.444.123-89", EnumCargo.Recepicionista);
            Garçom e = new("Tchelo", "123.555.123-89", EnumCargo.Garçom);
            Garçom f = new("Tchelo", "123.667.123-89", EnumCargo.Garçom);
            Garçom g = new("Tchelo", "123.777.123-89", EnumCargo.Garçom);

            repositorioPessoas.Add(a);
            repositorioPessoas.Add(b);
            repositorioPessoas.Add(c);
            repositorioPessoas.Add(d);
            repositorioPessoas.Add(e);
            repositorioPessoas.Add(f);
            repositorioPessoas.Add(g);


            Array Cargos = Enum.GetValues(typeof(EnumCargo));

            foreach (EnumCargo x in Cargos)
                cmbCargo.Items.Add(x);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {



            string Nome = txtNome.Text;

            string Cpf = txtCpf.Text;

            EnumCargo Cargo = (EnumCargo)cmbCargo.SelectedItem!;

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
