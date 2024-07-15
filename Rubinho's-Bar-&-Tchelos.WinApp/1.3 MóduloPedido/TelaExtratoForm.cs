using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPedido
{
    public partial class TelaExtratoForm : Form
    {
        private ControladorComanda controladorPedido;

        public TelaExtratoForm(ControladorComanda controlador)
        {
            InitializeComponent();
            controladorPedido = controlador;
            CarregarPeriodo();
        }

        public void CarregarPeriodo()
        {
            Array periodos = Enum.GetValues(typeof(EnumPeriodos));

            foreach (EnumPeriodos p in periodos)
                cmbPeriodo.Items.Add(p);
        }

        public void BuscarTodasAsComandas(List<Comanda> todasAsComandas)
        {
            if (todasAsComandas == null)
                todasAsComandas = new List<Comanda>();

            listExtrato.Items.Clear();

            foreach (Comanda c in todasAsComandas)
                listExtrato.Items.Add(c.ToString());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbPeriodo.SelectedItem == null)
                return;

            EnumPeriodos periodo = (EnumPeriodos)cmbPeriodo.SelectedItem;

            List<Comanda> resultado = controladorPedido.MostrarExtratos(periodo);

            listExtrato.Items.Clear();

            foreach (var comanda in resultado)
                listExtrato.Items.Add(comanda);

        }
    }
}