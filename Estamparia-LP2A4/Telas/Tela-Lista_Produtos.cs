using Estamparia_LP2A4.Objetos_Estamp;
using Estamparia_LP2A4.Suporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estamparia_LP2A4.Telas
{
    public partial class Tela_Lista_Produtos : Form
    {
        int Id;
        bool FlagImg1, FlagImg2;
        public Tela_Lista_Produtos()
        {
            InitializeComponent();
        }

        private void Tela_Lista_Produtos_Load(object sender, EventArgs e)
        {
            try
            {
                AtualizarLvProd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetTela()
        {
            PbProdImg1.Image = null;
            PbProdImg2.Image = null;
            TbListProdEstampa.Clear();
            TbListProdMarca.Clear();
            TbListProdPreco.Clear();
            TbListProdQtd.Clear();
            CbListProdCor.Text = null;
            CbListProdTam.Text = null;
        }

        private void AtualizarLvProd()
        {
            Id = -1; FlagImg1 = false; FlagImg2 = false;
            LvProd.Items.Clear();
            User_Interface_Bank UserConnect = new User_Interface_Bank();

            List<Produtos> prod = UserConnect.ListarProdutos();
            if (prod.Count > 0)
            {
                foreach (var p in prod)
                {
                    ListViewItem lv = new ListViewItem(p.Id.ToString());
                    lv.SubItems.Add(p.Marca);
                    lv.SubItems.Add(p.Estampa);
                    lv.SubItems.Add(p.Preco.ToString());
                    lv.SubItems.Add(p.Tam);
                    lv.SubItems.Add(p.Cor);
                    lv.SubItems.Add(p.Qtd_estoque.ToString());
                    lv.SubItems.Add(p.Img1);
                    lv.SubItems.Add(p.Img2);
                    LvProd.Items.Add(lv);
                }
            }
        }

        private void LvProd_MouseClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = LvProd.FocusedItem.Index;
                Id = int.Parse(LvProd.Items[index].SubItems[0].Text);
                TbListProdMarca.Text = LvProd.Items[index].SubItems[1].Text;
                TbListProdEstampa.Text = LvProd.Items[index].SubItems[2].Text;
                TbListProdPreco.Text = $"R$ {LvProd.Items[index].SubItems[3].Text}";
                CbListProdTam.Text = LvProd.Items[index].SubItems[4].Text;
                CbListProdCor.Text = LvProd.Items[index].SubItems[5].Text;
                TbListProdQtd.Text = LvProd.Items[index].SubItems[6].Text;
                PbProdImg1.Image = Image.FromFile(LvProd.Items[index].SubItems[7].Text);
                PbProdImg1.Tag = LvProd.Items[index].SubItems[7].Text;
                PbProdImg2.Image = Image.FromFile(LvProd.Items[index].SubItems[8].Text);
                PbProdImg2.Tag = LvProd.Items[index].SubItems[8].Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtListImg1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpeg|*.jpg|bmp|*,bmp|all files|*.*";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    PbProdImg1.Image = Image.FromFile(ofd.FileName);
                    PbProdImg1.Tag += $" {DateTime.Now.ToString().Replace(" ", "_").Replace(":", ".").Replace("/", ".")}";
                    FlagImg1 = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Preenche os dados de cadastro de produto primeiro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtListImg2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpeg|*.jpg|bmp|*,bmp|all files|*.*";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    PbProdImg2.Image = Image.FromFile(ofd.FileName);
                    PbProdImg2.Tag += $" {DateTime.Now.ToString().Replace(" ", "_").Replace(":", ".").Replace("/", ".")}";
                    FlagImg2 = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Preenche os dados de cadastro de produto primeiro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtListSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos prod = new Produtos(Id, TbListProdMarca.Text.Replace(" ", "_"), TbListProdEstampa.Text.Replace(" ", "_"),
                                        int.Parse(TbListProdQtd.Text), decimal.Parse(TbListProdPreco.Text.TrimStart('$', ' ', 'R', '_')),
                                        CbListProdTam.Text, CbListProdCor.Text, PbProdImg1.Tag.ToString(), PbProdImg2.Tag.ToString());
                
                User_Interface_Bank UserConnect = new User_Interface_Bank();
                UserConnect.AlterarProduto(prod);
                MessageBox.Show("Produto inserido com sucesso!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (FlagImg1)
                    PbProdImg1.Image.Save(PbProdImg1.Tag.ToString());
                if(FlagImg2)
                    PbProdImg2.Image.Save(PbProdImg2.Tag.ToString());
                AtualizarLvProd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtListDel_Click(object sender, EventArgs e)
        {
            if(Id != -1)
            {
                try
                {
                    User_Interface_Bank UserConnect = new User_Interface_Bank();
                    UserConnect.DeletarProduto(Id);
                    MessageBox.Show("Produto deletado com sucesso!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    AtualizarLvProd();
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
