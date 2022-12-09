using Estamparia_LP2A4.Objetos_Estamp;
using Estamparia_LP2A4.Suporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estamparia_LP2A4.Telas
{
    public partial class Tela_login : Form
    {
        private Usuario _user;
        
        public Tela_login()
        {
            InitializeComponent();
            TbLogEmail.Focus();
        }
   
        public Usuario User { get { return _user; } }

        private void BtLogLimpar_Click(object sender, EventArgs e)
        {
            TbLogEmail.Clear();
            TbLogSenha.Clear();
            TbLogEmail.Focus();
        }

        private void BtLogLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login(TbLogEmail.Text, TbLogSenha.Text);
                User_Interface_Bank userlog = new User_Interface_Bank();
                if (userlog.Login(login))
                {
                    User_Interface_Bank userwrite = new User_Interface_Bank();
                    Usuario Userlogin = userwrite.RetornaDadosUser(login.Email);
                    this.Visible = false;
                    _user = Userlogin;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtLogSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LkCad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tela_Cadastro TelaCad = new Tela_Cadastro("Cliente");
            TelaCad.ShowDialog();
        }
    }
}
