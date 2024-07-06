using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloProduto;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPedido
{
    public partial class TelaPedidoForm : Form
    {
        Comanda comanda;
        public Comanda Comanda
        {
            set
            {
                txtId.Text = value.Id.ToString();
                cmbMesa.SelectedItem = value.Mesa;
                cmbGarçom.SelectedItem = value.Garçom;
                cmbStatus.SelectedItem = value.Status;

            }
            get => comanda;
        }

        Pedido pedido;
        List<Produto> p;

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
                gridProdutos.Rows.Add(p.Nome, p.Quantia, p.Valor.ToString("C"));
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Mesa mesa = (Mesa)cmbMesa.SelectedItem;
            Garçom garçom = (Garçom)cmbGarçom.SelectedItem;
            EnumStatusPagamento status = (EnumStatusPagamento)cmbStatus.SelectedItem;



        }

        private void btnAddItens_Click(object sender, EventArgs e)
        {
            int quantiaAdicionada = Convert.ToInt32(txtQuantiaItens.Text);

            if (p == null)
                p = new List<Produto>();

            Produto produto = (Produto)cmbProdutos.SelectedItem;

            Produto buscador = p.Find(x => x.Nome == produto.Nome);


            if (buscador == null)
            {
                if (quantiaAdicionada > 0)
                    produto.Quantia = quantiaAdicionada;
                else
                    produto.Quantia = 1;

                p.Add(produto);
            }
            else
            {
                if (quantiaAdicionada != 0)
                    produto.Quantia += quantiaAdicionada;
                else
                    produto.Quantia++;
            }

            txtQuantiaItens.Text = "0";

            AtualizarRegistros(p);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(txtQuantiaItens.Text);

            quantidade++;

            txtQuantiaItens.Text = Convert.ToString(quantidade);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(txtQuantiaItens.Text);

            if (quantidade > 0)
                quantidade--;
            else
                quantidade = 0;

            txtQuantiaItens.Text = Convert.ToString(quantidade);
        }


        public void povoarcboxproduto(List<Produto> produtos)
        {
            foreach (Produto p in produtos)
                cmbProdutos.Items.Add(p);
        }
    }
}
