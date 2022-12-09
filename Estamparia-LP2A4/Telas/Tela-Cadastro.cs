using Estamparia_LP2A4.Objetos_Estamp;
using Estamparia_LP2A4.Suporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estamparia_LP2A4.Telas
{
    public partial class Tela_Cadastro : Form
    {
        string _perfil;

        public Tela_Cadastro(string perfil)
        {
            InitializeComponent();
            TbxNome.Focus();
            _perfil = perfil;
            if(perfil == "Cliente")
            {
                CbCadastro.Visible = false;
                LbCliente.Visible = true;
                PanelCliente.Visible = true;
                CbCadastro.Text = "Cliente";

            }
            else if(perfil == "Admin")
            {
                CbCadastro.Visible = true;
                LbCliente.Visible = false;
                PanelCliente.Visible = false;
            }
        }

        private void BtCadSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario(TbxNome.Text, TbxEmail.Text, TbxTel.Text,
                                                        TbxCPF.Text, TbxSenha.Text, CbCadastro.Text);
                User_Interface_Bank Userconnect = new User_Interface_Bank();
                Userconnect.Inserir(user);
                MessageBox.Show("Usuário inserido com sucesso!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtCadLimpar_Click(object sender, EventArgs e)
        {
            TbxNome.Clear();
            TbxEmail.Clear();
            TbxTel.Clear();
            TbxCPF.Clear();
            TbxSenha.Clear();
            TbxNome.Focus();
        }
    }
}
