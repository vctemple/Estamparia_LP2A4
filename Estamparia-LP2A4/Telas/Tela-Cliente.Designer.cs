namespace Estamparia_LP2A4.Telas
{
    partial class Tela_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Cliente));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telaAdmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrinhoDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LvCliProd = new System.Windows.Forms.ListView();
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estampa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Img1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Img2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LbCliLogo = new System.Windows.Forms.Label();
            this.PbCliIma1 = new System.Windows.Forms.PictureBox();
            this.PbCliIma2 = new System.Windows.Forms.PictureBox();
            this.BtCliAddCarr = new System.Windows.Forms.Button();
            this.LbCliSaudacao = new System.Windows.Forms.Label();
            this.LbCliNome = new System.Windows.Forms.Label();
            this.TbTelaCliQtd = new System.Windows.Forms.TextBox();
            this.LbQtd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbValorText = new System.Windows.Forms.Label();
            this.LbValor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LbTotalText = new System.Windows.Forms.Label();
            this.LbTotal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCliIma1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCliIma2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.telaAdmToolStripMenuItem,
            this.carrinhoDeComprasToolStripMenuItem,
            this.FecharToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // telaAdmToolStripMenuItem
            // 
            this.telaAdmToolStripMenuItem.Name = "telaAdmToolStripMenuItem";
            this.telaAdmToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.telaAdmToolStripMenuItem.Text = "Tela Adm";
            this.telaAdmToolStripMenuItem.Visible = false;
            this.telaAdmToolStripMenuItem.Click += new System.EventHandler(this.telaAdmToolStripMenuItem_Click);
            // 
            // carrinhoDeComprasToolStripMenuItem
            // 
            this.carrinhoDeComprasToolStripMenuItem.Name = "carrinhoDeComprasToolStripMenuItem";
            this.carrinhoDeComprasToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.carrinhoDeComprasToolStripMenuItem.Text = "Carrinho  de compras";
            this.carrinhoDeComprasToolStripMenuItem.Click += new System.EventHandler(this.carrinhoDeComprasToolStripMenuItem_Click);
            // 
            // FecharToolStripMenuItem
            // 
            this.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem";
            this.FecharToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.FecharToolStripMenuItem.Text = "Fechar programa";
            this.FecharToolStripMenuItem.Click += new System.EventHandler(this.FecharToolStripMenuItem_Click);
            // 
            // LvCliProd
            // 
            this.LvCliProd.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.LvCliProd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Marca,
            this.ID,
            this.Estampa,
            this.Preco,
            this.Cor,
            this.Tamanho,
            this.Qtd,
            this.Img1,
            this.Img2});
            this.LvCliProd.HideSelection = false;
            this.LvCliProd.HotTracking = true;
            this.LvCliProd.HoverSelection = true;
            this.LvCliProd.Location = new System.Drawing.Point(282, 65);
            this.LvCliProd.Name = "LvCliProd";
            this.LvCliProd.Size = new System.Drawing.Size(574, 457);
            this.LvCliProd.TabIndex = 1;
            this.LvCliProd.UseCompatibleStateImageBehavior = false;
            this.LvCliProd.View = System.Windows.Forms.View.Details;
            this.LvCliProd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvCliProd_MouseClick);
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            this.Marca.Width = 154;
            // 
            // ID
            // 
            this.ID.Width = 0;
            // 
            // Estampa
            // 
            this.Estampa.Text = "Estampa";
            this.Estampa.Width = 144;
            // 
            // Preco
            // 
            this.Preco.Text = "Preço";
            this.Preco.Width = 96;
            // 
            // Cor
            // 
            this.Cor.Text = "Cor";
            this.Cor.Width = 92;
            // 
            // Tamanho
            // 
            this.Tamanho.Text = "Tamanho";
            this.Tamanho.Width = 86;
            // 
            // Qtd
            // 
            this.Qtd.Text = "Quantidade";
            this.Qtd.Width = 0;
            // 
            // Img1
            // 
            this.Img1.Text = "Img1";
            this.Img1.Width = 0;
            // 
            // Img2
            // 
            this.Img2.Text = "Img2";
            this.Img2.Width = 0;
            // 
            // LbCliLogo
            // 
            this.LbCliLogo.AutoSize = true;
            this.LbCliLogo.BackColor = System.Drawing.Color.Transparent;
            this.LbCliLogo.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCliLogo.ForeColor = System.Drawing.Color.DimGray;
            this.LbCliLogo.Location = new System.Drawing.Point(643, 24);
            this.LbCliLogo.Name = "LbCliLogo";
            this.LbCliLogo.Size = new System.Drawing.Size(213, 38);
            this.LbCliLogo.TabIndex = 2;
            this.LbCliLogo.Text = "ESTAMPARIA";
            // 
            // PbCliIma1
            // 
            this.PbCliIma1.Location = new System.Drawing.Point(12, 65);
            this.PbCliIma1.Name = "PbCliIma1";
            this.PbCliIma1.Size = new System.Drawing.Size(260, 260);
            this.PbCliIma1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCliIma1.TabIndex = 3;
            this.PbCliIma1.TabStop = false;
            // 
            // PbCliIma2
            // 
            this.PbCliIma2.Location = new System.Drawing.Point(12, 331);
            this.PbCliIma2.Name = "PbCliIma2";
            this.PbCliIma2.Size = new System.Drawing.Size(260, 260);
            this.PbCliIma2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCliIma2.TabIndex = 4;
            this.PbCliIma2.TabStop = false;
            // 
            // BtCliAddCarr
            // 
            this.BtCliAddCarr.BackColor = System.Drawing.SystemColors.Window;
            this.BtCliAddCarr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtCliAddCarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCliAddCarr.Location = new System.Drawing.Point(356, 26);
            this.BtCliAddCarr.Name = "BtCliAddCarr";
            this.BtCliAddCarr.Size = new System.Drawing.Size(153, 23);
            this.BtCliAddCarr.TabIndex = 6;
            this.BtCliAddCarr.Text = "Adicionar ao carrinho";
            this.BtCliAddCarr.UseVisualStyleBackColor = false;
            this.BtCliAddCarr.Click += new System.EventHandler(this.BtCliAddCarr_Click);
            // 
            // LbCliSaudacao
            // 
            this.LbCliSaudacao.AutoSize = true;
            this.LbCliSaudacao.BackColor = System.Drawing.Color.White;
            this.LbCliSaudacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCliSaudacao.Location = new System.Drawing.Point(686, 4);
            this.LbCliSaudacao.Name = "LbCliSaudacao";
            this.LbCliSaudacao.Size = new System.Drawing.Size(74, 16);
            this.LbCliSaudacao.TabIndex = 12;
            this.LbCliSaudacao.Text = "Bem vindo:";
            // 
            // LbCliNome
            // 
            this.LbCliNome.AutoSize = true;
            this.LbCliNome.BackColor = System.Drawing.Color.White;
            this.LbCliNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCliNome.Location = new System.Drawing.Point(766, 4);
            this.LbCliNome.Name = "LbCliNome";
            this.LbCliNome.Size = new System.Drawing.Size(44, 16);
            this.LbCliNome.TabIndex = 11;
            this.LbCliNome.Text = "label1";
            // 
            // TbTelaCliQtd
            // 
            this.TbTelaCliQtd.Location = new System.Drawing.Point(171, 29);
            this.TbTelaCliQtd.Name = "TbTelaCliQtd";
            this.TbTelaCliQtd.Size = new System.Drawing.Size(67, 20);
            this.TbTelaCliQtd.TabIndex = 13;
            this.TbTelaCliQtd.TextChanged += new System.EventHandler(this.TbTelaCliQtd_TextChanged);
            // 
            // LbQtd
            // 
            this.LbQtd.AutoSize = true;
            this.LbQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbQtd.Location = new System.Drawing.Point(168, 13);
            this.LbQtd.Name = "LbQtd";
            this.LbQtd.Size = new System.Drawing.Size(72, 13);
            this.LbQtd.TabIndex = 14;
            this.LbQtd.Text = "Quantidade";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.LbValor);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LbTotal);
            this.panel1.Controls.Add(this.BtCliAddCarr);
            this.panel1.Controls.Add(this.TbTelaCliQtd);
            this.panel1.Controls.Add(this.LbQtd);
            this.panel1.Location = new System.Drawing.Point(282, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 63);
            this.panel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.LbValorText);
            this.panel3.Location = new System.Drawing.Point(66, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(78, 20);
            this.panel3.TabIndex = 19;
            // 
            // LbValorText
            // 
            this.LbValorText.AutoSize = true;
            this.LbValorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValorText.Location = new System.Drawing.Point(3, 3);
            this.LbValorText.Name = "LbValorText";
            this.LbValorText.Size = new System.Drawing.Size(21, 13);
            this.LbValorText.TabIndex = 16;
            this.LbValorText.Text = "R$";
            this.LbValorText.TextChanged += new System.EventHandler(this.LbValorText_TextChanged);
            // 
            // LbValor
            // 
            this.LbValor.AutoSize = true;
            this.LbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValor.Location = new System.Drawing.Point(63, 13);
            this.LbValor.Name = "LbValor";
            this.LbValor.Size = new System.Drawing.Size(81, 13);
            this.LbValor.TabIndex = 18;
            this.LbValor.Text = "Valor do item";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.LbTotalText);
            this.panel2.Location = new System.Drawing.Point(265, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 20);
            this.panel2.TabIndex = 17;
            // 
            // LbTotalText
            // 
            this.LbTotalText.AutoSize = true;
            this.LbTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalText.Location = new System.Drawing.Point(3, 3);
            this.LbTotalText.Name = "LbTotalText";
            this.LbTotalText.Size = new System.Drawing.Size(21, 13);
            this.LbTotalText.TabIndex = 16;
            this.LbTotalText.Text = "R$";
            // 
            // LbTotal
            // 
            this.LbTotal.AutoSize = true;
            this.LbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotal.Location = new System.Drawing.Point(262, 13);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(36, 13);
            this.LbTotal.TabIndex = 15;
            this.LbTotal.Text = "Total";
            // 
            // Tela_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(868, 601);
            this.Controls.Add(this.LbCliNome);
            this.Controls.Add(this.LbCliSaudacao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PbCliIma2);
            this.Controls.Add(this.PbCliIma1);
            this.Controls.Add(this.LbCliLogo);
            this.Controls.Add(this.LvCliProd);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Tela_Cliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTAMPARIA";
            this.Load += new System.EventHandler(this.Tela_Cliente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCliIma1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCliIma2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ListView LvCliProd;
        private System.Windows.Forms.Label LbCliLogo;
        private System.Windows.Forms.PictureBox PbCliIma1;
        private System.Windows.Forms.PictureBox PbCliIma2;
        private System.Windows.Forms.Button BtCliAddCarr;
        private System.Windows.Forms.ToolStripMenuItem carrinhoDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FecharToolStripMenuItem;
        private System.Windows.Forms.Label LbCliSaudacao;
        private System.Windows.Forms.Label LbCliNome;
        private System.Windows.Forms.ToolStripMenuItem telaAdmToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader Estampa;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.ColumnHeader Cor;
        private System.Windows.Forms.ColumnHeader Tamanho;
        private System.Windows.Forms.ColumnHeader Qtd;
        private System.Windows.Forms.ColumnHeader Img1;
        private System.Windows.Forms.ColumnHeader Img2;
        private System.Windows.Forms.TextBox TbTelaCliQtd;
        private System.Windows.Forms.Label LbQtd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbValorText;
        private System.Windows.Forms.Label LbValor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LbTotalText;
        private System.Windows.Forms.Label LbTotal;
    }
}