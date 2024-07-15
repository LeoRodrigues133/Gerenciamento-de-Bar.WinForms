using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPedido
{
    public partial class TabelaComandaControl : UserControl
    {
        public TabelaComandaControl()
        {
            InitializeComponent();
            grid.Columns.AddRange(CriarColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();

        }
        public void AtualizarRegistros(List<Comanda> repositorio)
        {
            grid.Rows.Clear();

            foreach (Comanda c in repositorio)
                grid.Rows.Add(c.Id.ToString(),c.Mesa, c.Garçom,c.Status,$"{c.CalcularValor(c.Pedidos,c.ValorTotal):C}");
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]                 {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Mesa", HeaderText = "Mesa"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Garçom", HeaderText = "Garçom"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Pagamento"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor"}
                };
        }
    }
}
