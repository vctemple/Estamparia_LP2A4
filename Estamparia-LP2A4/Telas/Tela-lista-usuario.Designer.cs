namespace Estamparia_LP2A4.Telas
{
    partial class Tela_lista_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_lista_usuario));
            this.LvUserList = new System.Windows.Forms.ListView();
            this.ChListId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClPerfil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LbUsu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbListPerfil = new System.Windows.Forms.Label();
            this.CbListPerfil = new System.Windows.Forms.ComboBox();
            this.BtListEditsenha = new System.Windows.Forms.Button();
            this.LbListSenha = new System.Windows.Forms.Label();
            this.TbListSenha = new System.Windows.Forms.MaskedTextBox();
            this.BtListSalvar = new System.Windows.Forms.Button();
            this.BtListDel = new System.Windows.Forms.Button();
            this.LbListTel = new System.Windows.Forms.Label();
            this.LbListCpf = new System.Windows.Forms.Label();
            this.MtbListTel = new System.Windows.Forms.MaskedTextBox();
            this.MtbListCpf = new System.Windows.Forms.MaskedTextBox();
            this.LbListEmail = new System.Windows.Forms.Label();
            this.LbListNome = new System.Windows.Forms.Label();
            this.TbListEmail = new System.Windows.Forms.TextBox();
            this.TbListNome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvUserList
            // 
            this.LvUserList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.LvUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChListId,
            this.ClNome,
            this.CLCpf,
            this.ClTel,
            this.ClEmail,
            this.ClPerfil});
            this.LvUserList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LvUserList.HideSelection = false;
            this.LvUserList.HotTracking = true;
            this.LvUserList.HoverSelection = true;
            this.LvUserList.Location = new System.Drawing.Point(22, 209);
            this.LvUserList.Name = "LvUserList";
            this.LvUserList.Size = new System.Drawing.Size(753, 234);
            this.LvUserList.TabIndex = 0;
            this.LvUserList.UseCompatibleStateImageBehavior = false;
            this.LvUserList.View = System.Windows.Forms.View.Details;
            this.LvUserList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvUserList_MouseClick);
            // 
            // ChListId
            // 
            this.ChListId.Text = "Id";
            // 
            // ClNome
            // 
            this.ClNome.Text = "Nome";
            this.ClNome.Width = 170;
            // 
            // CLCpf
            // 
            this.CLCpf.Text = "CPF";
            this.CLCpf.Width = 140;
            // 
            // ClTel
            // 
            this.ClTel.Text = "Telefone";
            this.ClTel.Width = 140;
            // 
            // ClEmail
            // 
            this.ClEmail.Text = "E-mail";
            this.ClEmail.Width = 170;
            // 
            // ClPerfil
            // 
            this.ClPerfil.Text = "Perfil";
            this.ClPerfil.Width = 70;
            // 
            // LbUsu
            // 
            this.LbUsu.AutoSize = true;
            this.LbUsu.BackColor = System.Drawing.Color.Transparent;
            this.LbUsu.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsu.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.LbUsu.Location = new System.Drawing.Point(561, 0);
            this.LbUsu.Name = "LbUsu";
            this.LbUsu.Size = new System.Drawing.Size(191, 34);
            this.LbUsu.TabIndex = 1;
            this.LbUsu.Text = "ESTAMPARIA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LbListPerfil);
            this.panel1.Controls.Add(this.CbListPerfil);
            this.panel1.Controls.Add(this.BtListEditsenha);
            this.panel1.Controls.Add(this.LbListSenha);
            this.panel1.Controls.Add(this.TbListSenha);
            this.panel1.Controls.Add(this.LbUsu);
            this.panel1.Controls.Add(this.BtListSalvar);
            this.panel1.Controls.Add(this.BtListDel);
            this.panel1.Controls.Add(this.LbListTel);
            this.panel1.Controls.Add(this.LbListCpf);
            this.panel1.Controls.Add(this.MtbListTel);
            this.panel1.Controls.Add(this.MtbListCpf);
            this.panel1.Controls.Add(this.LbListEmail);
            this.panel1.Controls.Add(this.LbListNome);
            this.panel1.Controls.Add(this.TbListEmail);
            this.panel1.Controls.Add(this.TbListNome);
            this.panel1.Location = new System.Drawing.Point(22, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 182);
            this.panel1.TabIndex = 2;
            // 
            // LbListPerfil
            // 
            this.LbListPerfil.AutoSize = true;
            this.LbListPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbListPerfil.Location = new System.Drawing.Point(574, 75);
            this.LbListPerfil.Name = "LbListPerfil";
            this.LbListPerfil.Size = new System.Drawing.Size(30, 13);
            this.LbListPerfil.TabIndex = 16;
            this.LbListPerfil.Text = "Perfil";
            // 
            // CbListPerfil
            // 
            this.CbListPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbListPerfil.FormattingEnabled = true;
            this.CbListPerfil.Items.AddRange(new object[] {
            "Admin",
            "Cliente"});
            this.CbListPerfil.Location = new System.Drawing.Point(577, 91);
            this.CbListPerfil.Name = "CbListPerfil";
            this.CbListPerfil.Size = new System.Drawing.Size(121, 21);
            this.CbListPerfil.TabIndex = 15;
            // 
            // BtListEditsenha
            // 
            this.BtListEditsenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtListEditsenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtListEditsenha.Location = new System.Drawing.Point(135, 145);
            this.BtListEditsenha.Name = "BtListEditsenha";
            this.BtListEditsenha.Size = new System.Drawing.Size(106, 23);
            this.BtListEditsenha.TabIndex = 14;
            this.BtListEditsenha.Text = "Alterar senha";
            this.BtListEditsenha.UseVisualStyleBackColor = false;
            this.BtListEditsenha.Click += new System.EventHandler(this.BtListEditsenha_Click);
            // 
            // LbListSenha
            // 
            this.LbListSenha.AutoSize = true;
            this.LbListSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbListSenha.Location = new System.Drawing.Point(11, 129);
            this.LbListSenha.Name = "LbListSenha";
            this.LbListSenha.Size = new System.Drawing.Size(38, 13);
            this.LbListSenha.TabIndex = 13;
            this.LbListSenha.Text = "Senha";
            this.LbListSenha.Visible = false;
            // 
            // TbListSenha
            // 
            this.TbListSenha.Location = new System.Drawing.Point(14, 145);
            this.TbListSenha.Name = "TbListSenha";
            this.TbListSenha.PasswordChar = '*';
            this.TbListSenha.Size = new System.Drawing.Size(227, 20);
            this.TbListSenha.TabIndex = 12;
            this.TbListSenha.Visible = false;
            // 
            // BtListSalvar
            // 
            this.BtListSalvar.BackColor = System.Drawing.Color.White;
            this.BtListSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtListSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtListSalvar.Location = new System.Drawing.Point(415, 145);
            this.BtListSalvar.Name = "BtListSalvar";
            this.BtListSalvar.Size = new System.Drawing.Size(106, 23);
            this.BtListSalvar.TabIndex = 11;
            this.BtListSalvar.Text = "Salvar";
            this.BtListSalvar.UseVisualStyleBackColor = false;
            this.BtListSalvar.Click += new System.EventHandler(this.BtListSalvar_Click);
            // 
            // BtListDel
            // 
            this.BtListDel.BackColor = System.Drawing.Color.Gainsboro;
            this.BtListDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtListDel.Location = new System.Drawing.Point(294, 145);
            this.BtListDel.Name = "BtListDel";
            this.BtListDel.Size = new System.Drawing.Size(106, 23);
            this.BtListDel.TabIndex = 10;
            this.BtListDel.TabStop = false;
            this.BtListDel.Text = "Deletar";
            this.BtListDel.UseVisualStyleBackColor = false;
            this.BtListDel.Click += new System.EventHandler(this.BtListDel_Click);
            // 
            // LbListTel
            // 
            this.LbListTel.AutoSize = true;
            this.LbListTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbListTel.Location = new System.Drawing.Point(291, 75);
            this.LbListTel.Name = "LbListTel";
            this.LbListTel.Size = new System.Drawing.Size(49, 13);
            this.LbListTel.TabIndex = 9;
            this.LbListTel.Text = "Telefone";
            // 
            // LbListCpf
            // 
            this.LbListCpf.AutoSize = true;
            this.LbListCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbListCpf.Location = new System.Drawing.Point(14, 75);
            this.LbListCpf.Name = "LbListCpf";
            this.LbListCpf.Size = new System.Drawing.Size(27, 13);
            this.LbListCpf.TabIndex = 8;
            this.LbListCpf.Text = "CPF";
            // 
            // MtbListTel
            // 
            this.MtbListTel.Location = new System.Drawing.Point(294, 91);
            this.MtbListTel.Mask = "(00) 00000-0000";
            this.MtbListTel.Name = "MtbListTel";
            this.MtbListTel.Size = new System.Drawing.Size(227, 20);
            this.MtbListTel.TabIndex = 7;
            this.MtbListTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // MtbListCpf
            // 
            this.MtbListCpf.Location = new System.Drawing.Point(14, 91);
            this.MtbListCpf.Mask = "000,000,000-00";
            this.MtbListCpf.Name = "MtbListCpf";
            this.MtbListCpf.Size = new System.Drawing.Size(227, 20);
            this.MtbListCpf.TabIndex = 6;
            this.MtbListCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // LbListEmail
            // 
            this.LbListEmail.AutoSize = true;
            this.LbListEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbListEmail.Location = new System.Drawing.Point(291, 18);
            this.LbListEmail.Name = "LbListEmail";
            this.LbListEmail.Size = new System.Drawing.Size(35, 13);
            this.LbListEmail.TabIndex = 5;
            this.LbListEmail.Text = "E-mail";
            // 
            // LbListNome
            // 
            this.LbListNome.AutoSize = true;
            this.LbListNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbListNome.Location = new System.Drawing.Point(14, 15);
            this.LbListNome.Name = "LbListNome";
            this.LbListNome.Size = new System.Drawing.Size(35, 13);
            this.LbListNome.TabIndex = 4;
            this.LbListNome.Text = "Nome";
            // 
            // TbListEmail
            // 
            this.TbListEmail.Location = new System.Drawing.Point(294, 34);
            this.TbListEmail.Name = "TbListEmail";
            this.TbListEmail.Size = new System.Drawing.Size(227, 20);
            this.TbListEmail.TabIndex = 3;
            // 
            // TbListNome
            // 
            this.TbListNome.Location = new System.Drawing.Point(14, 34);
            this.TbListNome.Name = "TbListNome";
            this.TbListNome.Size = new System.Drawing.Size(227, 20);
            this.TbListNome.TabIndex = 0;
            // 
            // Tela_lista_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(797, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LvUserList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Tela_lista_usuario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUÁRIOS";
            this.Load += new System.EventHandler(this.Tela_lista_usuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvUserList;
        private System.Windows.Forms.ColumnHeader ClNome;
        private System.Windows.Forms.ColumnHeader CLCpf;
        private System.Windows.Forms.ColumnHeader ClTel;
        private System.Windows.Forms.ColumnHeader ClEmail;
        private System.Windows.Forms.Label LbUsu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbListNome;
        private System.Windows.Forms.MaskedTextBox MtbListTel;
        private System.Windows.Forms.MaskedTextBox MtbListCpf;
        private System.Windows.Forms.Label LbListEmail;
        private System.Windows.Forms.Label LbListNome;
        private System.Windows.Forms.TextBox TbListEmail;
        private System.Windows.Forms.Label LbListCpf;
        private System.Windows.Forms.Button BtListSalvar;
        private System.Windows.Forms.Button BtListDel;
        private System.Windows.Forms.Label LbListTel;
        private System.Windows.Forms.Button BtListEditsenha;
        private System.Windows.Forms.Label LbListSenha;
        private System.Windows.Forms.MaskedTextBox TbListSenha;
        private System.Windows.Forms.ColumnHeader ChListId;
        private System.Windows.Forms.Label LbListPerfil;
        private System.Windows.Forms.ComboBox CbListPerfil;
        private System.Windows.Forms.ColumnHeader ClPerfil;
    }
}