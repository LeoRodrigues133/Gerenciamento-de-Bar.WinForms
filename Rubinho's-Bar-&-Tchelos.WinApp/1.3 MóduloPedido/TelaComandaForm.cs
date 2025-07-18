﻿using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPedido
{
    public partial class TelaComandaForm : Form
    {
        Comanda comanda;
        ControladorComanda controladorPedido;
        EnumCategoriaProduto categoriaSelecionada;
        List<Comanda> comandas = new List<Comanda>();
        List<Produto> produtos = new List<Produto>();
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

            comanda = new Comanda(garçom, status, mesa, ListaDePedidos);

            comandas.Add(comanda);

            if (status == EnumStatusPagamento.Fechada)
                mesa.DesocuparMesa();
            else
                mesa.OcuparMesa();

        }

        private void btnAddItens_Click(object sender, EventArgs e)
        {

            int quantiaAdicionada = Convert.ToInt32(txtQuantiaItens.Text);

            if (quantiaAdicionada <= 0)
                quantiaAdicionada = 1;
            Produto produto = (Produto)cmbProdutos.SelectedItem;

            Pedido pedido = new Pedido(produto, quantiaAdicionada);


            if (listProdutos.SelectedItem != null)

                listProdutos.Items.RemoveAt(listProdutos.SelectedIndex);
            else
                listProdutos.Items.Add(pedido);



            PreencherValor(listProdutos);
        }

        void PreencherValor(ListBox list)
        {
            decimal ValorTotal = 0;

            foreach (Pedido p in list.Items)
                ValorTotal += p.Produto.Valor * p.Quantidade;

            txtValorTotal.Text = $"{ValorTotal:C}";
            txtQuantiaItens.Text = "1";
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

        private void btnComidas_Click(object sender, EventArgs e)
        {
            categoriaSelecionada = EnumCategoriaProduto.Comidas;

            cmbProdutos.Text = string.Empty;

            AtualizarProdutos();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            categoriaSelecionada = EnumCategoriaProduto.Bebidas;

            cmbProdutos.Text = string.Empty;

            AtualizarProdutos();
        }
        private void btnServiços_Click(object sender, EventArgs e)
        {
            categoriaSelecionada = EnumCategoriaProduto.Serviços;

            cmbProdutos.Text = string.Empty;

            AtualizarProdutos();
        }
        private void AtualizarProdutos()
        {
            cmbProdutos.Items.Clear();

            var produtosFiltrados = produtos.Where(p => p.CategoriaProduto == categoriaSelecionada).ToList();

            foreach (var produto in produtosFiltrados)
                cmbProdutos.Items.Add(produto);

        }

        public void CarregarComboBoxProdutos(List<Produto> produtos)
        {
            this.produtos = produtos;
            AtualizarProdutos();
        }

        public void CarregarComboBoxPedido(List<Garçom> garçoms, List<Mesa> mesas)
        {
            foreach (var g in garçoms)
                cmbGarçom.Items.Add(g);

            var livres = mesas.Where(m => m.Status == false);

            foreach (var m in livres)
                cmbMesa.Items.Add(m);


            Array StatusPagamento = Enum.GetValues(typeof(EnumStatusPagamento));

            foreach (EnumStatusPagamento status in StatusPagamento)
                cmbStatus.Items.Add(status);

        }

        public void CarregarListProdutos(List<Pedido> pedidos)
        {
            foreach (var p in pedidos)
                listProdutos.Items.Add(p);
        }

        public void TravarDados()
        {
            cmbGarçom.Enabled = false;
            cmbMesa.Enabled = false;
            cmbStatus.Enabled = false;
            TabComanda.SelectedTab = tabPagePedido;
        }



        private void listProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string caminho = Directory.GetCurrentDirectory().Split(@"bin\")[0] + @"\Resources\";

            if (listProdutos.SelectedIndex != -1)
                btnAddItens.Image = Image.FromFile(caminho + "btnRemover.png");
            else
                btnAddItens.Image = Image.FromFile(caminho + "btnAdicionarItem.png");

        }
    }
}