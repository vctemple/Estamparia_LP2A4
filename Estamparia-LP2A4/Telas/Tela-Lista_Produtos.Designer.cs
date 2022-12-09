namespace Estamparia_LP2A4.Telas
{
    partial class Tela_Lista_Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Lista_Produtos));
            this.LvProd = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estampa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estoque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Img1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Img2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PbProdImg2 = new System.Windows.Forms.PictureBox();
            this.PbProdImg1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtListImg2 = new System.Windows.Forms.Button();
            this.BtCadProdImgAdd2 = new System.Windows.Forms.Button();
            this.BtListImg1 = new System.Windows.Forms.Button();
            this.BtListSalvar = new System.Windows.Forms.Button();
            this.BtListDel = new System.Windows.Forms.Button();
            this.LbListProdTam = new System.Windows.Forms.Label();
            this.LbListProdCor = new System.Windows.Forms.Label();
            this.CbListProdTam = new System.Windows.Forms.ComboBox();
            this.CbListProdCor = new System.Windows.Forms.ComboBox();
            this.LbListProdQtd = new System.Windows.Forms.Label();
            this.LblistProdPreco = new System.Windows.Forms.Label();
            this.TbListProdPreco = new System.Windows.Forms.MaskedTextBox();
            this.LbListProdEstampa = new System.Windows.Forms.Label();
            this.LbListProdMarca = new System.Windows.Forms.Label();
            this.TbListProdQtd = new System.Windows.Forms.TextBox();
            this.TbListProdEstampa = new System.Windows.Forms.TextBox();
            this.TbListProdMarca = new System.Windows.Forms.TextBox();
            this.LbUsu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbProdImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbProdImg1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvProd
            // 
            this.LvProd.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.LvProd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Marca,
            this.Estampa,
            this.Preco,
            this.Cor,
            this.Tamanho,
            this.Estoque,
            this.Img1,
            this.Img2});
            this.LvProd.HideSelection = false;
            this.LvProd.HotTracking = true;
            this.LvProd.HoverSelection = true;
            this.LvProd.Location = new System.Drawing.Point(13, 121);
            this.LvProd.Name = "LvProd";
            this.LvProd.Size = new System.Drawing.Size(562, 237);
            this.LvProd.TabIndex = 0;
            this.LvProd.UseCompatibleStateImageBehavior = false;
            this.LvProd.View = System.Windows.Forms.View.Details;
            this.LvProd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvProd_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            this.Marca.Width = 110;
            // 
            // Estampa
            // 
            this.Estampa.Text = "Estampa";
            this.Estampa.Width = 110;
            // 
            // Preco
            // 
            this.Preco.Text = "Preço";
            this.Preco.Width = 80;
            // 
            // Cor
            // 
            this.Cor.DisplayIndex = 5;
            this.Cor.Text = "Cor";
            this.Cor.Width = 80;
            // 
            // Tamanho
            // 
            this.Tamanho.DisplayIndex = 4;
            this.Tamanho.Text = "Tamanho";
            this.Tamanho.Width = 90;
            // 
            // Estoque
            // 
            this.Estoque.Text = "Estoque";
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
            // PbProdImg2
            // 
            this.PbProdImg2.Location = new System.Drawing.Point(592, 221);
            this.PbProdImg2.Name = "PbProdImg2";
            this.PbProdImg2.Size = new System.Drawing.Size(166, 166);
            this.PbProdImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbProdImg2.TabIndex = 1;
            this.PbProdImg2.TabStop = false;
            // 
            // PbProdImg1
            // 
            this.PbProdImg1.Location = new System.Drawing.Point(592, 16);
            this.PbProdImg1.Name = "PbProdImg1";
            this.PbProdImg1.Size = new System.Drawing.Size(166, 166);
            this.PbProdImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbProdImg1.TabIndex = 2;
            this.PbProdImg1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtListImg2);
            this.panel1.Controls.Add(this.BtCadProdImgAdd2);
            this.panel1.Controls.Add(this.BtListImg1);
            this.panel1.Controls.Add(this.BtListSalvar);
            this.panel1.Controls.Add(this.BtListDel);
            this.panel1.Controls.Add(this.LbListProdTam);
            this.panel1.Controls.Add(this.LbListProdCor);
            this.panel1.Controls.Add(this.CbListProdTam);
            this.panel1.Controls.Add(this.CbListProdCor);
            this.panel1.Controls.Add(this.LbListProdQtd);
            this.panel1.Controls.Add(this.LblistProdPreco);
            this.panel1.Controls.Add(this.TbListProdPreco);
            this.panel1.Controls.Add(this.LbListProdEstampa);
            this.panel1.Controls.Add(this.LbListProdMarca);
            this.panel1.Controls.Add(this.TbListProdQtd);
            this.panel1.Controls.Add(this.TbListProdEstampa);
            this.panel1.Controls.Add(this.TbListProdMarca);
            this.panel1.Controls.Add(this.LbUsu);
            this.panel1.Controls.Add(this.PbProdImg2);
            this.panel1.Controls.Add(this.PbProdImg1);
            this.panel1.Controls.Add(this.LvProd);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 3;
            // 
            // BtListImg2
            // 
            this.BtListImg2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtListImg2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtListImg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtListImg2.Location = new System.Drawing.Point(659, 393);
            this.BtListImg2.Name = "BtListImg2";
            this.BtListImg2.Size = new System.Drawing.Size(99, 23);
            this.BtListImg2.TabIndex = 27;
            this.BtListImg2.Text = "Alterar Imagem 2";
            this.BtListImg2.UseVisualStyleBackColor = false;
            this.BtListImg2.Click += new System.EventHandler(this.BtListImg2_Click);
            // 
            // BtCadProdImgAdd2
            // 
            this.BtCadProdImgAdd2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtCadProdImgAdd2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtCadProdImgAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCadProdImgAdd2.Location = new System.Drawing.Point(987, 188);
            this.BtCadProdImgAdd2.Name = "BtCadProdImgAdd2";
            this.BtCadProdImgAdd2.Size = new System.Drawing.Size(99, 23);
            this.BtCadProdImgAdd2.TabIndex = 26;
            this.BtCadProdImgAdd2.Text = "Inserir Imagem";
            this.BtCadProdImgAdd2.UseVisualStyleBackColor = false;
            // 
            // BtListImg1
            // 
            this.BtListImg1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtListImg1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtListImg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtListImg1.Location = new System.Drawing.Point(659, 188);
            this.BtListImg1.Name = "BtListImg1";
            this.BtListImg1.Size = new System.Drawing.Size(99, 23);
            this.BtListImg1.TabIndex = 25;
            this.BtListImg1.Text = "Alterar Imagem 1";
            this.BtListImg1.UseVisualStyleBackColor = false;
            this.BtListImg1.Click += new System.EventHandler(this.BtListImg1_Click);
            // 
            // BtListSalvar
            // 
            this.BtListSalvar.BackColor = System.Drawing.Color.White;
            this.BtListSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtListSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtListSalvar.Location = new System.Drawing.Point(357, 364);
            this.BtListSalvar.Name = "BtListSalvar";
            this.BtListSalvar.Size = new System.Drawing.Size(106, 23);
            this.BtListSalvar.TabIndex = 20;
            this.BtListSalvar.Text = "Salvar";
            this.BtListSalvar.UseVisualStyleBackColor = false;
            this.BtListSalvar.Click += new System.EventHandler(this.BtListSalvar_Click);
            // 
            // BtListDel
            // 
            this.BtListDel.BackColor = System.Drawing.Color.Gainsboro;
            this.BtListDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtListDel.Location = new System.Drawing.Point(469, 364);
            this.BtListDel.Name = "BtListDel";
            this.BtListDel.Size = new System.Drawing.Size(106, 23);
            this.BtListDel.TabIndex = 19;
            this.BtListDel.TabStop = false;
            this.BtListDel.Text = "Deletar";
            this.BtListDel.UseVisualStyleBackColor = false;
            this.BtListDel.Click += new System.EventHandler(this.BtListDel_Click);
            // 
            // LbListProdTam
            // 
            this.LbListProdTam.AutoSize = true;
            this.LbListProdTam.Location = new System.Drawing.Point(430, 67);
            this.LbListProdTam.Name = "LbListProdTam";
            this.LbListProdTam.Size = new System.Drawing.Size(52, 13);
            this.LbListProdTam.TabIndex = 18;
            this.LbListProdTam.Text = "Tamanho";
            // 
            // LbListProdCor
            // 
            this.LbListProdCor.AutoSize = true;
            this.LbListProdCor.Location = new System.Drawing.Point(219, 66);
            this.LbListProdCor.Name = "LbListProdCor";
            this.LbListProdCor.Size = new System.Drawing.Size(23, 13);
            this.LbListProdCor.TabIndex = 17;
            this.LbListProdCor.Text = "Cor";
            // 
            // CbListProdTam
            // 
            this.CbListProdTam.FormattingEnabled = true;
            this.CbListProdTam.Items.AddRange(new object[] {
            "Baby Look",
            "Pequeno",
            "Médio",
            "Grande",
            "Extra Grande"});
            this.CbListProdTam.Location = new System.Drawing.Point(433, 83);
            this.CbListProdTam.Name = "CbListProdTam";
            this.CbListProdTam.Size = new System.Drawing.Size(142, 21);
            this.CbListProdTam.TabIndex = 16;
            // 
            // CbListProdCor
            // 
            this.CbListProdCor.FormattingEnabled = true;
            this.CbListProdCor.Items.AddRange(new object[] {
            "Branco",
            "Preto",
            "Cinza",
            "Azul",
            "Rosa"});
            this.CbListProdCor.Location = new System.Drawing.Point(222, 81);
            this.CbListProdCor.Name = "CbListProdCor";
            this.CbListProdCor.Size = new System.Drawing.Size(142, 21);
            this.CbListProdCor.TabIndex = 15;
            // 
            // LbListProdQtd
            // 
            this.LbListProdQtd.AutoSize = true;
            this.LbListProdQtd.Location = new System.Drawing.Point(430, 17);
            this.LbListProdQtd.Name = "LbListProdQtd";
            this.LbListProdQtd.Size = new System.Drawing.Size(46, 13);
            this.LbListProdQtd.TabIndex = 14;
            this.LbListProdQtd.Text = "Estoque";
            // 
            // LblistProdPreco
            // 
            this.LblistProdPreco.AutoSize = true;
            this.LblistProdPreco.Location = new System.Drawing.Point(12, 67);
            this.LblistProdPreco.Name = "LblistProdPreco";
            this.LblistProdPreco.Size = new System.Drawing.Size(35, 13);
            this.LblistProdPreco.TabIndex = 13;
            this.LblistProdPreco.Text = "Preço";
            // 
            // TbListProdPreco
            // 
            this.TbListProdPreco.Location = new System.Drawing.Point(15, 82);
            this.TbListProdPreco.Name = "TbListProdPreco";
            this.TbListProdPreco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TbListProdPreco.Size = new System.Drawing.Size(140, 20);
            this.TbListProdPreco.TabIndex = 12;
            this.TbListProdPreco.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // LbListProdEstampa
            // 
            this.LbListProdEstampa.AutoSize = true;
            this.LbListProdEstampa.Location = new System.Drawing.Point(219, 16);
            this.LbListProdEstampa.Name = "LbListProdEstampa";
            this.LbListProdEstampa.Size = new System.Drawing.Size(48, 13);
            this.LbListProdEstampa.TabIndex = 11;
            this.LbListProdEstampa.Text = "Estampa";
            // 
            // LbListProdMarca
            // 
            this.LbListProdMarca.AutoSize = true;
            this.LbListProdMarca.Location = new System.Drawing.Point(10, 17);
            this.LbListProdMarca.Name = "LbListProdMarca";
            this.LbListProdMarca.Size = new System.Drawing.Size(37, 13);
            this.LbListProdMarca.TabIndex = 10;
            this.LbListProdMarca.Text = "Marca";
            // 
            // TbListProdQtd
            // 
            this.TbListProdQtd.Location = new System.Drawing.Point(433, 33);
            this.TbListProdQtd.Name = "TbListProdQtd";
            this.TbListProdQtd.Size = new System.Drawing.Size(142, 20);
            this.TbListProdQtd.TabIndex = 8;
            // 
            // TbListProdEstampa
            // 
            this.TbListProdEstampa.Location = new System.Drawing.Point(222, 32);
            this.TbListProdEstampa.Name = "TbListProdEstampa";
            this.TbListProdEstampa.Size = new System.Drawing.Size(142, 20);
            this.TbListProdEstampa.TabIndex = 5;
            // 
            // TbListProdMarca
            // 
            this.TbListProdMarca.Location = new System.Drawing.Point(13, 33);
            this.TbListProdMarca.Name = "TbListProdMarca";
            this.TbListProdMarca.Size = new System.Drawing.Size(142, 20);
            this.TbListProdMarca.TabIndex = 4;
            // 
            // LbUsu
            // 
            this.LbUsu.AutoSize = true;
            this.LbUsu.BackColor = System.Drawing.Color.Transparent;
            this.LbUsu.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsu.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.LbUsu.Location = new System.Drawing.Point(0, 392);
            this.LbUsu.Name = "LbUsu";
            this.LbUsu.Size = new System.Drawing.Size(191, 34);
            this.LbUsu.TabIndex = 3;
            this.LbUsu.Text = "ESTAMPARIA";
            // 
            // Tela_Lista_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Tela_Lista_Produtos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Lista_Produtos";
            this.Load += new System.EventHandler(this.Tela_Lista_Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbProdImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbProdImg1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvProd;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader Estampa;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.ColumnHeader Tamanho;
        private System.Windows.Forms.ColumnHeader Cor;
        private System.Windows.Forms.ColumnHeader Estoque;
        private System.Windows.Forms.PictureBox PbProdImg2;
        private System.Windows.Forms.PictureBox PbProdImg1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbListProdQtd;
        private System.Windows.Forms.Label LblistProdPreco;
        private System.Windows.Forms.MaskedTextBox TbListProdPreco;
        private System.Windows.Forms.Label LbListProdEstampa;
        private System.Windows.Forms.Label LbListProdMarca;
        private System.Windows.Forms.TextBox TbListProdQtd;
        private System.Windows.Forms.TextBox TbListProdEstampa;
        private System.Windows.Forms.TextBox TbListProdMarca;
        private System.Windows.Forms.Label LbUsu;
        private System.Windows.Forms.ComboBox CbListProdTam;
        private System.Windows.Forms.ComboBox CbListProdCor;
        private System.Windows.Forms.Label LbListProdCor;
        private System.Windows.Forms.Label LbListProdTam;
        private System.Windows.Forms.Button BtListSalvar;
        private System.Windows.Forms.Button BtListDel;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button BtListImg2;
        private System.Windows.Forms.Button BtCadProdImgAdd2;
        private System.Windows.Forms.Button BtListImg1;
        private System.Windows.Forms.ColumnHeader Img1;
        private System.Windows.Forms.ColumnHeader Img2;
    }
}