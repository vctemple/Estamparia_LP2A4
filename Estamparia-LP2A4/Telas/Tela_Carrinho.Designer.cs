namespace Estamparia_LP2A4.Telas
{
    partial class Tela_Carrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Carrinho));
            this.PbCarrIma2 = new System.Windows.Forms.PictureBox();
            this.PbCarrIma1 = new System.Windows.Forms.PictureBox();
            this.LvCarr = new System.Windows.Forms.ListView();
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estampa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Img1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Img2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtCarBuy = new System.Windows.Forms.Button();
            this.BtCarrDel = new System.Windows.Forms.Button();
            this.PCarrTotal = new System.Windows.Forms.Panel();
            this.LbTotalText = new System.Windows.Forms.Label();
            this.LbTotal = new System.Windows.Forms.Label();
            this.LbUsu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarrIma2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarrIma1)).BeginInit();
            this.PCarrTotal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbCarrIma2
            // 
            this.PbCarrIma2.Location = new System.Drawing.Point(171, 12);
            this.PbCarrIma2.Name = "PbCarrIma2";
            this.PbCarrIma2.Size = new System.Drawing.Size(140, 140);
            this.PbCarrIma2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCarrIma2.TabIndex = 7;
            this.PbCarrIma2.TabStop = false;
            // 
            // PbCarrIma1
            // 
            this.PbCarrIma1.Location = new System.Drawing.Point(12, 12);
            this.PbCarrIma1.Name = "PbCarrIma1";
            this.PbCarrIma1.Size = new System.Drawing.Size(140, 140);
            this.PbCarrIma1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCarrIma1.TabIndex = 6;
            this.PbCarrIma1.TabStop = false;
            // 
            // LvCarr
            // 
            this.LvCarr.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.LvCarr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Marca,
            this.ID,
            this.Estampa,
            this.Cor,
            this.Tamanho,
            this.Preco,
            this.Qtd,
            this.Img1,
            this.Img2});
            this.LvCarr.HideSelection = false;
            this.LvCarr.HotTracking = true;
            this.LvCarr.HoverSelection = true;
            this.LvCarr.Location = new System.Drawing.Point(12, 13);
            this.LvCarr.Name = "LvCarr";
            this.LvCarr.Size = new System.Drawing.Size(533, 169);
            this.LvCarr.TabIndex = 5;
            this.LvCarr.UseCompatibleStateImageBehavior = false;
            this.LvCarr.View = System.Windows.Forms.View.Details;
            this.LvCarr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvCliProd_MouseClick);
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            this.Marca.Width = 100;
            // 
            // ID
            // 
            this.ID.Width = 0;
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
            this.Cor.Text = "Cor";
            this.Cor.Width = 90;
            // 
            // Tamanho
            // 
            this.Tamanho.Text = "Tamanho";
            this.Tamanho.Width = 90;
            // 
            // Qtd
            // 
            this.Qtd.Text = "Qtd";
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
            // BtCarBuy
            // 
            this.BtCarBuy.BackColor = System.Drawing.Color.White;
            this.BtCarBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtCarBuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtCarBuy.Location = new System.Drawing.Point(145, 188);
            this.BtCarBuy.Name = "BtCarBuy";
            this.BtCarBuy.Size = new System.Drawing.Size(106, 23);
            this.BtCarBuy.TabIndex = 22;
            this.BtCarBuy.Text = "Realizar compra";
            this.BtCarBuy.UseVisualStyleBackColor = false;
            this.BtCarBuy.Click += new System.EventHandler(this.BtCarBuy_Click);
            // 
            // BtCarrDel
            // 
            this.BtCarrDel.BackColor = System.Drawing.Color.Gainsboro;
            this.BtCarrDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtCarrDel.Location = new System.Drawing.Point(12, 188);
            this.BtCarrDel.Name = "BtCarrDel";
            this.BtCarrDel.Size = new System.Drawing.Size(127, 23);
            this.BtCarrDel.TabIndex = 21;
            this.BtCarrDel.TabStop = false;
            this.BtCarrDel.Text = "Deletar item do carrinho";
            this.BtCarrDel.UseVisualStyleBackColor = false;
            this.BtCarrDel.Click += new System.EventHandler(this.BtListDel_Click);
            // 
            // PCarrTotal
            // 
            this.PCarrTotal.BackColor = System.Drawing.SystemColors.Window;
            this.PCarrTotal.Controls.Add(this.LbTotalText);
            this.PCarrTotal.Location = new System.Drawing.Point(478, 188);
            this.PCarrTotal.Name = "PCarrTotal";
            this.PCarrTotal.Size = new System.Drawing.Size(67, 20);
            this.PCarrTotal.TabIndex = 24;
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
            this.LbTotal.Location = new System.Drawing.Point(299, 191);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(173, 13);
            this.LbTotal.TabIndex = 23;
            this.LbTotal.Text = "Total do carrinho de compras";
            // 
            // LbUsu
            // 
            this.LbUsu.AutoSize = true;
            this.LbUsu.BackColor = System.Drawing.Color.Transparent;
            this.LbUsu.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsu.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.LbUsu.Location = new System.Drawing.Point(392, 12);
            this.LbUsu.Name = "LbUsu";
            this.LbUsu.Size = new System.Drawing.Size(191, 34);
            this.LbUsu.TabIndex = 25;
            this.LbUsu.Text = "ESTAMPARIA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LvCarr);
            this.panel1.Controls.Add(this.PCarrTotal);
            this.panel1.Controls.Add(this.BtCarrDel);
            this.panel1.Controls.Add(this.LbTotal);
            this.panel1.Controls.Add(this.BtCarBuy);
            this.panel1.Location = new System.Drawing.Point(12, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 224);
            this.panel1.TabIndex = 26;
            // 
            // Tela_Carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(585, 399);
            this.Controls.Add(this.LbUsu);
            this.Controls.Add(this.PbCarrIma2);
            this.Controls.Add(this.PbCarrIma1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Tela_Carrinho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARRINHO DE COMPRAS";
            this.Load += new System.EventHandler(this.Tela_Carrinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbCarrIma2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarrIma1)).EndInit();
            this.PCarrTotal.ResumeLayout(false);
            this.PCarrTotal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbCarrIma2;
        private System.Windows.Forms.PictureBox PbCarrIma1;
        private System.Windows.Forms.ListView LvCarr;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Estampa;
        private System.Windows.Forms.ColumnHeader Cor;
        private System.Windows.Forms.ColumnHeader Tamanho;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.ColumnHeader Qtd;
        private System.Windows.Forms.ColumnHeader Img1;
        private System.Windows.Forms.ColumnHeader Img2;
        private System.Windows.Forms.Button BtCarBuy;
        private System.Windows.Forms.Button BtCarrDel;
        private System.Windows.Forms.Panel PCarrTotal;
        private System.Windows.Forms.Label LbTotalText;
        private System.Windows.Forms.Label LbTotal;
        private System.Windows.Forms.Label LbUsu;
        private System.Windows.Forms.Panel panel1;
    }
}