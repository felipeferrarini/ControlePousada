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
using System.Runtime.InteropServices.ComTypes;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Threading;
using Microsoft.SqlServer.Server;
using System.Drawing.Printing;
using ControlePousada;
using System.Net.Http.Headers;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace controlePousada
{
    public partial class Frm_reservaCriar : Form
    {
        bool feriado = false;

        public Frm_reservaCriar()
        {
            InitializeComponent();
            txt_numero.Text = Convert.ToString(reserva.getNextNumber(Program.pathReserva));
            carregaFeriados();

        }
        public Frm_reservaCriar(string numero)
        {
            InitializeComponent();
            carregaFeriados();
            reserva novaReserva = new reserva(reserva.retornaReserva(Convert.ToInt32(numero)));
            txt_numero.Text = novaReserva.Numero.ToString();
            txt_cliente.Text = novaReserva.Cliente;
            txt_nome.Text = novaReserva.ClienteNome;
            txt_telefone.Text = novaReserva.Telefone;
            txt_cidade.Text = novaReserva.Cidade;
            txt_email.Text = novaReserva.Email;
            dtp_entrada.Value = novaReserva.DataEntrada;
            dtp_saida.Value = novaReserva.DataSaida;
            np_qtdPessoas.Value = novaReserva.QtdPessoas;
            cb_feriado.Checked = novaReserva.Feriado;
            feriado = true;
            lp_feriado.SelectedItem = novaReserva.FeriadoTipo;
            np_desconto.Value = novaReserva.Desconto;
            txt_valor.Text = novaReserva.Valor.ToString();
            cb_pagamento.Checked = novaReserva.Pago;
            dtp_dataPag.Value = novaReserva.DataPago;
            txt_obs.Text = novaReserva.Obs;

        }

        private void txt_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (int.TryParse(Convert.ToString(e.KeyChar), out int result))
            {
                if (txt_cliente.MaskCompleted)
                {
                    txt_cliente.Mask = "00,000,000/0000-00";
                    txt_cliente.SelectionStart = txt_cliente.Text.Length-2;
                }
            }
        }

        private void txt_cliente_TextChanged(object sender, EventArgs e)
        {
            if (txt_cliente.Text.Length > 14)
            {
                if (!int.TryParse(txt_cliente.Text.Substring(13, 1), out int result2))
                {
                    txt_cliente.Mask = "000,000,000-00";
                    txt_cliente.SelectionStart = txt_cliente.Text.Length;
                }
            }
        }

        private void cb_feriado_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_feriado.Checked)
            {
                lp_feriado.Enabled = true;
            }
            else
            {
                lp_feriado.Enabled = false;
            }
            
        }

        private void btn_salvarReserva_Click(object sender, EventArgs e)
        {
            FormatException dadoVazio = new FormatException("Preecha todos os dados!");
            FormatException erroPessoas = new FormatException("A quantidade de Pessoas não pode ser Zero!");


            try
            {
                reserva novaReserva = new reserva();
                novaReserva.Numero = Convert.ToInt32(txt_numero.Text);
                novaReserva.Cliente = txt_cliente.MaskCompleted ? Regex.Replace(txt_cliente.Text, "[\\,\\.\\ \\-]", "") : throw dadoVazio;
                novaReserva.ClienteNome = txt_nome.Text.Length > 0 ? txt_nome.Text : throw dadoVazio;
                novaReserva.Telefone = txt_telefone.Text;
                novaReserva.Cidade = txt_cidade.Text;
                novaReserva.Email = txt_email.Text;
                novaReserva.DataEntrada = dtp_entrada.Value;
                novaReserva.DataSaida = dtp_saida.Value;
                novaReserva.QtdPessoas = np_qtdPessoas.Value > 0 ? np_qtdPessoas.Value : throw erroPessoas;
                novaReserva.Feriado = cb_feriado.Checked;
                novaReserva.FeriadoTipo = cb_feriado.Checked?lp_feriado.SelectedItem.ToString():"Nenhum";
                novaReserva.Desconto = np_desconto.Value;
                novaReserva.Valor = Convert.ToDouble(txt_valor.Value);
                novaReserva.Pago = cb_pagamento.Checked;
                novaReserva.DataPago = cb_pagamento.Checked ? dtp_dataPag.Value : DateTime.Parse("01/01/1900");
                novaReserva.Obs = txt_obs.Text;

                if (reserva.reservaExiste(novaReserva.Numero))
                {
                    reserva.editarReserva(novaReserva);
                }
                else
                {
                    reserva.salvarReserva(novaReserva);
                }
                
                txt_numero.Text = "";
                txt_cliente.Text = "";
                txt_nome.Text = "";
                txt_telefone.Text = "";
                txt_cidade.Text = "";
                txt_email.Text = "";
                dtp_entrada.Value = DateTime.Now;
                dtp_saida.Value = DateTime.Now;
                np_qtdPessoas.Value = 0;
                cb_feriado.Checked = false;
                lp_feriado.SelectedItem = "";
                np_desconto.Value = 0;
                txt_valor.Text = "";
                cb_pagamento.Checked = false;
                dtp_dataPag.Value = DateTime.Now;
                txt_obs.Text = "";

                MessageBox.Show("Reserva Salva com Sucesso!", "Alerta");
            }
            catch(NullReferenceException erro)
            {
                MessageBox.Show(erro.Message, "Erro");

            }
            catch(FormatException erro)
            {
                MessageBox.Show(erro.Message, "Erro");
            }
        }

        private void cb_pagamento_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_pagamento.Checked)
            {
                dtp_dataPag.Enabled = true;
            }
            else
            {
                dtp_dataPag.Enabled = false;
            }
        }

        private void btn_cancelarReserva_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_consultCliente_Click(object sender, EventArgs e)
        {
            if (txt_cliente.MaskCompleted)
            {
                string doc = Regex.Replace(txt_cliente.Text, "[\\-\\,\\.]", "");
                if (cliente.clienteExiste(doc))
                {
                    if (doc.Length == 11)
                    {

                        string[] dados = cliente.retornaAtributos(doc);
                        txt_nome.Text = dados[0];
                        clienteCpf client = new clienteCpf(dados);
                        txt_nome.Text = client.Nome;
                        txt_telefone.Text = client.Telefone;
                        txt_cidade.Text = client.Cidade;
                        txt_email.Text = client.Email;
                    }
                    else
                    {
                        string[] dados = cliente.retornaAtributos(doc);
                        txt_nome.Text = dados[0];
                        clienteCnpj client = new clienteCnpj(dados);
                        txt_nome.Text = client.Nome;
                        txt_telefone.Text = client.Telefone;
                        txt_cidade.Text = client.Cidade;
                        txt_email.Text = client.Email;
                        np_desconto.Value = client.Desconto;
                    }
                }
                else
                {
                    DialogResult info = MessageBox.Show("Cliente não cadastrado! Deseja cadastra-lo?", "Erro",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                    if(info == DialogResult.Yes)
                    {
                        Frm_clienteCriar janelaCliente = new Frm_clienteCriar();
                        janelaCliente.TopLevel = false;
                        janelaCliente.FormBorderStyle = FormBorderStyle.None;
                        janelaCliente.Dock = DockStyle.Fill;

                        this.Parent.Controls.Add(janelaCliente);
                        janelaCliente.Show();
                        janelaCliente.BringToFront();
                    }
                }
            }
        }

        private void np_qtdPessoas_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (np_qtdPessoas.Value > 15)
                {
                    txt_valor.Value = ((np_qtdPessoas.Value - 15) * 50 + txt_valorBase.Value);
                }
                if (np_desconto.Value > 0)
                {
                    txt_valor.Value = txt_valorBase.Value * (1 - (np_desconto.Value / 100));
                }
                else
                {
                    txt_valor.Value = txt_valorBase.Value;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite apenas números no 'Valor Base'!", "Erro");
            }
        }

        private void lp_feriado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (feriado)
            {
                feriado = false;
            }
            else
            {
                txt_valorBase.Value = Configuracao.ValorBase(lp_feriado.SelectedItem.ToString());
            }
            
        }

        private void txt_valorBase_ValueChanged(object sender, EventArgs e)
        {
            txt_valor.Value = txt_valorBase.Value;
            if (np_qtdPessoas.Value > 15)
            {
                txt_valor.Value = ((np_qtdPessoas.Value - 15) * 50 + txt_valorBase.Value);
            }
            if (np_desconto.Value > 0)
            {
                txt_valor.Value = txt_valorBase.Value * (1 - (np_desconto.Value / 100));
            }
            else
            {
                txt_valor.Value = txt_valorBase.Value;
            }
        }

        private void np_desconto_ValueChanged(object sender, EventArgs e)
        {
            if (np_desconto.Value > 0)
            {
                txt_valor.Value = txt_valorBase.Value * (1 - (np_desconto.Value / 100));
            }
            else
            {
                txt_valor.Value = txt_valorBase.Value;
            }
        }

        private void txt_cliente_Click(object sender, EventArgs e)
        {
            txt_cliente.SelectionStart = 0;
        }

        private void carregaFeriados()
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
                txt_numero.Enabled = false;
                txt_cliente.Enabled = false;
                txt_nome.Enabled = false;
                txt_telefone.Enabled = false;
                txt_cidade.Enabled = false;
                txt_email.Enabled = false;
                dtp_entrada.Enabled = false;
                dtp_saida.Enabled = false;
                np_qtdPessoas.Enabled = false;
                cb_feriado.Enabled = false;
                lp_feriado.Enabled = false;
                np_desconto.Enabled = false;
                txt_valor.Enabled = false;
                cb_pagamento.Enabled = false;
                dtp_dataPag.Enabled = false;
                btn_salvarReserva.Enabled = false;
                txt_obs.Enabled = false;
            }
        }
    }
}
