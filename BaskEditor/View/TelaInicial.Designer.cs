
namespace BaskEditor
{
    partial class TelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinharTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.configuraçõesImpressãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsNovo = new System.Windows.Forms.ToolStripButton();
            this.tsAbrir = new System.Windows.Forms.ToolStripButton();
            this.tsSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsNegrito = new System.Windows.Forms.ToolStripButton();
            this.tsItalico = new System.Windows.Forms.ToolStripButton();
            this.tsSublinhado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsSair = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(166, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirDocumentoToolStripMenuItem,
            this.salvarDocumentoToolStripMenuItem,
            this.toolStripSeparator1,
            this.fecharDocumentoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo Documento";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirDocumentoToolStripMenuItem
            // 
            this.abrirDocumentoToolStripMenuItem.Name = "abrirDocumentoToolStripMenuItem";
            this.abrirDocumentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirDocumentoToolStripMenuItem.Text = "Abrir Documento";
            this.abrirDocumentoToolStripMenuItem.Click += new System.EventHandler(this.abrirDocumentoToolStripMenuItem_Click);
            // 
            // salvarDocumentoToolStripMenuItem
            // 
            this.salvarDocumentoToolStripMenuItem.Name = "salvarDocumentoToolStripMenuItem";
            this.salvarDocumentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarDocumentoToolStripMenuItem.Text = "Salvar Documento";
            this.salvarDocumentoToolStripMenuItem.Click += new System.EventHandler(this.salvarDocumentoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // fecharDocumentoToolStripMenuItem
            // 
            this.fecharDocumentoToolStripMenuItem.Name = "fecharDocumentoToolStripMenuItem";
            this.fecharDocumentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fecharDocumentoToolStripMenuItem.Text = "Fechar Documento";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarFonteToolStripMenuItem,
            this.alinharTextoToolStripMenuItem,
            this.toolStripSeparator2,
            this.configuraçõesImpressãoToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // alterarFonteToolStripMenuItem
            // 
            this.alterarFonteToolStripMenuItem.Name = "alterarFonteToolStripMenuItem";
            this.alterarFonteToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.alterarFonteToolStripMenuItem.Text = "Alterar Fonte";
            this.alterarFonteToolStripMenuItem.Click += new System.EventHandler(this.alterarFonteToolStripMenuItem_Click);
            // 
            // alinharTextoToolStripMenuItem
            // 
            this.alinharTextoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esquerdaToolStripMenuItem,
            this.centralizadoToolStripMenuItem,
            this.direitaToolStripMenuItem});
            this.alinharTextoToolStripMenuItem.Name = "alinharTextoToolStripMenuItem";
            this.alinharTextoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.alinharTextoToolStripMenuItem.Text = "Alinhar Texto";
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.esquerdaToolStripMenuItem_Click);
            // 
            // centralizadoToolStripMenuItem
            // 
            this.centralizadoToolStripMenuItem.Name = "centralizadoToolStripMenuItem";
            this.centralizadoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.centralizadoToolStripMenuItem.Text = "Centralizado";
            this.centralizadoToolStripMenuItem.Click += new System.EventHandler(this.centralizadoToolStripMenuItem_Click);
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            this.direitaToolStripMenuItem.Click += new System.EventHandler(this.direitaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // configuraçõesImpressãoToolStripMenuItem
            // 
            this.configuraçõesImpressãoToolStripMenuItem.Name = "configuraçõesImpressãoToolStripMenuItem";
            this.configuraçõesImpressãoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.configuraçõesImpressãoToolStripMenuItem.Text = "Configurações Impressão";
            this.configuraçõesImpressãoToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesImpressãoToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNovo,
            this.tsAbrir,
            this.tsSalvar,
            this.tsSeparator1,
            this.tsNegrito,
            this.tsItalico,
            this.tsSublinhado,
            this.toolStripSeparator3,
            this.tsImprimir,
            this.tsSair});
            this.toolStrip1.Location = new System.Drawing.Point(13, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(208, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsNovo
            // 
            this.tsNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsNovo.Image")));
            this.tsNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNovo.Name = "tsNovo";
            this.tsNovo.Size = new System.Drawing.Size(23, 22);
            this.tsNovo.Text = "Novo";
            this.tsNovo.Click += new System.EventHandler(this.tsNovo_Click);
            // 
            // tsAbrir
            // 
            this.tsAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAbrir.Image = ((System.Drawing.Image)(resources.GetObject("tsAbrir.Image")));
            this.tsAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAbrir.Name = "tsAbrir";
            this.tsAbrir.Size = new System.Drawing.Size(23, 22);
            this.tsAbrir.Text = "Abrir";
            this.tsAbrir.Click += new System.EventHandler(this.tsAbrir_Click);
            // 
            // tsSalvar
            // 
            this.tsSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsSalvar.Image")));
            this.tsSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSalvar.Name = "tsSalvar";
            this.tsSalvar.Size = new System.Drawing.Size(23, 22);
            this.tsSalvar.Text = "Salvar";
            this.tsSalvar.Click += new System.EventHandler(this.tsSalvar_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsNegrito
            // 
            this.tsNegrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNegrito.Image = ((System.Drawing.Image)(resources.GetObject("tsNegrito.Image")));
            this.tsNegrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNegrito.Name = "tsNegrito";
            this.tsNegrito.Size = new System.Drawing.Size(23, 22);
            this.tsNegrito.Text = "Negrito";
            this.tsNegrito.Click += new System.EventHandler(this.tsNegrito_Click);
            // 
            // tsItalico
            // 
            this.tsItalico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsItalico.Image = ((System.Drawing.Image)(resources.GetObject("tsItalico.Image")));
            this.tsItalico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsItalico.Name = "tsItalico";
            this.tsItalico.Size = new System.Drawing.Size(23, 22);
            this.tsItalico.Text = "Itálico";
            this.tsItalico.Click += new System.EventHandler(this.tsItalico_Click);
            // 
            // tsSublinhado
            // 
            this.tsSublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSublinhado.Image = ((System.Drawing.Image)(resources.GetObject("tsSublinhado.Image")));
            this.tsSublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSublinhado.Name = "tsSublinhado";
            this.tsSublinhado.Size = new System.Drawing.Size(23, 22);
            this.tsSublinhado.Text = "Sublinhado";
            this.tsSublinhado.Click += new System.EventHandler(this.tsSublinhado_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsImprimir
            // 
            this.tsImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsImprimir.Image")));
            this.tsImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsImprimir.Name = "tsImprimir";
            this.tsImprimir.Size = new System.Drawing.Size(23, 22);
            this.tsImprimir.Text = "Imprimir";
            this.tsImprimir.Click += new System.EventHandler(this.tsImprimir_Click);
            // 
            // tsSair
            // 
            this.tsSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSair.Image = ((System.Drawing.Image)(resources.GetObject("tsSair.Image")));
            this.tsSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSair.Name = "tsSair";
            this.tsSair.Size = new System.Drawing.Size(23, 22);
            this.tsSair.Text = "Sair";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.richTextBox1.Location = new System.Drawing.Point(0, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 395);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.Text = "BaskEditor - v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fecharDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarFonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinharTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralizadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesImpressãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNovo;
        private System.Windows.Forms.ToolStripButton tsAbrir;
        private System.Windows.Forms.ToolStripButton tsSalvar;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripButton tsNegrito;
        private System.Windows.Forms.ToolStripButton tsItalico;
        private System.Windows.Forms.ToolStripButton tsSublinhado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsImprimir;
        private System.Windows.Forms.ToolStripButton tsSair;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

