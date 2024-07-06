using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloMesa
{
    public partial class TelaMesaForm : Form
    {
        List<Mesa> mesas = new List<Mesa>();
        public TelaMesaForm()
        {
            InitializeComponent();

            Mesa a = new();
            Mesa a1 = new();
            Mesa a2 = new();
            Mesa a3 = new();
            Mesa a4 = new();
            Mesa a5 = new();
            Mesa a6 = new();
            Mesa a7 = new();

            mesas.Add(a);
            mesas.Add(a1);
            mesas.Add(a2);
            mesas.Add(a3);
            mesas.Add(a4);
            mesas.Add(a5);
            mesas.Add(a6);
            mesas.Add(a7);
        }
    }
}
