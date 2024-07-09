using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;



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
        TabelaPedidoControl t;
        EnumCategoriaProduto categoriaSelecionada;


        Produto produto;
        Pedido pedido;
        ControladorPedido controladorPedido;
        
        public TelaPedidoForm(ControladorPedido c)
        {

            InitializeComponent();
            controladorPedido = c;
        }
        public void AtualizarRegistros(List<Produto> repositorio)
        {
            listProdutos.Items.Clear();

            foreach (Produto produto in repositorio)
                listProdutos.Items.Add(produto);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Mesa mesa = (Mesa)cmbMesa.SelectedItem;
            Garçom garçom = (Garçom)cmbGarçom.SelectedItem;
            EnumStatusPagamento status = (EnumStatusPagamento)cmbStatus.SelectedItem;
        }

        private void btnAddItens_Click(object sender, EventArgs e)
        {
 
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

        EnumCategoriaProduto Comunicador(EnumCategoriaProduto t)
        {

            return t;
        }

        private void btnComidas_Click(object sender, EventArgs e)
        {
            categoriaSelecionada = EnumCategoriaProduto.Comidas;

            Comunicador(categoriaSelecionada);
            cmbProdutos.Text = string.Empty;
            controladorPedido.carregarProdutos(this);
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            categoriaSelecionada = EnumCategoriaProduto.Bebidas;

            Comunicador(categoriaSelecionada);
            cmbProdutos.Text = string.Empty;
            controladorPedido.carregarProdutos(this);
        }

        private void btnServiços_Click(object sender, EventArgs e)
        {
            categoriaSelecionada = EnumCategoriaProduto.Serviços;

            Comunicador(categoriaSelecionada);
            cmbProdutos.Text = string.Empty;
            controladorPedido.carregarProdutos(this);
        }

        public void CarregarComboBoxProdutos(List<Produto> produtos)
        {
            cmbProdutos.Items.Clear();
            var p = produtos.FindAll(x => x.CategoriaProduto == Comunicador(categoriaSelecionada));

            foreach (Produto produto in p)
            {
                cmbProdutos.Items.Add(produto);
            }
        }

        public void CarregarComboBoxPedido(List<Garçom> garçoms, List<Mesa> mesas)
        {
            foreach (var g in garçoms)
                cmbGarçom.Items.Add(g);

            foreach (var m in mesas)
                cmbMesa.Items.Add(m);


            Array StatusPagamento = Enum.GetValues(typeof(EnumStatusPagamento));

            foreach (EnumStatusPagamento status in StatusPagamento)
                cmbStatus.Items.Add(status);

        }
    }
}