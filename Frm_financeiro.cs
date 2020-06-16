using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using controlePousada;
using System.Windows.Forms.DataVisualization.Charting;

namespace ControlePousada
{
    public partial class Frm_financeiro : Form
    {
        public Frm_financeiro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ano = Convert.ToInt32(np_ano.Value);
            string[] meses = { "Janeiro","Fevereiro","Março","Abril","Maio","Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro" };
            double[] valorRec = new double[12];
            double[] valorArec = new double[12];
            double[] valorTotal = new double[12];

            for ( int i = 0; i<12; i++)
            {
                valorRec[i] = financeiro.ValorMensal(i + 1, ano)[0];
                valorArec[i] = financeiro.ValorMensal(i + 1, ano)[1];
                valorTotal[i] = financeiro.ValorMensal(i + 1, ano)[0] + financeiro.ValorMensal(i + 1, ano)[1];
            }

            graficos.Palette = ChartColorPalette.Bright;
            graficos.Titles.Add("Meu ovo");

            for(int i = 0; i < meses.Length; i++)
            {
                Series series = graficos.Series.Add(meses[i]);
                series.Points.Add(valorRec[i]);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (graficos.Series.Count > 0)
            {
                int count = graficos.Series.Count;

                graficos.Series.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*DataTable db = new DataTable();

            db.Columns.Add("CPF/CNPJ", typeof(string));
            db.Columns.Add("Nome", typeof(string));
            db.Columns.Add("Cidade", typeof(string));


            string[] dados = File.ReadAllLines(Program.pathReserva);

            foreach (var element in dados)
            {
                DataRow Linha = db.NewRow();

                string[] linha = element.Split(';');

                if (linha[0].ToUpper().Contains(documento.ToUpper())
                    && linha[2].ToUpper().Contains(nome.ToUpper())
                    && linha[7].ToUpper().Contains(cidade.ToUpper()))
                {
                    Linha["Nome"] = linha[2];
                    Linha["CPF/CNPJ"] = linha[0].Length == 11 ? Convert.ToUInt64(linha[0]).ToString(@"000\.000\.000\-00") : Convert.ToUInt64(linha[0]).ToString(@"00\.000\.000\/0000\-00");
                    Linha["Cidade"] = linha[7];
                    db.Rows.Add(Linha);
                }
            }
            dataGridView1.DataSource = db;*/
        }

        private void Frm_financeiro_Load(object sender, EventArgs e)
        {
            lb_medioRec2.Text ="R$ " + financeiro.valorMedioMensal(Convert.ToInt32(np_ano.Value))[0].ToString("F");
            lb_medioArec2.Text = "R$ " + financeiro.valorMedioMensal(Convert.ToInt32(np_ano.Value))[1].ToString("F");
            lb_medioTotal2.Text = "R$ " + financeiro.valorMedioMensal(Convert.ToInt32(np_ano.Value))[2].ToString("F");
        }

        private void np_ano_ValueChanged(object sender, EventArgs e)
        {
            lb_medioRec2.Text = "R$ " + financeiro.valorMedioMensal(Convert.ToInt32(np_ano.Value))[0].ToString("F");
            lb_medioArec2.Text = "R$ " + financeiro.valorMedioMensal(Convert.ToInt32(np_ano.Value))[1].ToString("F");
            lb_medioTotal2.Text = "R$ " + financeiro.valorMedioMensal(Convert.ToInt32(np_ano.Value))[2].ToString("F");
        }
    }
}
