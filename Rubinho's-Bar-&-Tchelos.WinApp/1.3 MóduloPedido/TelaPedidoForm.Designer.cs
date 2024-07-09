using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPedido
{
    partial class TelaPedidoForm
    {
        private string caminho = Directory.GetCurrentDirectory().Split(@"bin\")[0] + @"\Resources\";
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabComanda = new TabControl();
            tabPageComanda = new TabPage();
            chkServiço = new CheckBox();
            groupBoxPagamento = new GroupBox();
            txtValorTotal = new TextBox();
            txtDesconto = new TextBox();
            lblTotal = new Label();
            lblDesconto = new Label();
            cmbGarçom = new ComboBox();
            lblGarçom = new Label();
            cmbMesa = new ComboBox();
            lblMesa = new Label();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            tabPagePedido = new TabPage();
            gridProdutos = new DataGridView();
            btnServiços = new Button();
            btnBebidas = new Button();
            btnComidas = new Button();
            label3 = new Label();
            lblProduto = new Label();
            cmbProdutos = new ComboBox();
            txtQuantiaItens = new TextBox();
            button2 = new Button();
            button1 = new Button();
            btnAddItens = new Button();
            lblId = new Label();
            txtId = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            TabComanda.SuspendLayout();
            tabPageComanda.SuspendLayout();
            groupBoxPagamento.SuspendLayout();
            tabPagePedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdutos).BeginInit();
            SuspendLayout();
            // 
            // TabComanda
            // 
            TabComanda.Controls.Add(tabPageComanda);
            TabComanda.Controls.Add(tabPagePedido);
            TabComanda.Location = new Point(21, 54);
            TabComanda.Margin = new Padding(3, 2, 3, 2);
            TabComanda.Name = "TabComanda";
            TabComanda.SelectedIndex = 0;
            TabComanda.Size = new Size(533, 274);
            TabComanda.TabIndex = 3;
            // 
            // tabPageComanda
            // 
            tabPageComanda.BackColor = SystemColors.Control;
            tabPageComanda.Controls.Add(chkServiço);
            tabPageComanda.Controls.Add(groupBoxPagamento);
            tabPageComanda.Controls.Add(cmbGarçom);
            tabPageComanda.Controls.Add(lblGarçom);
            tabPageComanda.Controls.Add(cmbMesa);
            tabPageComanda.Controls.Add(lblMesa);
            tabPageComanda.Controls.Add(cmbStatus);
            tabPageComanda.Controls.Add(lblStatus);
            tabPageComanda.Location = new Point(4, 24);
            tabPageComanda.Margin = new Padding(3, 2, 3, 2);
            tabPageComanda.Name = "tabPageComanda";
            tabPageComanda.Padding = new Padding(3, 2, 3, 2);
            tabPageComanda.Size = new Size(525, 246);
            tabPageComanda.TabIndex = 0;
            tabPageComanda.Text = "Comanda";
            // 
            // chkServiço
            // 
            chkServiço.AutoSize = true;
            chkServiço.Location = new Point(362, 44);
            chkServiço.Margin = new Padding(3, 2, 3, 2);
            chkServiço.Name = "chkServiço";
            chkServiço.RightToLeft = RightToLeft.Yes;
            chkServiço.Size = new Size(108, 19);
            chkServiço.TabIndex = 3;
            chkServiço.Text = ":Taxa de serviço";
            chkServiço.UseVisualStyleBackColor = true;
            // 
            // groupBoxPagamento
            // 
            groupBoxPagamento.BackColor = SystemColors.Control;
            groupBoxPagamento.Controls.Add(txtValorTotal);
            groupBoxPagamento.Controls.Add(txtDesconto);
            groupBoxPagamento.Controls.Add(lblTotal);
            groupBoxPagamento.Controls.Add(lblDesconto);
            groupBoxPagamento.Enabled = false;
            groupBoxPagamento.Location = new Point(5, 159);
            groupBoxPagamento.Margin = new Padding(3, 2, 3, 2);
            groupBoxPagamento.Name = "groupBoxPagamento";
            groupBoxPagamento.Padding = new Padding(3, 2, 3, 2);
            groupBoxPagamento.Size = new Size(515, 86);
            groupBoxPagamento.TabIndex = 3;
            groupBoxPagamento.TabStop = false;
            groupBoxPagamento.Text = "Pagamento";
            // 
            // txtValorTotal
            // 
            txtValorTotal.BackColor = SystemColors.ControlLight;
            txtValorTotal.BorderStyle = BorderStyle.None;
            txtValorTotal.Font = new Font("Segoe UI", 15F);
            txtValorTotal.Location = new Point(83, 49);
            txtValorTotal.Margin = new Padding(3, 2, 3, 2);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(426, 27);
            txtValorTotal.TabIndex = 1;
            txtValorTotal.Text = "0";
            txtValorTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDesconto
            // 
            txtDesconto.BackColor = SystemColors.ControlLight;
            txtDesconto.BorderStyle = BorderStyle.None;
            txtDesconto.Font = new Font("Segoe UI", 15F);
            txtDesconto.Location = new Point(83, 20);
            txtDesconto.Margin = new Padding(3, 2, 3, 2);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(426, 27);
            txtDesconto.TabIndex = 1;
            txtDesconto.Text = "0";
            txtDesconto.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(39, 60);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total:";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(13, 28);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(60, 15);
            lblDesconto.TabIndex = 0;
            lblDesconto.Text = "Desconto:";
            // 
            // cmbGarçom
            // 
            cmbGarçom.FormattingEnabled = true;
            cmbGarçom.Location = new Point(76, 88);
            cmbGarçom.Margin = new Padding(3, 2, 3, 2);
            cmbGarçom.Name = "cmbGarçom";
            cmbGarçom.Size = new Size(177, 23);
            cmbGarçom.TabIndex = 1;
            // 
            // lblGarçom
            // 
            lblGarçom.AutoSize = true;
            lblGarçom.Location = new Point(15, 91);
            lblGarçom.Name = "lblGarçom";
            lblGarçom.Size = new Size(52, 15);
            lblGarçom.TabIndex = 0;
            lblGarçom.Text = "Garçom:";
            // 
            // cmbMesa
            // 
            cmbMesa.FormattingEnabled = true;
            cmbMesa.Location = new Point(76, 42);
            cmbMesa.Margin = new Padding(3, 2, 3, 2);
            cmbMesa.Name = "cmbMesa";
            cmbMesa.Size = new Size(177, 23);
            cmbMesa.TabIndex = 0;
            // 
            // lblMesa
            // 
            lblMesa.AutoSize = true;
            lblMesa.Location = new Point(30, 45);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(38, 15);
            lblMesa.TabIndex = 0;
            lblMesa.Text = "Mesa:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(310, 88);
            cmbStatus.Margin = new Padding(3, 2, 3, 2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(170, 23);
            cmbStatus.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(262, 91);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status:";
            // 
            // tabPagePedido
            // 
            tabPagePedido.BackColor = SystemColors.Window;
            tabPagePedido.Controls.Add(gridProdutos);
            tabPagePedido.Controls.Add(btnServiços);
            tabPagePedido.Controls.Add(btnBebidas);
            tabPagePedido.Controls.Add(btnComidas);
            tabPagePedido.Controls.Add(label3);
            tabPagePedido.Controls.Add(lblProduto);
            tabPagePedido.Controls.Add(cmbProdutos);
            tabPagePedido.Controls.Add(txtQuantiaItens);
            tabPagePedido.Controls.Add(button2);
            tabPagePedido.Controls.Add(button1);
            tabPagePedido.Controls.Add(btnAddItens);
            tabPagePedido.Location = new Point(4, 24);
            tabPagePedido.Margin = new Padding(3, 2, 3, 2);
            tabPagePedido.Name = "tabPagePedido";
            tabPagePedido.Padding = new Padding(3, 2, 3, 2);
            tabPagePedido.Size = new Size(525, 246);
            tabPagePedido.TabIndex = 1;
            tabPagePedido.Text = "Pedido";
            // 
            // gridProdutos
            // 
            gridProdutos.AllowUserToAddRows = false;
            gridProdutos.AllowUserToDeleteRows = false;
            gridProdutos.BackgroundColor = SystemColors.ControlLight;
            gridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProdutos.Dock = DockStyle.Right;
            gridProdutos.Location = new Point(257, 2);
            gridProdutos.Margin = new Padding(3, 2, 3, 2);
            gridProdutos.Name = "gridProdutos";
            gridProdutos.ReadOnly = true;
            gridProdutos.RowHeadersVisible = false;
            gridProdutos.RowHeadersWidth = 51;
            gridProdutos.Size = new Size(265, 242);
            gridProdutos.TabIndex = 8;
            // 
            // btnServiços
            // 
            btnServiços.BackColor = Color.White;
            btnServiços.Cursor = Cursors.Hand;
            btnServiços.Location = new Point(174, 61);
            btnServiços.Margin = new Padding(3, 2, 3, 2);
            btnServiços.Name = "btnServiços";
            btnServiços.Size = new Size(52, 32);
            btnServiços.TabIndex = 3;
            btnServiços.UseVisualStyleBackColor = false;
            btnServiços.Click += btnServiços_Click;
            // 
            // btnBebidas
            // 
            btnBebidas.BackColor = Color.White;
            btnBebidas.Cursor = Cursors.Hand;
            btnBebidas.Location = new Point(98, 61);
            btnBebidas.Margin = new Padding(3, 2, 3, 2);
            btnBebidas.Name = "btnBebidas";
            btnBebidas.Size = new Size(53, 32);
            btnBebidas.TabIndex = 2;
            btnBebidas.UseVisualStyleBackColor = false;
            btnBebidas.Click += btnBebidas_Click;
            // 
            // btnComidas
            // 
            btnComidas.BackColor = Color.White;
            btnComidas.Cursor = Cursors.Hand;
            btnComidas.Location = new Point(28, 61);
            btnComidas.Margin = new Padding(3, 2, 3, 2);
            btnComidas.Name = "btnComidas";
            btnComidas.Size = new Size(49, 32);
            btnComidas.TabIndex = 1;
            btnComidas.UseVisualStyleBackColor = false;
            btnComidas.Click += btnComidas_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 91);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblProduto.Location = new Point(76, 14);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(94, 30);
            lblProduto.TabIndex = 6;
            lblProduto.Text = "Produto";
            // 
            // cmbProdutos
            // 
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Location = new Point(29, 97);
            cmbProdutos.Margin = new Padding(3, 2, 3, 2);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(197, 23);
            cmbProdutos.TabIndex = 4;
            // 
            // txtQuantiaItens
            // 
            txtQuantiaItens.BackColor = SystemColors.Control;
            txtQuantiaItens.BorderStyle = BorderStyle.FixedSingle;
            txtQuantiaItens.Font = new Font("Segoe UI", 12F);
            txtQuantiaItens.Location = new Point(60, 158);
            txtQuantiaItens.Margin = new Padding(3, 2, 3, 2);
            txtQuantiaItens.Name = "txtQuantiaItens";
            txtQuantiaItens.Size = new Size(135, 29);
            txtQuantiaItens.TabIndex = 4;
            txtQuantiaItens.Text = "0";
            txtQuantiaItens.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(201, 158);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(26, 29);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(28, 158);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(26, 29);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAddItens
            // 
            btnAddItens.Cursor = Cursors.Hand;
            btnAddItens.FlatAppearance.BorderColor = Color.White;
            btnAddItens.Location = new Point(28, 191);
            btnAddItens.Margin = new Padding(3, 2, 3, 2);
            btnAddItens.Name = "btnAddItens";
            btnAddItens.Size = new Size(199, 38);
            btnAddItens.TabIndex = 5;
            btnAddItens.UseVisualStyleBackColor = false;
            btnAddItens.Click += btnAddItens_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(27, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLight;
            txtId.Enabled = false;
            txtId.Location = new Point(54, 16);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(58, 23);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(448, 345);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 37);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(340, 345);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(102, 37);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // TelaPedidoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 391);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(TabComanda);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "TelaPedidoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro De Pedidos";
            TabComanda.ResumeLayout(false);
            tabPageComanda.ResumeLayout(false);
            tabPageComanda.PerformLayout();
            groupBoxPagamento.ResumeLayout(false);
            groupBoxPagamento.PerformLayout();
            tabPagePedido.ResumeLayout(false);
            tabPagePedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemover;
        private TabControl TabComanda;
        private TabPage tabPageComanda;
        private TabPage tabPagePedido;
        private ComboBox cmbGarçom;
        private Label lblGarçom;
        private ComboBox cmbMesa;
        private Label lblMesa;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private Label lblId;
        private TextBox txtId;
        private GroupBox groupBoxPagamento;
        private Label lblDesconto;
        private Label lblTotal;
        private TextBox txtValorTotal;
        private TextBox txtDesconto;
        private CheckBox chkServiço;
        private Button btnAddItens;
        private Button button1;
        private TextBox txtQuantiaItens;
        private Button button2;
        private Label label3;
        private Label lblProduto;
        private ComboBox cmbProdutos;
        private Button btnServiços;
        private Button btnBebidas;
        private Button btnComidas;
        private DataGridView gridProdutos;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}