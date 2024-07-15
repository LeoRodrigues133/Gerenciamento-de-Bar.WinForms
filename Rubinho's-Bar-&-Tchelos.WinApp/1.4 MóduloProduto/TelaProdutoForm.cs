using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloProduto
{
    public partial class TelaProdutoForm : Form
    {
        public List<Produto> produtos = new List<Produto>();

        Produto produto;

        public Produto Produto
        {
            set
            {
                txtNome.Text = value.Nome;
                txtId.Text = value.Id.ToString();
                numValor.Value = value.Valor;
                cmbCategoria.SelectedItem = value.CategoriaProduto;
            }
            get => produto;
        }
        public TelaProdutoForm()
        {
            InitializeComponent();

            CarregarCategorias();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal valor = numValor.Value;
            EnumCategoriaProduto categoria = (EnumCategoriaProduto)cmbCategoria.SelectedIndex;

            produto = new Produto(nome, valor, categoria); 

            produtos.Add(produto);

            TelaPrincipalForm.Instancia.AtualizarRodape("Um novo produto foi registrado.");
        }

        public void CarregarCategorias
            ()
        {
            Array Categoria = Enum.GetValues(typeof(EnumCategoriaProduto));

            foreach (EnumCategoriaProduto c in Categoria)
                cmbCategoria.Items.Add(c);
        }
    }
}
