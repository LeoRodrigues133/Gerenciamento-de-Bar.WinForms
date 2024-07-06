namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloMesa
{
    partial class TelaMesaForm
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
            btnAdicionar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.Location = new Point(87, 72);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(116, 75);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(337, 187);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(116, 49);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(459, 187);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 49);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(212, 72);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(116, 75);
            btnEditar.TabIndex = 0;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.Location = new Point(337, 72);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(116, 75);
            btnExcluir.TabIndex = 0;
            btnExcluir.Text = "Remover";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // TelaMesaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 248);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Name = "TelaMesaForm";
            Text = "TelaMesaForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdicionar;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnExcluir;
    }
}