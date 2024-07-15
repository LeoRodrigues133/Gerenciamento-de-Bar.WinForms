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
            lblPeriodo = new Label();
            listExtrato = new ListBox();
            cmbPeriodo = new ComboBox();
            lblData = new Label();
            cmbData = new ComboBox();
            btnCancelar = new Button();
            btnBuscar = new Button();
            SuspendLayout();
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
            // listExtrato
            // 
            listExtrato.Dock = DockStyle.Bottom;
            listExtrato.FormattingEnabled = true;
            listExtrato.Location = new Point(0, 141);
            listExtrato.Name = "listExtrato";
            listExtrato.Size = new Size(595, 404);
            listExtrato.TabIndex = 1;
            // 
            // cmbPeriodo
            // 
            cmbPeriodo.FormattingEnabled = true;
            cmbPeriodo.Location = new Point(89, 37);
            cmbPeriodo.Name = "cmbPeriodo";
            cmbPeriodo.Size = new Size(249, 28);
            cmbPeriodo.TabIndex = 1;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(39, 74);
            lblData.Name = "lblData";
            lblData.Size = new Size(44, 20);
            lblData.TabIndex = 0;
            lblData.Text = "Data:";
            // 
            // cmbData
            // 
            cmbData.FormattingEnabled = true;
            cmbData.Location = new Point(89, 71);
            cmbData.Name = "cmbData";
            cmbData.Size = new Size(189, 28);
            cmbData.TabIndex = 2;
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
            // TelaExtratoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 545);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscar);
            Controls.Add(cmbData);
            Controls.Add(cmbPeriodo);
            Controls.Add(lblData);
            Controls.Add(listExtrato);
            Controls.Add(lblPeriodo);
            Name = "TelaExtratoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaExtratoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPeriodo;
        private ListBox listExtrato;
        private ComboBox cmbPeriodo;
        private Label lblData;
        private ComboBox cmbData;
        private Button btnCancelar;
        private Button btnBuscar;
    }
}