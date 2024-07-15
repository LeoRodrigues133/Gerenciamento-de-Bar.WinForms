namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPedido
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
            comboBox1.Size = new Size(160, 28);
            comboBox1.TabIndex = 0;
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Location = new Point(20, 40);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(63, 20);
            lblPeriodo.TabIndex = 0;
            lblPeriodo.Text = "Periodo:";
            // 
            // cmbPeriodo
            // 
            cmbPeriodo.FormattingEnabled = true;
            cmbPeriodo.Location = new Point(89, 37);
            cmbPeriodo.Name = "cmbPeriodo";
            cmbPeriodo.Size = new Size(249, 28);
            cmbPeriodo.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(343, 71);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(117, 49);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // listExtrato
            // 
            listExtrato.Dock = DockStyle.Bottom;
            listExtrato.FormattingEnabled = true;
            listExtrato.Location = new Point(0, 141);
            listExtrato.Name = "listExtrato";
            listExtrato.Size = new Size(595, 404);
            listExtrato.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(466, 71);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(117, 49);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaExtratoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 545);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscar);
            Controls.Add(cmbPeriodo);
            Controls.Add(listExtrato);
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
        private ListBox listExtrato;
        private ComboBox cmbPeriodo;
        private Button btnCancelar;
        private Button btnBuscar;
    }
}