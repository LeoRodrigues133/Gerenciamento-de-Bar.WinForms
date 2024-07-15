namespace Rubinho_s_Bar___Tchelos.WinApp._1._3_MóduloPedido
{
    partial class TelaExtratoForm
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
            comboBox1 = new ComboBox();
            lblPeriodo = new Label();
            cmbPeriodo = new ComboBox();
            btnBuscar = new Button();
            listExtrato = new ListBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(-182, 182);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 23);
            comboBox1.TabIndex = 0;
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Location = new Point(64, 41);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(51, 15);
            lblPeriodo.TabIndex = 1;
            lblPeriodo.Text = "Período:";
            // 
            // cmbPeriodo
            // 
            cmbPeriodo.FormattingEnabled = true;
            cmbPeriodo.Location = new Point(121, 37);
            cmbPeriodo.Name = "cmbPeriodo";
            cmbPeriodo.Size = new Size(257, 23);
            cmbPeriodo.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.DialogResult = DialogResult.OK;
            btnBuscar.Location = new Point(279, 93);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 29);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // listExtrato
            // 
            listExtrato.Dock = DockStyle.Bottom;
            listExtrato.FormattingEnabled = true;
            listExtrato.ItemHeight = 15;
            listExtrato.Location = new Point(0, 128);
            listExtrato.Name = "listExtrato";
            listExtrato.Size = new Size(513, 319);
            listExtrato.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(393, 93);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaExtratoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 447);
            Controls.Add(listExtrato);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscar);
            Controls.Add(cmbPeriodo);
            Controls.Add(lblPeriodo);
            Controls.Add(comboBox1);
            Name = "TelaExtratoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaExtratoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label lblPeriodo;
        private ComboBox cmbPeriodo;
        private Button btnBuscar;
        private ListBox listExtrato;
        private Button btnCancelar;
    }
}