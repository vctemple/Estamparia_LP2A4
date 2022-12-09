using Estamparia_LP2A4.Objetos_Estamp;
using Estamparia_LP2A4.Suporte;
using Estamparia_LP2A4.Telas;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;

namespace Estamparia_LP2A4
{
    public partial class TelaHome : Form
    {
        string Date;
        public TelaHome()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Cadastro telacad = new Tela_Cadastro("Admin");
            telacad.ShowDialog();

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_lista_usuario telalist = new Tela_lista_usuario();
            telalist.ShowDialog();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_Produto telaCadProd = new Tela_Cadastro_Produto();
            telaCadProd.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Lista_Produtos telaListProd = new Tela_Lista_Produtos();
            telaListProd.ShowDialog();
        }

        private void totalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Interface_Bank UserConnect = new User_Interface_Bank();
            try
            {
                List<Fatura> Faturas = UserConnect.RelatorioVendasTotal();
                ExportarTabela(Faturas, "TotalFatMontante", "Montante Total de faturas até o presente momento");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao exportar dados!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Date != null)
            {
                Date = $"{Date.Remove(4, 6)}%";
                User_Interface_Bank UserConnect = new User_Interface_Bank();
                try
                {
                    List<Fatura> Faturas = UserConnect.RelatorioVendasData(Date);
                    ExportarTabela(Faturas, $"TotalFat{Date}", $"Total de faturas do ano {Date}");
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao exportar dados!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void mêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Date != null)
            {
                Date = $"{Date.Remove(7, 3)}%";
                User_Interface_Bank UserConnect = new User_Interface_Bank();
                try
                {
                    List<Fatura> Faturas = UserConnect.RelatorioVendasData(Date);
                    ExportarTabela(Faturas, $"TotalFat{Date}", $"Total de faturas do mês {Date}");
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao exportar dados!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void diaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Date != null)
            {
                User_Interface_Bank UserConnect = new User_Interface_Bank();
                try
                {
                    List<Fatura> Faturas = UserConnect.RelatorioVendasData(Date);
                    ExportarTabela(Faturas, $"TotalFat{Date}", $"Total de faturas do dia {Date}");
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao exportar dados!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void McAdm_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime start = McAdm.SelectionRange.Start;
            Date = start.ToString("yyyy-MM-dd");
        }

        private void ExportarTabela(List<Fatura> Faturas, string NomeArquivo, string Titulo)
        {
            decimal TotalFatGeral = 0;
            NomeArquivo += "_" + DateTime.Now.ToShortDateString().Replace("/", "-");
            
            PdfDocument doc = new PdfDocument();
            PdfPageBase page = doc.Pages.Add(PdfPageSize.A4, new PdfMargins(40));
            PdfTable table = new PdfTable();
            table.Style.DefaultStyle.Font = new PdfTrueTypeFont(new Font("Helvetica", 12f, FontStyle.Regular), true);
            table.Style.HeaderStyle.Font = new PdfTrueTypeFont(new Font("Helvetica", 12f, FontStyle.Bold), true);
            PdfFont font = new PdfFont(PdfFontFamily.Helvetica, 18f, PdfFontStyle.Bold);
            PdfSolidBrush brush = new PdfSolidBrush(Color.Black);


            PdfStringFormat centerAlignment
        = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            page.Canvas.DrawString(Titulo,
                font, brush, page.Canvas.ClientSize.Width / 2, 40, centerAlignment);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Data");
            dataTable.Columns.Add("Total Fatura");

            foreach (var Fat in Faturas)
            {
                List<string> f = new List<string>();
                f.Add(Fat.NomeUser);
                f.Add(Fat.EmailUser);
                f.Add(Fat.Data);
                f.Add(Fat.Total.ToString());
                dataTable.Rows.Add(f.ToArray());
                TotalFatGeral += Fat.Total;
            }
            dataTable.Rows.Add(new string[] { "", "", "Soma Total das faturas", $"R$ {TotalFatGeral.ToString()}" });


            table.DataSource = dataTable;
            table.Style.ShowHeader = true;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.Gray;
            table.Style.HeaderStyle.TextBrush = PdfBrushes.White;
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            for (int i = 0; i < table.Columns.Count; i++)
            {
                table.Columns[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }
            table.BeginRowLayout += Table_BeginRowLayout;
            table.Draw(page, new PointF(0, 80));

            doc.SaveToFile($"{NomeArquivo}.pdf");
            File.Move($@"..\..\bin\Debug\{NomeArquivo}.pdf", $@"..\..\Relatorios\{NomeArquivo}.pdf");
        }

        private static void Table_BeginRowLayout(object sender, BeginRowLayoutEventArgs args)
        {
            args.MinimalHeight = 20f;
            if (args.RowIndex < 0)
            {
                return;
            }
            if (args.RowIndex % 2 == 1)
            {
                args.CellStyle.BackgroundBrush = PdfBrushes.LightGray;
            }
            else
            {
                args.CellStyle.BackgroundBrush = PdfBrushes.White;
            }
        }
    }
}
