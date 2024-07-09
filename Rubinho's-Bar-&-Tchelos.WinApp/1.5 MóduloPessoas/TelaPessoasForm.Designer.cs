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
            lblId.Location = new Point(36, 18);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLight;
            txtId.Enabled = false;
            txtId.Location = new Point(62, 16);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(53, 23);
            txtId.TabIndex = 0;
            txtId.Text = "0";
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(324, 65);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 50);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(216, 65);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(102, 50);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 43);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Location = new Point(62, 41);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(364, 23);
            txtNome.TabIndex = 1;
            // 
            // cmbCargo
            // 
            cmbCargo.Cursor = Cursors.IBeam;
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(62, 92);
            cmbCargo.Margin = new Padding(3, 2, 3, 2);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(148, 23);
            cmbCargo.TabIndex = 3;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(13, 94);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(42, 15);
            lblCargo.TabIndex = 0;
            lblCargo.Text = "Cargo:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(12, 68);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(29, 15);
            lblCpf.TabIndex = 0;
            lblCpf.Text = "Cpf:";
            // 
            // txtCpf
            // 
            txtCpf.Cursor = Cursors.IBeam;
            txtCpf.Location = new Point(62, 66);
            txtCpf.Margin = new Padding(3, 2, 3, 2);
            txtCpf.MaxLength = 14;
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(148, 23);
            txtCpf.TabIndex = 2;
            txtCpf.KeyDown += txtCpf_MaskCPF;
            // 
            // TelaPessoasForm
            // 
            AcceptButton = btnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(438, 127);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPessoasForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro De Funcionarios";
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