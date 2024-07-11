using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;

namespace Rubinho_s_Bar___Tchelos.WinApp._1._3_MóduloPedido
{
    public partial class TelaFechamentoComandas : Form
    {

        private Comanda comanda;
        public Comanda Comanda
        {
            get { return comanda; }
            set
            {
                comanda = value;
                lblMesa.Text = "" + value.Mesa;
                lblGarcom.Text = "" + value.Garçom;
                foreach (Pedido p in value.Pedidos)
                {
                    listaPedidos.Items.Add(p);
                }
                lblPreco.Text = "" + value.ValorTotal;
            }
        }
        public TelaFechamentoComandas()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            comanda.Concluir();
        }
    }
}
