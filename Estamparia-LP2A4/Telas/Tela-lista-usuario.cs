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
    public partial class Tela_lista_usuario : Form
    {
        int Id = -1;
        bool senha = false;
        public Tela_lista_usuario()
        {
            InitializeComponent();
        }

        private void Tela_lista_usuario_Load(object sender, EventArgs e)
        {
            try
            {
                AtualizarLvUser();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void AtualizarLvUser()
        {
            LvUserList.Items.Clear();
            User_Interface_Bank userCon = new User_Interface_Bank();

            List<Usuario> user = userCon.listarUsers();
            if(user.Count > 0)
            {
                foreach(var u in user)
                {
                    ListViewItem lv = new ListViewItem(u.Id.ToString());
                    lv.SubItems.Add(u.Nome);
                    lv.SubItems.Add(u.CPF);
                    lv.SubItems.Add(u.Telefone);
                    lv.SubItems.Add(u.Email);
                    lv.SubItems.Add(u.Perfil);
                    LvUserList.Items.Add(lv);
                }
            }

        }

        private void ResetTela()
        {
            TbListNome.Clear();
            TbListEmail.Clear();
            MtbListTel.Clear();
            MtbListCpf.Clear();
            TbListSenha.Clear();
            BtListEditsenha.Visible = true;
            TbListSenha.Visible = false;
            LbListSenha.Visible = false;
            senha = false;
            Id = -1;
        }

        private void BtListEditsenha_Click(object sender, EventArgs e)
        {
            BtListEditsenha.Visible = false;
            TbListSenha.Visible = true;
            LbListSenha.Visible = true;
            senha = true;

        }

        private void LvUserList_MouseClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = LvUserList.FocusedItem.Index;
                Id = int.Parse(LvUserList.Items[index].SubItems[0].Text);
                TbListNome.Text = LvUserList.Items[index].SubItems[1].Text;
                MtbListCpf.Text = LvUserList.Items[index].SubItems[2].Text;
                MtbListTel.Text = LvUserList.Items[index].SubItems[3].Text;
                TbListEmail.Text = LvUserList.Items[index].SubItems[4].Text;
                CbListPerfil.Text = LvUserList.Items[index].SubItems[5].Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtListSalvar_Click(object sender, EventArgs e)
        {
            if (senha)
            {
                try
                {
                    Usuario user = new Usuario(Id, TbListNome.Text, TbListEmail.Text, MtbListTel.Text,
                                               MtbListCpf.Text, TbListSenha.Text, CbListPerfil.Text);
                    User_Interface_Bank Userconnect = new User_Interface_Bank();
                    Userconnect.AlterarComSenha(user);
                    MessageBox.Show("Usuário editado com sucesso!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    AtualizarLvUser();
                    ResetTela();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Usuario user = new Usuario(Id, TbListNome.Text, TbListEmail.Text, MtbListTel.Text,
                                               MtbListCpf.Text, CbListPerfil.Text);
                    User_Interface_Bank Userconnect = new User_Interface_Bank();
                    Userconnect.AlterarSemSenha(user);
                    MessageBox.Show("Usuário editado com sucesso!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    AtualizarLvUser();
                    ResetTela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtListDel_Click(object sender, EventArgs e)
        {
            if(Id != -1)
            {
                try
                {
                    Usuario user = new Usuario(Id);
                    User_Interface_Bank Userconnect = new User_Interface_Bank();
                    Userconnect.DeletarUsuario(user);
                    MessageBox.Show("Usuário deletado com sucesso!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    AtualizarLvUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ResetTela();
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuário selecionado!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
