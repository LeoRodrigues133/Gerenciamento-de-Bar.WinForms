namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloProduto
{
    partial class TelaProdutoForm
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
            btnCancelar = new Button();
            btnSalvar = new Button();
            label1 = new Label();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            txtNome = new TextBox();
            lblId = new Label();
            txtId = new TextBox();
            lblValor = new Label();
            numValor = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(391, 144);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 31);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(282, 144);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(102, 31);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 109);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(14, 148);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 20);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(90, 144);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(185, 28);
            cmbCategoria.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(90, 105);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(399, 27);
            txtNome.TabIndex = 9;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(61, 32);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 10;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ActiveBorder;
            txtId.Enabled = false;
            txtId.Location = new Point(90, 28);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(55, 27);
            txtId.TabIndex = 11;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(40, 69);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(46, 20);
            lblValor.TabIndex = 12;
            lblValor.Text = "Valor:";
            // 
            // numValor
            // 
            numValor.Location = new Point(90, 67);
            numValor.Margin = new Padding(3, 4, 3, 4);
            numValor.Name = "numValor";
            numValor.Size = new Size(137, 27);
            numValor.TabIndex = 13;
            // 
            // TelaProdutoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 192);
            Controls.Add(numValor);
            Controls.Add(lblValor);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtNome);
            Controls.Add(cmbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaProdutoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro De produtos";
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnSalvar;
        private Label label1;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private TextBox txtNome;
        private Label lblId;
        private TextBox txtId;
        private Label lblValor;
        private NumericUpDown numValor;
    }
}