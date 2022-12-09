namespace Estamparia_LP2A4
{
    partial class TelaHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirRelatórioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LbHome = new System.Windows.Forms.Label();
            this.McAdm = new System.Windows.Forms.MonthCalendar();
            this.totalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.emitirRelatórioDeVendasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(333, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem1,
            this.editarToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            this.cadastroToolStripMenuItem1.Click += new System.EventHandler(this.cadastroToolStripMenuItem1_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.editarToolStripMenuItem.Text = "Listar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // emitirRelatórioDeVendasToolStripMenuItem
            // 
            this.emitirRelatórioDeVendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalToolStripMenuItem,
            this.anoToolStripMenuItem,
            this.mêsToolStripMenuItem,
            this.diaToolStripMenuItem});
            this.emitirRelatórioDeVendasToolStripMenuItem.Name = "emitirRelatórioDeVendasToolStripMenuItem";
            this.emitirRelatórioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.emitirRelatórioDeVendasToolStripMenuItem.Text = "Emitir Relatório de vendas";
            // 
            // LbHome
            // 
            this.LbHome.AutoSize = true;
            this.LbHome.BackColor = System.Drawing.Color.Transparent;
            this.LbHome.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHome.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LbHome.Location = new System.Drawing.Point(41, 204);
            this.LbHome.Name = "LbHome";
            this.LbHome.Size = new System.Drawing.Size(247, 44);
            this.LbHome.TabIndex = 1;
            this.LbHome.Text = "ESTAMPARIA";
            // 
            // McAdm
            // 
            this.McAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.McAdm.Location = new System.Drawing.Point(49, 33);
            this.McAdm.Name = "McAdm";
            this.McAdm.TabIndex = 3;
            this.McAdm.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McAdm_DateSelected);
            // 
            // totalToolStripMenuItem
            // 
            this.totalToolStripMenuItem.Name = "totalToolStripMenuItem";
            this.totalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.totalToolStripMenuItem.Text = "Total";
            this.totalToolStripMenuItem.Click += new System.EventHandler(this.totalToolStripMenuItem_Click);
            // 
            // anoToolStripMenuItem
            // 
            this.anoToolStripMenuItem.Name = "anoToolStripMenuItem";
            this.anoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.anoToolStripMenuItem.Text = "Ano";
            this.anoToolStripMenuItem.Click += new System.EventHandler(this.anoToolStripMenuItem_Click);
            // 
            // mêsToolStripMenuItem
            // 
            this.mêsToolStripMenuItem.Name = "mêsToolStripMenuItem";
            this.mêsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mêsToolStripMenuItem.Text = "Mês";
            this.mêsToolStripMenuItem.Click += new System.EventHandler(this.mêsToolStripMenuItem_Click);
            // 
            // diaToolStripMenuItem
            // 
            this.diaToolStripMenuItem.Name = "diaToolStripMenuItem";
            this.diaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diaToolStripMenuItem.Text = "Dia";
            this.diaToolStripMenuItem.Click += new System.EventHandler(this.diaToolStripMenuItem_Click);
            // 
            // TelaHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(333, 254);
            this.Controls.Add(this.McAdm);
            this.Controls.Add(this.LbHome);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TelaHome";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTAMPARIA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.Label LbHome;
        private System.Windows.Forms.MonthCalendar McAdm;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirRelatórioDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diaToolStripMenuItem;
    }
}

