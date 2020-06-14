using ControlePousada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlePousada
{
    public partial class Frm_clienteConsulta : Form
    {
        //Variaveis para pesquisa
        private string documento = "";
        private string nome = "";
        private string cidade = "";

        public Frm_clienteConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable db = new DataTable();

            db.Columns.Add("CPF/CNPJ", typeof(string));
            db.Columns.Add("Nome", typeof(string));
            db.Columns.Add("Cidade", typeof(string));
            

            string[] dados = File.ReadAllLines(Program.pathClient);

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
            dataGridView1.DataSource = db;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                Frm_clienteCriar janelaEditar = new Frm_clienteCriar(Regex.Replace(dataGridView1.SelectedCells[0].Value.ToString(),"[\\-\\.\\,\\/]",""));
                janelaEditar.TopLevel = false;
                janelaEditar.FormBorderStyle = FormBorderStyle.None;
                janelaEditar.Dock = DockStyle.Fill;

                this.Parent.Controls.Add(janelaEditar);
                janelaEditar.Show();
                janelaEditar.BringToFront();
            }
        }

        private void lb_documento_Click(object sender, EventArgs e)
        {

        }

        private void lb_nome_Click(object sender, EventArgs e)
        {

        }

        private void gb_filtros_Enter(object sender, EventArgs e)
        {

        }
        private void txt_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (int.TryParse(Convert.ToString(e.KeyChar), out int result))
            {
                if (txt_documento.MaskCompleted)
                {
                    txt_documento.Mask = "00,000,000/0000-00";
                    txt_documento.SelectionStart = txt_documento.Text.Length - 2;
                }
            }
        }

        private void txt_documento_TextChanged(object sender, EventArgs e)
        {
            if (txt_documento.Text.Length > 14)
            {
                if (!int.TryParse(txt_documento.Text.Substring(13, 1), out int result2))
                {
                    txt_documento.Mask = "000,000,000-00";
                    txt_documento.SelectionStart = txt_documento.Text.Length;
                }
            }

            documento = Regex.Replace(txt_documento.Text, "[\\,\\.\\-\\ \\/]","");
        }

        private void txt_documento_Click(object sender, EventArgs e)
        {
            txt_documento.SelectionStart = 0;
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            nome = txt_nome.Text;
        }

        private void txt_cidade_TextChanged(object sender, EventArgs e)
        {
            cidade = txt_cidade.Text;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_documento.Text = "";
            txt_nome.Text = "";
            txt_cidade.Text = "";

            documento = "";
            nome = "";
            cidade = "";
        }
    }
}
