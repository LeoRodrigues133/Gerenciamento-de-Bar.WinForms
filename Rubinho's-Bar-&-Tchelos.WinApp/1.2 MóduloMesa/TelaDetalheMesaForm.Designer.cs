namespace Rubinho_s_Bar___Tchelos.WinApp._1._2_MóduloMesa
{
    partial class TelaDetalheMesaForm
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
            cmbComandas = new ComboBox();
            listPedidos = new ListBox();
            lblValor = new Label();
            lblValortotal = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(307, 349);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 38);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Fechar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cmbComandas
            // 
            cmbComandas.FormattingEnabled = true;
            cmbComandas.Location = new Point(70, 38);
            cmbComandas.Name = "cmbComandas";
            cmbComandas.Size = new Size(287, 23);
            cmbComandas.TabIndex = 1;
            cmbComandas.SelectedIndexChanged += cmbComandas_SelectedIndexChanged;
            // 
            // listPedidos
            // 
            listPedidos.FormattingEnabled = true;
            listPedidos.ItemHeight = 15;
            listPedidos.Location = new Point(12, 99);
            listPedidos.Name = "listPedidos";
            listPedidos.Size = new Size(411, 244);
            listPedidos.TabIndex = 2;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(88, 361);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 3;
            lblValor.Text = "Valor";
            // 
            // lblValortotal
            // 
            lblValortotal.AutoSize = true;
            lblValortotal.Location = new Point(19, 361);
            lblValortotal.Name = "lblValortotal";
            lblValortotal.Size = new Size(63, 15);
            lblValortotal.TabIndex = 3;
            lblValortotal.Text = "Valor total:";
            // 
            // TelaDetalheMesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 399);
            Controls.Add(lblValortotal);
            Controls.Add(lblValor);
            Controls.Add(listPedidos);
            Controls.Add(cmbComandas);
            Controls.Add(btnCancelar);
            Name = "TelaDetalheMesaForm";
            Text = "DetalheMesaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private ComboBox cmbComandas;
        private ListBox listPedidos;
        private Label lblValor;
        private Label lblValortotal;
    }
}