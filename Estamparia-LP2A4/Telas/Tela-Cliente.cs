using Estamparia_LP2A4.Objetos_Estamp;
using Estamparia_LP2A4.Suporte;
using Estamparia_LP2A4;
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
    public partial class Tela_Cliente : Form
    {
        private Usuario _user;
        int Id, FatNum;

        public Tela_Cliente()
        {
            InitializeComponent();
            LbCliSaudacao.Visible = false;
            LbCliNome.Visible = false;  
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_login telalogin = new Tela_login();
            telalogin.ShowDialog();
            _user = telalogin.User;
            if(telalogin.User != null)
            {
                LbCliNome.Text = _user.Nome;
                LbCliSaudacao.Visible = true;
                LbCliNome.Visible = true;
                loginToolStripMenuItem.Visible = false;
                cadastroToolStripMenuItem.Visible = false;
                
                if (_user.Perfil == "Admin")
                {
                    telaAdmToolStripMenuItem.Visible = true; 
                }
            }
                 
        }

        private void CriarFat()
        {
            User_Interface_Bank UserConnect = new User_Interface_Bank();
            FatNum = UserConnect.CriarFatura();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Cadastro telacad = new Tela_Cadastro("Cliente");
            telacad.ShowDialog();    
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void telaAdmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaHome telaHome = new TelaHome();
            telaHome.ShowDialog();
        }

        private void Tela_Cliente_Load(object sender, EventArgs e)
        {
            try
            {
                AtualizarLvProd();
                CriarFat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarLvProd()
        {
            Id = -1;
            LvCliProd.Items.Clear();
            User_Interface_Bank UserConnect = new User_Interface_Bank();

            List<Produtos> prod = UserConnect.ListarProdutos();
            if (prod.Count > 0)
            {
                foreach (var p in prod)
                {
                    ListViewItem lv = new ListViewItem(p.Marca);
                    lv.SubItems.Add(p.Id.ToString());
                    lv.SubItems.Add(p.Estampa);
                    lv.SubItems.Add(p.Preco.ToString());
                    lv.SubItems.Add(p.Tam);
                    lv.SubItems.Add(p.Cor);
                    lv.SubItems.Add(p.Qtd_estoque.ToString());
                    lv.SubItems.Add(p.Img1);
                    lv.SubItems.Add(p.Img2);
                    LvCliProd.Items.Add(lv);
                }
            }
        }

        private void LvCliProd_MouseClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = LvCliProd.FocusedItem.Index;
                Id = int.Parse(LvCliProd.Items[index].SubItems[1].Text);
                LbValorText.Text = $"R$  {LvCliProd.Items[index].SubItems[3].Text}";
                PbCliIma1.Image = Image.FromFile(LvCliProd.Items[index].SubItems[7].Text);
                PbCliIma2.Image = Image.FromFile(LvCliProd.Items[index].SubItems[8].Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbTelaCliQtd_TextChanged(object sender, EventArgs e)
        {
            if (TbTelaCliQtd.Text != null && TbTelaCliQtd.Text != "" &&
                LbValorText.Text != null && LbValorText.Text != "")
            {
                int qtd = int.Parse(TbTelaCliQtd.Text);
                float preco = float.Parse(LbValorText.Text.TrimStart('$', ' ', 'R', '_'));

                if (qtd > 0 && preco > 0)
                    LbTotalText.Text = $"R$ {(qtd * preco).ToString("F2")}";
            }
            else
                LbTotalText.Text = "R$ 0,00";
            
        }

        private void LbValorText_TextChanged(object sender, EventArgs e)
        {
            if (TbTelaCliQtd.Text != null && TbTelaCliQtd.Text != "" &&
                LbValorText.Text != null && LbValorText.Text != "")
            {
                int qtd = int.Parse(TbTelaCliQtd.Text);
                float preco = float.Parse(LbValorText.Text.TrimStart('$', ' ', 'R', '_'));

                if (qtd > 0 && preco > 0)
                    LbTotalText.Text = $"R$ {(qtd * preco).ToString("F2")}";
            }
            else
                LbTotalText.Text = "R$ 0,00";
        }

        private void carrinhoDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_user != null)
            {
                Tela_Carrinho tela_Carrinho = new Tela_Carrinho(FatNum, _user);
                tela_Carrinho.ShowDialog();
            }
            else
            {
                Tela_Carrinho tela_Carrinho = new Tela_Carrinho(FatNum);
                tela_Carrinho.ShowDialog();
            }   
        }

        private void BtCliAddCarr_Click(object sender, EventArgs e)
        {
            if(Id != -1 && TbTelaCliQtd.Text != null && TbTelaCliQtd.Text != ""
                && TbTelaCliQtd.Text != "0")
            {
                Item_Carrinho ItemCarr = new Item_Carrinho(Id, int.Parse(TbTelaCliQtd.Text));
                User_Interface_Bank UserConnect = new User_Interface_Bank();
                UserConnect.InserirProdCarrinho(FatNum, ItemCarr);
                MessageBox.Show("Item adicionado ao carrinho!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Informe o item corretamente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
