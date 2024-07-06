namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPedido
{
    partial class TelaPedidoForm
    {
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            comboBox1 = new ComboBox();
            txtQuantiaItens = new TextBox();
            button2 = new Button();
            button1 = new Button();
            btnAddItens = new Button();
            lblId = new Label();
            txtId = new TextBox();
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
            TabComanda.Location = new Point(24, 72);
            TabComanda.Name = "TabComanda";
            TabComanda.SelectedIndex = 0;
            TabComanda.Size = new Size(609, 366);
            TabComanda.TabIndex = 3;
            // 
            // tabPageComanda
            // 
            tabPageComanda.BackColor = SystemColors.GradientInactiveCaption;
            tabPageComanda.Controls.Add(chkServiço);
            tabPageComanda.Controls.Add(groupBoxPagamento);
            tabPageComanda.Controls.Add(cmbGarçom);
            tabPageComanda.Controls.Add(lblGarçom);
            tabPageComanda.Controls.Add(cmbMesa);
            tabPageComanda.Controls.Add(lblMesa);
            tabPageComanda.Controls.Add(cmbStatus);
            tabPageComanda.Controls.Add(lblStatus);
            tabPageComanda.Location = new Point(4, 29);
            tabPageComanda.Name = "tabPageComanda";
            tabPageComanda.Padding = new Padding(3);
            tabPageComanda.Size = new Size(601, 333);
            tabPageComanda.TabIndex = 0;
            tabPageComanda.Text = "Comanda";
            // 
            // chkServiço
            // 
            chkServiço.AutoSize = true;
            chkServiço.Location = new Point(414, 58);
            chkServiço.Name = "chkServiço";
            chkServiço.RightToLeft = RightToLeft.Yes;
            chkServiço.Size = new Size(134, 24);
            chkServiço.TabIndex = 4;
            chkServiço.Text = ":Taxa de serviço";
            chkServiço.UseVisualStyleBackColor = true;
            // 
            // groupBoxPagamento
            // 
            groupBoxPagamento.BackColor = Color.LightSlateGray;
            groupBoxPagamento.Controls.Add(textBox2);
            groupBoxPagamento.Controls.Add(textBox1);
            groupBoxPagamento.Controls.Add(lblTotal);
            groupBoxPagamento.Controls.Add(lblDesconto);
            groupBoxPagamento.Enabled = false;
            groupBoxPagamento.Location = new Point(6, 212);
            groupBoxPagamento.Name = "groupBoxPagamento";
            groupBoxPagamento.Size = new Size(589, 115);
            groupBoxPagamento.TabIndex = 3;
            groupBoxPagamento.TabStop = false;
            groupBoxPagamento.Text = "Pagamento";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightSlateGray;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(96, 77);
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(487, 20);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightSlateGray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(96, 38);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(487, 20);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(45, 80);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 20);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total:";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(15, 38);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(75, 20);
            lblDesconto.TabIndex = 0;
            lblDesconto.Text = "Desconto:";
            // 
            // cmbGarçom
            // 
            cmbGarçom.FormattingEnabled = true;
            cmbGarçom.Location = new Point(87, 117);
            cmbGarçom.Name = "cmbGarçom";
            cmbGarçom.Size = new Size(202, 28);
            cmbGarçom.TabIndex = 2;
            // 
            // lblGarçom
            // 
            lblGarçom.AutoSize = true;
            lblGarçom.Location = new Point(17, 121);
            lblGarçom.Name = "lblGarçom";
            lblGarçom.Size = new Size(64, 20);
            lblGarçom.TabIndex = 0;
            lblGarçom.Text = "Garçom:";
            // 
            // cmbMesa
            // 
            cmbMesa.FormattingEnabled = true;
            cmbMesa.Location = new Point(87, 56);
            cmbMesa.Name = "cmbMesa";
            cmbMesa.Size = new Size(202, 28);
            cmbMesa.TabIndex = 2;
            // 
            // lblMesa
            // 
            lblMesa.AutoSize = true;
            lblMesa.Location = new Point(34, 60);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(47, 20);
            lblMesa.TabIndex = 0;
            lblMesa.Text = "Mesa:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(354, 117);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(194, 28);
            cmbStatus.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(299, 121);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status";
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
            tabPagePedido.Controls.Add(comboBox1);
            tabPagePedido.Controls.Add(txtQuantiaItens);
            tabPagePedido.Controls.Add(button2);
            tabPagePedido.Controls.Add(button1);
            tabPagePedido.Controls.Add(btnAddItens);
            tabPagePedido.Location = new Point(4, 29);
            tabPagePedido.Name = "tabPagePedido";
            tabPagePedido.Padding = new Padding(3);
            tabPagePedido.Size = new Size(601, 333);
            tabPagePedido.TabIndex = 1;
            tabPagePedido.Text = "Pedido";
            // 
            // gridProdutos
            // 
            gridProdutos.AllowUserToAddRows = false;
            gridProdutos.AllowUserToDeleteRows = false;
            gridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProdutos.Dock = DockStyle.Right;
            gridProdutos.Location = new Point(295, 3);
            gridProdutos.Name = "gridProdutos";
            gridProdutos.ReadOnly = true;
            gridProdutos.RowHeadersVisible = false;
            gridProdutos.RowHeadersWidth = 51;
            gridProdutos.Size = new Size(303, 327);
            gridProdutos.TabIndex = 8;
            // 
            // btnServiços
            // 
            btnServiços.Image = Properties.Resources.btnServiço;
            btnServiços.Location = new Point(208, 59);
            btnServiços.Name = "btnServiços";
            btnServiços.Size = new Size(50, 42);
            btnServiços.TabIndex = 7;
            btnServiços.UseVisualStyleBackColor = true;
            // 
            // btnBebidas
            // 
            btnBebidas.Image = Properties.Resources.btnDrink;
            btnBebidas.Location = new Point(152, 59);
            btnBebidas.Name = "btnBebidas";
            btnBebidas.Size = new Size(50, 42);
            btnBebidas.TabIndex = 7;
            btnBebidas.UseVisualStyleBackColor = true;
            // 
            // btnComidas
            // 
            btnComidas.Image = Properties.Resources.btnComidas;
            btnComidas.Location = new Point(96, 59);
            btnComidas.Name = "btnComidas";
            btnComidas.Size = new Size(50, 42);
            btnComidas.TabIndex = 7;
            btnComidas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 121);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(6, 110);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(65, 20);
            lblProduto.TabIndex = 6;
            lblProduto.Text = "Produto:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(77, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 28);
            comboBox1.TabIndex = 5;
            // 
            // txtQuantiaItens
            // 
            txtQuantiaItens.BackColor = Color.AliceBlue;
            txtQuantiaItens.BorderStyle = BorderStyle.None;
            txtQuantiaItens.Font = new Font("Segoe UI", 12F);
            txtQuantiaItens.Location = new Point(70, 293);
            txtQuantiaItens.Name = "txtQuantiaItens";
            txtQuantiaItens.Size = new Size(154, 27);
            txtQuantiaItens.TabIndex = 4;
            txtQuantiaItens.Text = "0";
            txtQuantiaItens.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Image = Properties.Resources.btnAddQuantiaITem1;
            button2.Location = new Point(34, 291);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Image = Properties.Resources.btnRemoQuantiaItem1;
            button1.Location = new Point(230, 291);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnAddItens
            // 
            btnAddItens.Image = Properties.Resources.btnAddItem1;
            btnAddItens.Location = new Point(34, 220);
            btnAddItens.Name = "btnAddItens";
            btnAddItens.Size = new Size(226, 50);
            btnAddItens.TabIndex = 1;
            btnAddItens.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(31, 25);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(62, 22);
            txtId.Name = "txtId";
            txtId.Size = new Size(66, 27);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // TelaPedidoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 466);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(TabComanda);
            Name = "TelaPedidoForm";
            Text = "TelaPedidoForm";
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
        private TextBox textBox2;
        private TextBox textBox1;
        private CheckBox chkServiço;
        private Button btnAddItens;
        private Button button1;
        private TextBox txtQuantiaItens;
        private Button button2;
        private Label label3;
        private Label lblProduto;
        private ComboBox comboBox1;
        private Button btnServiços;
        private Button btnBebidas;
        private Button btnComidas;
        private DataGridView gridProdutos;
    }
}