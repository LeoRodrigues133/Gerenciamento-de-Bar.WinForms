namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPessoas
{
    partial class TelaPessoasForm
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
            lblId = new Label();
            txtId = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            cmbCargo = new ComboBox();
            lblCargo = new Label();
            lblCpf = new Label();
            txtCpf = new TextBox();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(94, 70);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(123, 67);
            txtId.Name = "txtId";
            txtId.Size = new Size(61, 27);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(464, 236);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 49);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(342, 236);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(116, 49);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(66, 103);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(123, 100);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(362, 27);
            txtNome.TabIndex = 1;
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(123, 186);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(151, 28);
            cmbCargo.TabIndex = 4;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(67, 189);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(52, 20);
            lblCargo.TabIndex = 0;
            lblCargo.Text = "Cargo:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(66, 136);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(35, 20);
            lblCpf.TabIndex = 0;
            lblCpf.Text = "Cpf:";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(123, 133);
            txtCpf.MaxLength = 14;
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(169, 27);
            txtCpf.TabIndex = 1;
            txtCpf.KeyDown += txtCpf_MaskCPF;
            // 
            // TelaPessoasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 297);
            Controls.Add(cmbCargo);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(lblCpf);
            Controls.Add(lblCargo);
            Controls.Add(lblNome);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "TelaPessoasForm";
            Text = "TelaPessoasForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label lblNome;
        private TextBox txtNome;
        private ComboBox cmbCargo;
        private Label lblCargo;
        private Label lblCpf;
        private TextBox txtCpf;
    }
}