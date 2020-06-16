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

        private void carregaValores()
        {
            lb_medioMensal2.Text = Financeiro.valorMedioMensal(Convert.ToInt32(np_ano.Value), cb_real.Checked).ToString("C");
            lb_total2.Text = Financeiro.valorAnual(Convert.ToInt32(np_ano.Value), cb_real.Checked).ToString("C");
        }
        private void carregaTabela()
        {
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            DataTable db = new DataTable();

            db.Columns.Add("Mês", typeof(string));
            db.Columns.Add("Valor Recebido (R$)", typeof(string));
            db.Columns.Add("Valor A Receber (R$)", typeof(string));
            db.Columns.Add("Valor Total (R$)", typeof(string));

            int i = 1;
            foreach (var element in meses)
            {
                DataRow Linha = db.NewRow();

                Linha["Mês"] = element;
                Linha["Valor Recebido (R$)"] = Financeiro.ValorMensal(i, Convert.ToInt32(np_ano.Value), true).ToString("F");
                Linha["Valor A Receber (R$)"] = (Financeiro.ValorMensal(i, Convert.ToInt32(np_ano.Value), false) - Financeiro.ValorMensal(i, Convert.ToInt32(np_ano.Value), true)).ToString("F");
                Linha["Valor Total (R$)"] = Financeiro.ValorMensal(i, Convert.ToInt32(np_ano.Value), true).ToString("F");

                db.Rows.Add(Linha);

                i++;
            }
            dataGridView1.DataSource = db;
        }

        private void Frm_financeiro_Load(object sender, EventArgs e)
        {
            carregaValores();
            carregaTabela();
        }

        private void np_ano_ValueChanged(object sender, EventArgs e)
        {
            carregaValores();
            carregaTabela();
        }

        private void cb_real_CheckedChanged_1(object sender, EventArgs e)
        {
            carregaValores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Marque esta opção caso queira ver apenas o valor já pago.", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
