using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloPessoas;
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
        public void AtualizarRegistros(List<Comanda> comandas,List<Mesa> mesas, List<Garçom> pessoas)
        {
            grid.Rows.Clear();

            foreach (Comanda c in comandas)
                grid.Rows.Add(c.Id.ToString(),c.Mesa, c.Garçom,c.Status,$"{c.ValorTotal:C}");
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
