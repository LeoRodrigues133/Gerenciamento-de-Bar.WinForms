using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubinho_s_Bar___Tchelos.WinApp._1._2_MóduloMesa
{
    public partial class TelaDetalheMesaForm : Form
    {
        public TelaDetalheMesaForm()
        {
            InitializeComponent();
        }

        private void cmbComandas_SelectedIndexChanged(object sender, EventArgs e)
        {
            listPedidos.Items.Clear();

            Comanda comanda = (Comanda)cmbComandas.SelectedItem!;

            if (cmbComandas.SelectedIndex != null)
                foreach (Pedido p in comanda.Pedidos)
                    listPedidos.Items.Add(p);

            lblValor.Text = Convert.ToString($"{comanda.ValorTotal:C}");
        }

        public void carregarComandas(List<Comanda> comandas)
        {

            foreach (Comanda c in comandas)
                cmbComandas.Items.Add(c);
        }
    }
}
