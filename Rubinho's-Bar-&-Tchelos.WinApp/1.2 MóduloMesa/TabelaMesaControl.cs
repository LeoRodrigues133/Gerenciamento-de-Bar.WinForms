using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloMesa
{
    public partial class TabelaMesaControl : UserControl
    {
        public TabelaMesaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(CriarColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();

        }
        public void AtualizarRegistros(List<Mesa> repositorio)
        {
            grid.Rows.Clear();

            foreach (Mesa m in repositorio)
                grid.Rows.Add(m.Id.ToString(), m.OrganizarMesas(), m.Status ? "Ocupada" : "Desocupada");
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]                 {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "NumeroDaMesa", HeaderText = "Numero"},
                new DataGridViewTextBoxColumn { DataPropertyName = "StatusMesa", HeaderText = "Status"}
                };
        }
    }
}
