using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;



namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPedido
{
    public partial class TelaComandaForm : Form
    {
        List<Comanda> comandas = new List<Comanda>();
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
        EnumCategoriaProduto categoriaSelecionada;


        ControladorComanda controladorPedido;

        public TelaComandaForm(ControladorComanda Controlador)
        {

            InitializeComponent();
            controladorPedido = Controlador;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Mesa mesa = (Mesa)cmbMesa.SelectedItem;
            Garçom garçom = (Garçom)cmbGarçom.SelectedItem;
            EnumStatusPagamento status = (EnumStatusPagamento)cmbStatus.SelectedItem;
            
            List<Pedido> ListaDePedidos = listProdutos.Items.Cast<Pedido>().ToList();  

            Comanda novaComanda = new Comanda( garçom, status, mesa,ListaDePedidos);

            comandas.Add(novaComanda);

        }

        private void btnAddItens_Click(object sender, EventArgs e)
        {

            int quantiaAdicionada = Convert.ToInt32(txtQuantiaItens.Text);

            if(quantiaAdicionada <= 0 )
                quantiaAdicionada = 1;
            Produto produto = (Produto)cmbProdutos.SelectedItem;

            Pedido pedido = new Pedido(produto, quantiaAdicionada);


            listProdutos.Items.Add(pedido);

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
            controladorPedido.CarregarDados(this);
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            categoriaSelecionada = EnumCategoriaProduto.Bebidas;

            Comunicador(categoriaSelecionada);
            cmbProdutos.Text = string.Empty;
            controladorPedido.CarregarDados(this);
        }
        private void btnServiços_Click(object sender, EventArgs e)
        {
            categoriaSelecionada = EnumCategoriaProduto.Serviços;

            Comunicador(categoriaSelecionada);
            cmbProdutos.Text = string.Empty;
            controladorPedido.CarregarDados(this);
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