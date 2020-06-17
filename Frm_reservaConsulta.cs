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
using System.Xml.Linq;

namespace controlePousada
{
    public partial class Frm_reservaConsulta : Form
    {
        private string numero = "";
        private string nome = "";
        private string cidade = "";
        private string dataEntrada = "";
        private string dataSaida = "";
        private string feriado = "";
        private string dataPagamento = "";
        private string mes = "";

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

                if (dados.Numero.ToString().ToUpper().Contains(numero.ToUpper())
                    && dados.ClienteNome.ToUpper().Contains(nome.ToUpper())
                    && dados.Cidade.ToUpper().Contains(cidade.ToUpper())
                    && dados.DataEntrada.ToString().Substring(3,2).Contains(mes)
                    && dados.FeriadoTipo.Contains(feriado)
                    && dados.DataEntrada.ToString().Substring(0,10).Contains(dataEntrada)
                    && dados.DataSaida.ToString().Substring(0, 10).Contains(dataSaida)
                    && dados.DataPago.ToString().Substring(0, 10).Contains(dataPagamento))
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lp_mes.SelectedIndex == 0)
            {
                mes = "";
            }
            else
            {
                mes = (lp_mes.SelectedIndex + 1) < 10 ? "0" + (lp_mes.SelectedIndex).ToString() : (lp_mes.SelectedIndex).ToString();
            } 
        }

        private void txt_numero_TextChanged(object sender, EventArgs e)
        {
            numero = txt_numero.Text;
        }

        private void Frm_reservaConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                string[] feriados = Configuracao.retornaFeriados();
                foreach (var element in feriados)
                {
                    lp_feriado.Items.Add(feriados[i]);
                    i++;
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("O arquivo de configurações foi excluido ou está inacessivel! Por favor, feche o aplicativo e abra-o novamente.", "Erro de Arquivo");
            }
        }

        private void lp_feriado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lp_feriado.SelectedIndex != -1)
                feriado = lp_feriado.SelectedItem.ToString();
        }

        private void dtp_entrada_ValueChanged(object sender, EventArgs e)
        {
            dataEntrada = dtp_entrada.Value.ToString().Substring(0,10);
        }

        private void dtp_saida_ValueChanged(object sender, EventArgs e)
        {
            dataSaida = dtp_saida.Value.ToString().Substring(0, 10);
        }

        private void dtp_pagamento_ValueChanged(object sender, EventArgs e)
        {
            dataPagamento = dtp_pagamento.Value.ToString().Substring(0, 10);
        }

        private void cb_entrada_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_entrada.Checked)
            {
                dtp_entrada.Enabled = true;
            }
            else
            {
                dtp_entrada.Enabled = false;
                dataEntrada = "";
            }
        }

        private void cb_saida_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_saida.Checked)
                dtp_saida.Enabled = true;
            else
            {
                dtp_saida.Enabled = false;
                dataSaida = "";
            }
        }

        private void cb_pagamento_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_pagamento.Checked)
                dtp_pagamento.Enabled = true;
            else
            {
                dtp_pagamento.Enabled = false;
                dataPagamento = "";
            }
        }

        private void btn_limpa_Click(object sender, EventArgs e)
        {
            numero = "";
            nome = "";
            cidade = "";
            mes = "";
            feriado = "";
            dataEntrada = "";
            dataSaida = "";
            dataPagamento = "";

            txt_numero.Text = "";
            txt_nome.Text = "";
            txt_cidade.Text = "";
            lp_mes.SelectedIndex = 0;
            lp_feriado.SelectedIndex = -1;
            cb_entrada.Checked = false;
            cb_saida.Checked = false;
            cb_pagamento.Checked = false;
        }
    }
}
