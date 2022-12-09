namespace Estamparia_LP2A4.Telas
{
    partial class Tela_Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Cadastro));
            this.LbEstampaCad = new System.Windows.Forms.Label();
            this.TbxNome = new System.Windows.Forms.TextBox();
            this.LbNome = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.LbTelefone = new System.Windows.Forms.Label();
            this.TbxTel = new System.Windows.Forms.MaskedTextBox();
            this.LbCPF = new System.Windows.Forms.Label();
            this.TbxCPF = new System.Windows.Forms.MaskedTextBox();
            this.LbSenha = new System.Windows.Forms.Label();
            this.TbxSenha = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelCliente = new System.Windows.Forms.Panel();
            this.LbCliente = new System.Windows.Forms.Label();
            this.LbLoginPerfil = new System.Windows.Forms.Label();
            this.CbCadastro = new System.Windows.Forms.ComboBox();
            this.BtCadSalvar = new System.Windows.Forms.Button();
            this.BtCadLimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PanelCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbEstampaCad
            // 
            this.LbEstampaCad.AutoSize = true;
            this.LbEstampaCad.BackColor = System.Drawing.SystemColors.Control;
            this.LbEstampaCad.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEstampaCad.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LbEstampaCad.Location = new System.Drawing.Point(18, 24);
            this.LbEstampaCad.Name = "LbEstampaCad";
            this.LbEstampaCad.Size = new System.Drawing.Size(247, 44);
            this.LbEstampaCad.TabIndex = 0;
            this.LbEstampaCad.Text = "ESTAMPARIA";
            // 
            // TbxNome
            // 
            this.TbxNome.Location = new System.Drawing.Point(26, 92);
            this.TbxNome.Name = "TbxNome";
            this.TbxNome.Size = new System.Drawing.Size(228, 20);
            this.TbxNome.TabIndex = 1;
            // 
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.BackColor = System.Drawing.SystemColors.Control;
            this.LbNome.Location = new System.Drawing.Point(23, 76);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(82, 13);
            this.LbNome.TabIndex = 2;
            this.LbNome.Text = "Nome Completo";
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.BackColor = System.Drawing.SystemColors.Control;
            this.LbEmail.Location = new System.Drawing.Point(23, 131);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(35, 13);
            this.LbEmail.TabIndex = 3;
            this.LbEmail.Text = "E-mail";
            // 
            // TbxEmail
            // 
            this.TbxEmail.Location = new System.Drawing.Point(26, 147);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(228, 20);
            this.TbxEmail.TabIndex = 4;
            // 
            // LbTelefone
            // 
            this.LbTelefone.AutoSize = true;
            this.LbTelefone.BackColor = System.Drawing.SystemColors.Control;
            this.LbTelefone.Location = new System.Drawing.Point(23, 186);
            this.LbTelefone.Name = "LbTelefone";
            this.LbTelefone.Size = new System.Drawing.Size(49, 13);
            this.LbTelefone.TabIndex = 6;
            this.LbTelefone.Text = "Telefone";
            // 
            // TbxTel
            // 
            this.TbxTel.Location = new System.Drawing.Point(26, 202);
            this.TbxTel.Mask = "(00) 00000-0000";
            this.TbxTel.Name = "TbxTel";
            this.TbxTel.Size = new System.Drawing.Size(228, 20);
            this.TbxTel.TabIndex = 7;
            this.TbxTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // LbCPF
            // 
            this.LbCPF.AutoSize = true;
            this.LbCPF.BackColor = System.Drawing.SystemColors.Control;
            this.LbCPF.Location = new System.Drawing.Point(23, 240);
            this.LbCPF.Name = "LbCPF";
            this.LbCPF.Size = new System.Drawing.Size(27, 13);
            this.LbCPF.TabIndex = 8;
            this.LbCPF.Text = "CPF";
            // 
            // TbxCPF
            // 
            this.TbxCPF.Location = new System.Drawing.Point(26, 256);
            this.TbxCPF.Mask = "000,000,000-00";
            this.TbxCPF.Name = "TbxCPF";
            this.TbxCPF.Size = new System.Drawing.Size(228, 20);
            this.TbxCPF.TabIndex = 9;
            this.TbxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // LbSenha
            // 
            this.LbSenha.AutoSize = true;
            this.LbSenha.BackColor = System.Drawing.SystemColors.Control;
            this.LbSenha.Location = new System.Drawing.Point(23, 298);
            this.LbSenha.Name = "LbSenha";
            this.LbSenha.Size = new System.Drawing.Size(38, 13);
            this.LbSenha.TabIndex = 10;
            this.LbSenha.Text = "Senha";
            // 
            // TbxSenha
            // 
            this.TbxSenha.Location = new System.Drawing.Point(26, 314);
            this.TbxSenha.Name = "TbxSenha";
            this.TbxSenha.PasswordChar = '*';
            this.TbxSenha.Size = new System.Drawing.Size(228, 20);
            this.TbxSenha.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.PanelCliente);
            this.panel1.Controls.Add(this.LbLoginPerfil);
            this.panel1.Controls.Add(this.CbCadastro);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 385);
            this.panel1.TabIndex = 12;
            // 
            // PanelCliente
            // 
            this.PanelCliente.BackColor = System.Drawing.SystemColors.Window;
            this.PanelCliente.Controls.Add(this.LbCliente);
            this.PanelCliente.Location = new System.Drawing.Point(121, 351);
            this.PanelCliente.Name = "PanelCliente";
            this.PanelCliente.Size = new System.Drawing.Size(121, 21);
            this.PanelCliente.TabIndex = 15;
            // 
            // LbCliente
            // 
            this.LbCliente.AutoSize = true;
            this.LbCliente.Location = new System.Drawing.Point(3, 4);
            this.LbCliente.Name = "LbCliente";
            this.LbCliente.Size = new System.Drawing.Size(39, 13);
            this.LbCliente.TabIndex = 15;
            this.LbCliente.Text = "Cliente";
            // 
            // LbLoginPerfil
            // 
            this.LbLoginPerfil.AutoSize = true;
            this.LbLoginPerfil.Location = new System.Drawing.Point(85, 354);
            this.LbLoginPerfil.Name = "LbLoginPerfil";
            this.LbLoginPerfil.Size = new System.Drawing.Size(30, 13);
            this.LbLoginPerfil.TabIndex = 16;
            this.LbLoginPerfil.Text = "Perfil";
            // 
            // CbCadastro
            // 
            this.CbCadastro.FormattingEnabled = true;
            this.CbCadastro.Items.AddRange(new object[] {
            "Administrador",
            "Cliente"});
            this.CbCadastro.Location = new System.Drawing.Point(121, 351);
            this.CbCadastro.Name = "CbCadastro";
            this.CbCadastro.Size = new System.Drawing.Size(121, 21);
            this.CbCadastro.TabIndex = 15;
            // 
            // BtCadSalvar
            // 
            this.BtCadSalvar.BackColor = System.Drawing.Color.White;
            this.BtCadSalvar.Location = new System.Drawing.Point(12, 430);
            this.BtCadSalvar.Name = "BtCadSalvar";
            this.BtCadSalvar.Size = new System.Drawing.Size(110, 23);
            this.BtCadSalvar.TabIndex = 13;
            this.BtCadSalvar.Text = "Salvar";
            this.BtCadSalvar.UseVisualStyleBackColor = false;
            this.BtCadSalvar.Click += new System.EventHandler(this.BtCadSalvar_Click);
            // 
            // BtCadLimpar
            // 
            this.BtCadLimpar.Location = new System.Drawing.Point(155, 430);
            this.BtCadLimpar.Name = "BtCadLimpar";
            this.BtCadLimpar.Size = new System.Drawing.Size(110, 23);
            this.BtCadLimpar.TabIndex = 14;
            this.BtCadLimpar.Text = "Limpar";
            this.BtCadLimpar.UseVisualStyleBackColor = true;
            this.BtCadLimpar.Click += new System.EventHandler(this.BtCadLimpar_Click);
            // 
            // Tela_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 485);
            this.Controls.Add(this.BtCadLimpar);
            this.Controls.Add(this.BtCadSalvar);
            this.Controls.Add(this.TbxSenha);
            this.Controls.Add(this.LbSenha);
            this.Controls.Add(this.TbxCPF);
            this.Controls.Add(this.LbCPF);
            this.Controls.Add(this.TbxTel);
            this.Controls.Add(this.LbTelefone);
            this.Controls.Add(this.TbxEmail);
            this.Controls.Add(this.LbEmail);
            this.Controls.Add(this.LbNome);
            this.Controls.Add(this.TbxNome);
            this.Controls.Add(this.LbEstampaCad);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Tela_Cadastro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelCliente.ResumeLayout(false);
            this.PanelCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbEstampaCad;
        private System.Windows.Forms.TextBox TbxNome;
        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.TextBox TbxEmail;
        private System.Windows.Forms.Label LbTelefone;
        private System.Windows.Forms.MaskedTextBox TbxTel;
        private System.Windows.Forms.Label LbCPF;
        private System.Windows.Forms.MaskedTextBox TbxCPF;
        private System.Windows.Forms.Label LbSenha;
        private System.Windows.Forms.MaskedTextBox TbxSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtCadSalvar;
        private System.Windows.Forms.Button BtCadLimpar;
        private System.Windows.Forms.Label LbLoginPerfil;
        private System.Windows.Forms.ComboBox CbCadastro;
        private System.Windows.Forms.Panel PanelCliente;
        private System.Windows.Forms.Label LbCliente;
    }
}