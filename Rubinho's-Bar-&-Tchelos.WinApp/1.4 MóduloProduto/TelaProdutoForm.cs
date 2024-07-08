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
            }
            get => produto;
        }
        public TelaProdutoForm()
        {
            InitializeComponent();


            Produto a = new("Batatafrita", 32, EnumCategoriaProduto.Comidas);
            Produto b = new("Cheese Salada", 22, EnumCategoriaProduto.Comidas);
            Produto c = new("Polenta Frita", 19, EnumCategoriaProduto.Comidas);
            Produto d = new("Bauru", 17, EnumCategoriaProduto.Comidas);

            Produto a1 = new("Cerveja Heineken", 32, EnumCategoriaProduto.Bebidas);
            Produto b2 = new("Pinga boa", 22, EnumCategoriaProduto.Bebidas);
            Produto c3 = new("Alcool de posto", 7, EnumCategoriaProduto.Bebidas);
            Produto d4 = new("Veneno", 17, EnumCategoriaProduto.Bebidas);

            Produto a21 = new("Dança exótica", 80, EnumCategoriaProduto.Serviços);
            Produto b22 = new("Ombro amigo", 99, EnumCategoriaProduto.Serviços);
            Produto c23 = new("Duelo de 38", 38, EnumCategoriaProduto.Serviços);
            Produto d24 = new("Tchelos deluxe service", 999, EnumCategoriaProduto.Serviços);


            produtos.Add(a);
            produtos.Add(b);
            produtos.Add(c);
            produtos.Add(d);

            produtos.Add(a1);
            produtos.Add(b2);
            produtos.Add(c3);
            produtos.Add(d4);

            produtos.Add(a21);
            produtos.Add(b22);
            produtos.Add(c23);
            produtos.Add(d24);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal valor = numValor.Value;
            EnumCategoriaProduto categoria = (EnumCategoriaProduto)cmbCategoria.SelectedItem;

            produto = new Produto(nome, valor, categoria);

            TelaPrincipalForm.Instancia.AtualizarRodape("Um novo produto foi registrado.");
        }
    }
}
