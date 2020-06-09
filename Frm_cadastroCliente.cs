using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Frm_cadastroCliente : Form
    {
        private string tipo;
        public Frm_cadastroCliente()
        {
            InitializeComponent();
        }

        private void btn_cancelarReserva_Click(object sender, EventArgs e)
        {
            Close();
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

        private void rb_cpf_CheckedChanged(object sender, EventArgs e)
        {
            np_desconto.Enabled = false;
            tipo = rb_cpf.Text;
        }

        private void rb_cnpj_CheckedChanged(object sender, EventArgs e)
        {
            np_desconto.Enabled = true;
            tipo = rb_cpf.Text;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(tipo == "CPF")
                {
                    clienteCpf cliente = new clienteCpf();
                    cliente.Tipo = tipo;
                    cliente.Documento = Regex.Replace(txt_cliente.Text, "[\\,\\.\\ \\-]","");
                    cliente.Nome = txt_nome.Text;
                    cliente.Telefone = txt_telefone.Text;
                    cliente.Email = txt_email.Text;
                    cliente.Endereço = txt_logradouro.Text;
                    cliente.Bairro = txt_bairro.Text;
                    cliente.Cidade = txt_cidade.Text;
                    cliente.Estado = lp_estado.SelectedItem.ToString();
                    clienteCpf.salvarCliente(cliente);
                }
                else
                {
                    clienteCnpj cliente = new clienteCnpj();
                    cliente.Tipo = tipo;
                    cliente.Documento = Regex.Replace(txt_cliente.Text, "[\\,\\.\\ \\-]", "");
                    cliente.Nome = txt_nome.Text;
                    cliente.Telefone = txt_telefone.Text;
                    cliente.Email = txt_email.Text;
                    cliente.Endereço = txt_logradouro.Text;
                    cliente.Bairro = txt_bairro.Text;
                    cliente.Cidade = txt_cidade.Text;
                    cliente.Estado = lp_estado.SelectedItem.ToString();
                    cliente.RazaoSocial = txt_social.Text;
                    cliente.Desconto = np_desconto.Value;
                    clienteCnpj.salvarCliente(cliente);
                }
                txt_cliente.Text = "";
                txt_nome.Text = "";
                txt_telefone.Text = "";
                txt_email.Text = "";
                txt_logradouro.Text = "";
                txt_bairro.Text = "";
                txt_cidade.Text = "";
                lp_estado.SelectedItem = null;
                txt_social.Text = "";
                np_desconto.Value = 0;

                DialogResult info;
                info = MessageBox.Show("Cliente Salvo com Sucesso!", "Alerta");
            }
            catch(System.NullReferenceException erro)
            {
                DialogResult info;
                info = MessageBox.Show("Preencha todos os dados!", "Erro");
            }
        }

        private void txt_cliente_Leave(object sender, EventArgs e)
        {
            if(cliente.clienteExiste(Regex.Replace(txt_cliente.Text, "[\\,\\.\\-\\/\\ ]", "")))
            {
                DialogResult info;
                info = MessageBox.Show("O Cliente já Existe!", "Alerta");
            }
        }
    }
}
