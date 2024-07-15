using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;
using Rubinho_s_Bar___Tchelos.DominioMóduloPedido.Extrato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubinho_s_Bar___Tchelos.WinApp._1._3_MóduloPedido
{
    public partial class TelaExtratoForm : Form
    {
        public TelaExtratoForm()
        {
            InitializeComponent();

            Array Periodo = Enum.GetValues(typeof(EnumPeriodoExtrato));

            foreach (EnumPeriodoExtrato enumPeriodo in Periodo)
                cmbPeriodo.Items.Add(enumPeriodo);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            if (cmbPeriodo.SelectedIndex == (int)EnumPeriodoExtrato.Diario)
            {

                listExtrato.Items.Add("a");
            }

        }

        public void CarregarComandas(List<Comanda> comandas)
        {
            listExtrato.Items.Clear();

            listExtrato.Items.Add(comandas);
        }
    }
}
