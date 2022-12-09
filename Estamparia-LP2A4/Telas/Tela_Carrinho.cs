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
    public partial class Tela_Carrinho : Form
    {
        private int _numFat;
        private Usuario _user;
        int IdItem = -1;
        decimal TotalCarr = 0;

        // Carrinho sem Login
        public Tela_Carrinho(int NumFat)
        {
            _numFat = NumFat;
            InitializeComponent();
        }

        // Carrinho com Login
        public Tela_Carrinho(int NumFat, Usuario User)
        {
            _numFat = NumFat;
            _user = User;
            InitializeComponent();
        }

        private void ResetTela()
        {
            TotalCarr = 0;
            PbCarrIma1.Image = null;
            PbCarrIma2.Image = null;
            LbTotalText.Text = "R$ 0,00";
        }

        private void AtualizarLvCarr()
        {
            LvCarr.Items.Clear();
            User_Interface_Bank UserConnect = new User_Interface_Bank();
            List<Produtos> ItemCarr = UserConnect.ListaCarrinho(_numFat);
            if(ItemCarr.Count > 0)
            {
                foreach(var item in ItemCarr)
                {
                    ListViewItem lv = new ListViewItem(item.Marca);
                    lv.SubItems.Add(item.Id.ToString());
                    lv.SubItems.Add(item.Estampa);
                    lv.SubItems.Add(item.Cor);
                    lv.SubItems.Add(item.Tam);
                    lv.SubItems.Add($"R$ {item.Preco}");
                    lv.SubItems.Add(item.Qtd_estoque.ToString());
                    lv.SubItems.Add(item.Img1);
                    lv.SubItems.Add(item.Img2);
                    LvCarr.Items.Add(lv);
                    TotalCarr += item.Preco * item.Qtd_estoque;
                }
                LbTotalText.Text = $"R$ {TotalCarr}";   
            }
        }

        private void BtListDel_Click(object sender, EventArgs e)
        {
            if (IdItem != -1)
            {
                try
                {
                    User_Interface_Bank UserConnect = new User_Interface_Bank();
                    UserConnect.DeletarItemCarr(IdItem, _numFat);
                    MessageBox.Show("Item removido com sucesso!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ResetTela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    AtualizarLvCarr();
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tela_Carrinho_Load(object sender, EventArgs e)
        {
            try
            {
                AtualizarLvCarr();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LvCliProd_MouseClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = LvCarr.FocusedItem.Index;
                IdItem = int.Parse(LvCarr.Items[index].SubItems[1].Text);
                PbCarrIma1.Image = Image.FromFile(LvCarr.Items[index].SubItems[7].Text);
                PbCarrIma2.Image = Image.FromFile(LvCarr.Items[index].SubItems[8].Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtCarBuy_Click(object sender, EventArgs e)
        {
            if(TotalCarr > 0)
            {
                if (_user == null)
                {
                    Tela_login Telalog = new Tela_login();
                    Telalog.ShowDialog();
                    _user = Telalog.User;
                }
                if(_user != null)
                {
                    User_Interface_Bank UserConnect = new User_Interface_Bank();
                    UserConnect.RealizarCompra(_numFat, _user.Id, TotalCarr);
                    MessageBox.Show("Compra realizada!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Carrinho sem itens!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
