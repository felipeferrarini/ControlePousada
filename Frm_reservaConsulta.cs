using ControlePousada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlePousada
{
    public partial class Frm_reservaConsulta : Form
    {
        private string nome = "";
        private string cidade = "";

        public Frm_reservaConsulta()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable db = new DataTable();
            
            db.Columns.Add("Número", typeof(string));
            db.Columns.Add("Nome", typeof(string));
            db.Columns.Add("Telefone", typeof(string));
            db.Columns.Add("Cidade", typeof(string));
            db.Columns.Add("Data de Entrada", typeof(string));
            db.Columns.Add("Data de Saída", typeof(string));
            db.Columns.Add("Qtd de Pessoas", typeof(string));
            db.Columns.Add("Feriado", typeof(string));
            db.Columns.Add("Desconto", typeof(string));
            db.Columns.Add("Valor", typeof(string));
            db.Columns.Add("Pago?", typeof(string));
            db.Columns.Add("Data do Pagamento", typeof(string));


            int linha = reserva.getNextNumber(Program.pathReserva);
            
            for(int i = 1; i < linha; i++)
            {
                reserva dados = new reserva(reserva.retornaReserva(i));
                DataRow Linha = db.NewRow();
                Linha["Número"] = dados.Numero;
                Linha["Nome"] = dados.ClienteNome;
                Linha["Telefone"] = dados.Telefone;
                Linha["Cidade"] = dados.Cidade;
                Linha["Data de Entrada"] = dados.DataEntrada;
                Linha["Data de Saída"] = dados.DataSaida;
                Linha["Qtd de Pessoas"] = dados.QtdPessoas;
                Linha["Feriado"] = dados.FeriadoTipo;
                Linha["Desconto"] = dados.Desconto;
                Linha["Valor"] = dados.Valor;
                Linha["Pago?"] = dados.Pago;
                Linha["Data do Pagamento"] = dados.DataPago;

                if (dados.ClienteNome.ToUpper().Contains(nome.ToUpper())&&dados.Cidade.ToUpper().Contains(cidade.ToUpper()))
                {
                    db.Rows.Add(Linha);
                }
                
            }

            
            dataGridView1.DataSource = db;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {

                Frm_reservaCriar janelaEditar = new Frm_reservaCriar(dataGridView1.SelectedCells[0].Value.ToString());
                janelaEditar.TopLevel = false;
                janelaEditar.FormBorderStyle = FormBorderStyle.None;
                janelaEditar.Dock = DockStyle.Fill;

                this.Parent.Controls.Add(janelaEditar);
                janelaEditar.Show();
                janelaEditar.BringToFront();
            }
            
        }

        private void txt_cidade_TextChanged(object sender, EventArgs e)
        {
            cidade = txt_cidade.Text;
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            nome = txt_nome.Text;
        }
    }
}
