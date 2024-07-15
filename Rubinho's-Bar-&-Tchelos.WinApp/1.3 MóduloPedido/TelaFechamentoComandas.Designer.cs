namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPedido
{
    partial class TelaFechamentoComandas
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
            label1 = new Label();
            label2 = new Label();
            lblMesa = new Label();
            lblGarcom = new Label();
            label3 = new Label();
            listaPedidos = new ListBox();
            label4 = new Label();
            lblPreco = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(18, 46);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 0;
            label1.Text = "Garçom:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(18, 18);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 1;
            label2.Text = "Mesa:";
            // 
            // lblMesa
            // 
            lblMesa.AutoSize = true;
            lblMesa.Font = new Font("Segoe UI", 9.75F);
            lblMesa.Location = new Point(58, 18);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(40, 17);
            lblMesa.TabIndex = 2;
            lblMesa.Text = "Mesa";
            // 
            // lblGarcom
            // 
            lblGarcom.AutoSize = true;
            lblGarcom.Font = new Font("Segoe UI", 9.75F);
            lblGarcom.Location = new Point(71, 46);
            lblGarcom.Name = "lblGarcom";
            lblGarcom.Size = new Size(54, 17);
            lblGarcom.TabIndex = 3;
            lblGarcom.Text = "Garçom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 82);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 4;
            label3.Text = "Pedidos:";
            // 
            // listaPedidos
            // 
            listaPedidos.FormattingEnabled = true;
            listaPedidos.ItemHeight = 15;
            listaPedidos.Location = new Point(18, 102);
            listaPedidos.Name = "listaPedidos";
            listaPedidos.Size = new Size(258, 109);
            listaPedidos.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 223);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Total: R$";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(64, 223);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 7;
            lblPreco.Text = "preço";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(193, 218);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 25);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(105, 218);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 25);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // TelaFechamentoComandas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 249);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(lblPreco);
            Controls.Add(label4);
            Controls.Add(listaPedidos);
            Controls.Add(label3);
            Controls.Add(lblGarcom);
            Controls.Add(lblMesa);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "TelaFechamentoComandas";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fechamento De Comandas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblMesa;
        private Label lblGarcom;
        private Label label3;
        private ListBox listaPedidos;
        private Label label4;
        private Label lblPreco;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}