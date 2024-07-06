using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloProduto
{
    public partial class TelaProdutoForm : Form
    {
           public List<Produto> produtos = new List<Produto>();
        public TelaProdutoForm()
        {
            InitializeComponent();
            

            Produto a = new("Batatafrita", 32);
            Produto b = new("Batatafrita2", 22);
            Produto c = new("Batatafrita3", 19);
            Produto d = new("Batatafrita4", 17);


            produtos.Add(a);
            produtos.Add(b);
            produtos.Add(c);
            produtos.Add(d);

        }
    }
}
