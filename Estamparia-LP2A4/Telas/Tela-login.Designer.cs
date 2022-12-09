namespace Estamparia_LP2A4.Telas
{
    partial class Tela_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_login));
            this.LbEstamparialogin = new System.Windows.Forms.Label();
            this.Lbusername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtLogLimpar = new System.Windows.Forms.Button();
            this.TbLogSenha = new System.Windows.Forms.MaskedTextBox();
            this.LbSenhalogin = new System.Windows.Forms.Label();
            this.TbLogEmail = new System.Windows.Forms.TextBox();
            this.BtLogLogin = new System.Windows.Forms.Button();
            this.BtLogSair = new System.Windows.Forms.Button();
            this.LkCad = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbEstamparialogin
            // 
            this.LbEstamparialogin.AutoSize = true;
            this.LbEstamparialogin.BackColor = System.Drawing.SystemColors.Control;
            this.LbEstamparialogin.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEstamparialogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LbEstamparialogin.Location = new System.Drawing.Point(18, 44);
            this.LbEstamparialogin.Name = "LbEstamparialogin";
            this.LbEstamparialogin.Size = new System.Drawing.Size(247, 44);
            this.LbEstamparialogin.TabIndex = 1;
            this.LbEstamparialogin.Text = "ESTAMPARIA";
            // 
            // Lbusername
            // 
            this.Lbusername.AutoSize = true;
            this.Lbusername.Location = new System.Drawing.Point(14, 62);
            this.Lbusername.Name = "Lbusername";
            this.Lbusername.Size = new System.Drawing.Size(42, 13);
            this.Lbusername.TabIndex = 2;
            this.Lbusername.Text = "E-MAIL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.LkCad);
            this.panel1.Controls.Add(this.Lbusername);
            this.panel1.Controls.Add(this.BtLogLimpar);
            this.panel1.Controls.Add(this.TbLogSenha);
            this.panel1.Controls.Add(this.LbSenhalogin);
            this.panel1.Controls.Add(this.TbLogEmail);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 205);
            this.panel1.TabIndex = 3;
            // 
            // BtLogLimpar
            // 
            this.BtLogLimpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtLogLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtLogLimpar.Location = new System.Drawing.Point(17, 173);
            this.BtLogLimpar.Name = "BtLogLimpar";
            this.BtLogLimpar.Size = new System.Drawing.Size(93, 23);
            this.BtLogLimpar.TabIndex = 5;
            this.BtLogLimpar.Text = "Limpar";
            this.BtLogLimpar.UseVisualStyleBackColor = false;
            this.BtLogLimpar.Click += new System.EventHandler(this.BtLogLimpar_Click);
            // 
            // TbLogSenha
            // 
            this.TbLogSenha.Location = new System.Drawing.Point(17, 142);
            this.TbLogSenha.Name = "TbLogSenha";
            this.TbLogSenha.PasswordChar = '*';
            this.TbLogSenha.Size = new System.Drawing.Size(227, 20);
            this.TbLogSenha.TabIndex = 2;
            // 
            // LbSenhalogin
            // 
            this.LbSenhalogin.AutoSize = true;
            this.LbSenhalogin.Location = new System.Drawing.Point(14, 126);
            this.LbSenhalogin.Name = "LbSenhalogin";
            this.LbSenhalogin.Size = new System.Drawing.Size(44, 13);
            this.LbSenhalogin.TabIndex = 1;
            this.LbSenhalogin.Text = "SENHA";
            // 
            // TbLogEmail
            // 
            this.TbLogEmail.Location = new System.Drawing.Point(17, 78);
            this.TbLogEmail.Name = "TbLogEmail";
            this.TbLogEmail.Size = new System.Drawing.Size(227, 20);
            this.TbLogEmail.TabIndex = 0;
            // 
            // BtLogLogin
            // 
            this.BtLogLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtLogLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtLogLogin.Location = new System.Drawing.Point(12, 281);
            this.BtLogLogin.Name = "BtLogLogin";
            this.BtLogLogin.Size = new System.Drawing.Size(110, 23);
            this.BtLogLogin.TabIndex = 4;
            this.BtLogLogin.Text = "Login";
            this.BtLogLogin.UseVisualStyleBackColor = false;
            this.BtLogLogin.Click += new System.EventHandler(this.BtLogLogin_Click);
            // 
            // BtLogSair
            // 
            this.BtLogSair.BackColor = System.Drawing.Color.LightGray;
            this.BtLogSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtLogSair.Location = new System.Drawing.Point(169, 281);
            this.BtLogSair.Name = "BtLogSair";
            this.BtLogSair.Size = new System.Drawing.Size(110, 23);
            this.BtLogSair.TabIndex = 6;
            this.BtLogSair.Text = "Sair";
            this.BtLogSair.UseVisualStyleBackColor = false;
            this.BtLogSair.Click += new System.EventHandler(this.BtLogSair_Click);
            // 
            // LkCad
            // 
            this.LkCad.AutoSize = true;
            this.LkCad.BackColor = System.Drawing.Color.Transparent;
            this.LkCad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LkCad.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LkCad.Location = new System.Drawing.Point(155, 178);
            this.LkCad.Name = "LkCad";
            this.LkCad.Size = new System.Drawing.Size(89, 13);
            this.LkCad.TabIndex = 7;
            this.LkCad.TabStop = true;
            this.LkCad.Text = "Realizar cadastro";
            this.LkCad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkCad_LinkClicked);
            // 
            // Tela_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(291, 346);
            this.Controls.Add(this.BtLogSair);
            this.Controls.Add(this.BtLogLogin);
            this.Controls.Add(this.LbEstamparialogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Tela_login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbEstamparialogin;
        private System.Windows.Forms.Label Lbusername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbLogEmail;
        private System.Windows.Forms.MaskedTextBox TbLogSenha;
        private System.Windows.Forms.Label LbSenhalogin;
        private System.Windows.Forms.Button BtLogLogin;
        private System.Windows.Forms.Button BtLogLimpar;
        private System.Windows.Forms.Button BtLogSair;
        private System.Windows.Forms.LinkLabel LkCad;
    }
}