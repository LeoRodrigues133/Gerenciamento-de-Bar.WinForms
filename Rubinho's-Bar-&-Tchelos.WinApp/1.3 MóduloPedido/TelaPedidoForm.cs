using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPedido
{
    public partial class TelaPedidoForm : Form
    {
        public TelaPedidoForm()
        {
            InitializeComponent();
            gridProdutos.Columns.AddRange(CriarColunas());

            gridProdutos.ConfigurarGridSomenteLeitura();
            gridProdutos.ConfigurarGridZebrado();

        }
        public void AtualizarRegistros(List<Produto> repositorio)
        {
            gridProdutos.Rows.Clear();

            foreach (Produto p in repositorio)
            {
                gridProdutos.Rows.Add(p.Nome, txtQuantiaItens.Text, p.Valor);
            }
        }

        public int ObterRegistroSelecionado()
        {
            return gridProdutos.SelecionarId();
        }

        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]                 {
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Produto"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Quantia", HeaderText = "Quantia"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor"}
                };
        }
    }
}
