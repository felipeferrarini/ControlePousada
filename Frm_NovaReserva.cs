﻿using System;
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

namespace WindowsFormsApp1
{
    public partial class Frm_novaReserva : Form
    {

        public Frm_novaReserva()
        {
            InitializeComponent();
            txt_numero.Text = Convert.ToString(reserva.getNextNumber(Program.pathReserva));
        }

        private void txt_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (int.TryParse(Convert.ToString(e.KeyChar), out int result))
            {
                if (txt_cliente.MaskCompleted)
                {
                    txt_cliente.Mask = "00.000.000/0000-00";
                }
            }
        }

        private void txt_cliente_TextChanged(object sender, EventArgs e)
        {
            if (txt_cliente.Text.Length > 14)
            {
                if (!int.TryParse(txt_cliente.Text.Substring(13, 1), out int result2))
                {
                    txt_cliente.Mask = "000.000.000-00";
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
            try
            {
                reserva novaReserva = new reserva();
                novaReserva.Numero = Convert.ToInt32(txt_numero.Text);
                novaReserva.Cliente = Regex.Replace(txt_cliente.Text, "[\\-\\,\\.\\ ]", "");
                novaReserva.ClienteNome = txt_nome.Text;
                novaReserva.Telefone = txt_telefone.Text;
                novaReserva.Cidade = txt_cidade.Text;
                novaReserva.Email = txt_email.Text;
                novaReserva.DataEntrada = dtp_entrada.Value;
                novaReserva.DataSaida = dtp_saida.Value;
                novaReserva.QtdPessoas = np_qtdPessoas.Value;
                novaReserva.Feriado = cb_feriado.Checked;
                novaReserva.FeriadoTipo = lp_feriado.SelectedItem.ToString();
                novaReserva.Desconto = np_desconto.Value;
                novaReserva.Valor = Convert.ToDouble(txt_valor.Text);
                novaReserva.Pago = cb_pagamento.Checked;
                reserva.salvarReserva(novaReserva);
            }
            catch(System.NullReferenceException erro)
            {
                DialogResult info;
                info = MessageBox.Show("Preencha todos os dados!", "Erro");

            }
            catch(System.FormatException erro2)
            {
                DialogResult info;
                info = MessageBox.Show("Preencha todos os dados corretamente!", "Erro");
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
    }
}