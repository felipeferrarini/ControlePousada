using ControlePousada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_clienteConsulta : Form
    {
        public Frm_clienteConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable db = new DataTable();

            db.Columns.Add("CPF/CNPJ", typeof(string));
            db.Columns.Add("Nome", typeof(string));
            

            string[] dados = File.ReadAllLines(Program.pathClient);

            foreach (var element in dados)
            {
                DataRow Linha = db.NewRow();

                string[] linha = element.Split(';');
                                
                Linha["Nome"] = linha[2];
                Linha["CPF/CNPJ"] = linha[0].Length == 11 ? Convert.ToUInt64(linha[0]).ToString(@"000\.000\.000\-00") : Convert.ToUInt64(linha[0]).ToString(@"00\.000\.000\/0000\-00");
                db.Rows.Add(Linha);
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
    }
}
