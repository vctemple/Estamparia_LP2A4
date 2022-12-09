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
    public partial class Tela_Cadastro_Produto : Form
    {
        public Tela_Cadastro_Produto()
        {
            InitializeComponent();
            TbCadProdMarca.Focus();
        }

        private void BtCadProdLimp_Click(object sender, EventArgs e)
        {
            TbCadProdEstp.Clear();
            TbCadProdMarca.Clear();
            TbCadProdQtd.Clear();
            MtbCadProdPreco.Clear();
            CbCadProdCor.Text = null;
            CbCadProdTam.Text = null;
            PbCadProdImg1.Image = null;
            PbCadProdImg2.Image = null;
            BtCadProdImgAdd1.Text = "Inserir imagem 1";
            BtCadProdImgAdd2.Text = "Inserir imagem 2";
        }

        private void BtCarProdSalvar_Click(object sender, EventArgs e)
        {
            if(PbCadProdImg1.Image != null || PbCadProdImg2.Image != null)
            {
                string caminho = @"..\..\Imagens\";
                try
                {
                    Produtos produto = new Produtos(TbCadProdMarca.Text.Replace(" ", "_"), TbCadProdEstp.Text.Replace(" ", "_"), int.Parse(TbCadProdQtd.Text),
                                                    decimal.Parse(MtbCadProdPreco.Text.TrimStart('$', ' ', 'R', '_')), CbCadProdTam.Text, CbCadProdCor.Text,
                                                    caminho + PbCadProdImg1.Tag, caminho + PbCadProdImg2.Tag);
                    User_Interface_Bank UserConnect = new User_Interface_Bank();
                    UserConnect.InserirProduto(produto);
                    MessageBox.Show("Produto inserido com sucesso!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PbCadProdImg1.Image.Save(caminho + PbCadProdImg1.Tag);
                    PbCadProdImg2.Image.Save(caminho + PbCadProdImg2.Tag);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Produto sem imagem!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtCadProdImgAdd2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpeg|*.jpg|bmp|*,bmp|all files|*.*";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    PbCadProdImg2.Tag = $"{TbCadProdMarca.Text.Replace(' ', '_')}{TbCadProdEstp.Text.Replace(' ', '_')}" +
                           $"[{CbCadProdTam.Text.First()}][{CbCadProdCor.Text.First()}]pic2";
                    PbCadProdImg2.Image = Image.FromFile(ofd.FileName);
                    BtCadProdImgAdd2.Text = "Alterar imagem 2";
                }
                catch (Exception)
                {
                    MessageBox.Show("Preenche os dados de cadastro de produto primeiro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtCadProdImgAdd1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpeg|*.jpg|bmp|*,bmp|all files|*.*";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    PbCadProdImg1.Tag = $"{TbCadProdMarca.Text.Replace(' ', '_')}{TbCadProdEstp.Text.Replace(' ', '_')}" +
                           $"[{CbCadProdTam.Text.First()}][{CbCadProdCor.Text.First()}]pic1";
                    PbCadProdImg1.Image = Image.FromFile(ofd.FileName);
                    BtCadProdImgAdd1.Text = "Alterar imagem 1";
                }
                catch (Exception)
                {
                    MessageBox.Show("Preenche os dados de cadastro de produto primeiro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
