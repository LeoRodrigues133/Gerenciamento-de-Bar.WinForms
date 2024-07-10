namespace Rubinho_s_Bar___Tchelos.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            gerenciarToolStripMenuItem = new ToolStripMenuItem();
            mesasToolStripMenuItem = new ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnPagamentos = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnGerarExtrato = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripTipo = new ToolStripLabel();
            pnlRegistros = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gerenciarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gerenciarToolStripMenuItem
            // 
            gerenciarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mesasToolStripMenuItem, funcionáriosToolStripMenuItem, pedidosToolStripMenuItem, produtosToolStripMenuItem });
            gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            gerenciarToolStripMenuItem.Size = new Size(84, 24);
            gerenciarToolStripMenuItem.Text = "Gerenciar";
            // 
            // mesasToolStripMenuItem
            // 
            mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            mesasToolStripMenuItem.Size = new Size(161, 24);
            mesasToolStripMenuItem.Text = "Mesas";
            mesasToolStripMenuItem.Click += mesasToolStripMenuItem_Click;
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new Size(161, 24);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            funcionáriosToolStripMenuItem.Click += funcionáriosToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(161, 24);
            pedidosToolStripMenuItem.Text = "Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(161, 24);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 25);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(185, 20);
            statusLabelPrincipal.Text = "Visualizando 0 registro(s)...";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator2, btnPagamentos, toolStripSeparator1, btnGerarExtrato, toolStripSeparator4, toolStripTipo });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 41);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Image = Properties.Resources.btnAdicionar;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(5);
            btnAdicionar.Size = new Size(38, 38);
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.btnEditar;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(38, 38);
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = Properties.Resources.btnRemover;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(38, 38);
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 41);
            // 
            // btnPagamentos
            // 
            btnPagamentos.Enabled = false;
            btnPagamentos.Image = Properties.Resources.btnComandas;
            btnPagamentos.Name = "btnPagamentos";
            btnPagamentos.Padding = new Padding(5);
            btnPagamentos.Size = new Size(98, 38);
            btnPagamentos.Text = "Comandas";
            btnPagamentos.Click += btnPagamentos_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 41);
            // 
            // btnGerarExtrato
            // 
            btnGerarExtrato.Enabled = false;
            btnGerarExtrato.Image = Properties.Resources.btnGerarExtrato;
            btnGerarExtrato.Name = "btnGerarExtrato";
            btnGerarExtrato.Padding = new Padding(5);
            btnGerarExtrato.Size = new Size(78, 38);
            btnGerarExtrato.Text = "Extrato";
            btnGerarExtrato.Click += btnGerarExtrato_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 41);
            // 
            // toolStripTipo
            // 
            toolStripTipo.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            toolStripTipo.Name = "toolStripTipo";
            toolStripTipo.Size = new Size(118, 38);
            toolStripTipo.Text = "Tipo de Cadastro";
            // 
            // pnlRegistros
            // 
            pnlRegistros.Location = new Point(0, 60);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(800, 367);
            pnlRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão De Bar";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gerenciarToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabelPrincipal;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel pnlRegistros;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnPagamentos;
        private ToolStripButton btnGerarExtrato;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripTipo;
        private ToolStripMenuItem mesasToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
    }
}