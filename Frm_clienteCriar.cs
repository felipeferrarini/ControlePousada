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
using System.Drawing.Imaging;

namespace controlePousada
{
    public partial class Frm_clienteCriar : Form
    {
        private string tipo;
        public Frm_clienteCriar()
        {
            InitializeComponent();
        }

        public Frm_clienteCriar(string doc)
        {
            InitializeComponent();


            if (doc.Length == 11)
            {
                
                clienteCpf clinetes = new clienteCpf(cliente.retornaAtributos(doc));
                rb_cpf.Checked = true;
                txt_cliente.Text = clinetes.Documento;
                txt_nome.Text = clinetes.Nome;
                txt_telefone.Text =clinetes.Telefone;
                txt_email.Text = clinetes.Email;
                txt_logradouro.Text = clinetes.Endereço;
                txt_bairro.Text = clinetes.Bairro;
                txt_cidade.Text = clinetes.Cidade;
                lp_estado.SelectedItem = clinetes.Estado;
            }
            else
            {
                clienteCnpj clinetes = new clienteCnpj(cliente.retornaAtributos(doc));
                rb_cnpj.Checked = true;
                txt_cliente.Text = clinetes.Documento;
                txt_nome.Text = clinetes.Nome;
                txt_telefone.Text = clinetes.Telefone;
                txt_email.Text = clinetes.Email;
                txt_logradouro.Text = clinetes.Endereço;
                txt_bairro.Text = clinetes.Bairro;
                txt_cidade.Text = clinetes.Cidade;
                lp_estado.SelectedItem = clinetes.Estado;
                txt_social.Text = clinetes.RazaoSocial;
                np_desconto.Value = clinetes.Desconto;
                
            }
        }

        private void btn_cancelarReserva_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rb_cpf_CheckedChanged(object sender, EventArgs e)
        {
            rb_cnpj.Checked = false;
            txt_cliente.Mask = "000,000,000-00";
            np_desconto.Enabled = false;
            tipo = rb_cpf.Text;
            txt_social.Enabled = false;
        }

        private void rb_cnpj_CheckedChanged(object sender, EventArgs e)
        {
            rb_cpf.Checked = false;
            txt_cliente.Mask = "00,000,000/0000-00";
            np_desconto.Enabled = true;
            tipo = rb_cnpj.Text;
            txt_social.Enabled = true;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            NullReferenceException meuErro = new NullReferenceException();
            FormatException erroEmail = new FormatException();
            try
            {
                if (!txt_email.Text.Contains("@"))
                {
                    throw erroEmail;
                }
                if(tipo == "CPF")
                {
                    clienteCpf client = new clienteCpf();
                    client.Tipo = tipo;
                    client.Documento = txt_cliente.MaskCompleted?Regex.Replace(txt_cliente.Text, "[\\,\\.\\ \\-]",""):throw meuErro;
                    client.Nome = txt_nome.Text.Length > 0 ? txt_nome.Text : throw meuErro;
                    client.Telefone = txt_telefone.MaskCompleted? txt_telefone.Text: throw meuErro;
                    client.Email = txt_email.Text.Length > 0 ? txt_email.Text : throw meuErro;
                    client.Endereço = txt_logradouro.Text.Length>0? txt_logradouro.Text:throw meuErro;
                    client.Bairro = txt_bairro.Text.Length > 0 ? txt_bairro.Text : throw meuErro;
                    client.Cidade = txt_cidade.Text.Length > 0 ? txt_cidade.Text : throw meuErro;
                    client.Estado = lp_estado.SelectedItem.ToString();

                    if (cliente.clienteExiste(client.Documento))
                    {
                        clienteCpf.editarCliente(client);
                    }
                    else
                    {
                        clienteCpf.salvarCliente(client);
                    }
                    
                }
                else
                {
                    clienteCnpj client = new clienteCnpj();
                    client.Tipo = tipo;
                    client.Documento = txt_cliente.MaskCompleted?Regex.Replace(txt_cliente.Text, "[\\,\\.\\ \\-\\/]", ""):throw meuErro;
                    client.Nome = txt_nome.Text.Length > 0 ? txt_nome.Text : throw meuErro;
                    client.Telefone = txt_telefone.MaskCompleted ? txt_telefone.Text : throw meuErro;
                    client.Email = txt_email.Text.Length > 0 ? txt_email.Text : throw meuErro;
                    client.Endereço = txt_logradouro.Text.Length > 0 ? txt_logradouro.Text : throw meuErro;
                    client.Bairro = txt_bairro.Text.Length > 0 ? txt_bairro.Text : throw meuErro;
                    client.Cidade = txt_cidade.Text.Length > 0 ? txt_cidade.Text : throw meuErro;
                    client.Estado = lp_estado.SelectedItem.ToString();
                    client.RazaoSocial = txt_social.Text.Length > 0 ? txt_social.Text : throw meuErro; ;
                    client.Desconto = np_desconto.Value;

                    if (cliente.clienteExiste(client.Documento))
                    {
                        clienteCnpj.editarCliente(client);
                    }
                    else
                    {
                        clienteCnpj.salvarCliente(client);
                    }
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

                MessageBox.Show("Cliente Salvo com Sucesso!", "Alerta");
            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("Preencha todos os dados corretamente!", "Erro!");
            }
            catch (FormatException)
            {
                MessageBox.Show("E-mail Inválido!", "Erro!");
            }
        }

        private void txt_cliente_Leave(object sender, EventArgs e)
        {
            string doc = Regex.Replace(txt_cliente.Text, "[\\,\\.\\-\\/\\ ]", "");
            if (cliente.clienteExiste(doc))
            {
                MessageBox.Show("O Cliente já Existe!", "Alerta");

                if(tipo == "CPF")
                {
                    clienteCpf clientes = new clienteCpf(cliente.retornaAtributos(doc));
                    txt_cliente.Text = clientes.Documento;
                    txt_nome.Text = clientes.Nome;
                    txt_telefone.Text = clientes.Telefone;
                    txt_email.Text = clientes.Email;
                    txt_logradouro.Text = clientes.Endereço;
                    txt_bairro.Text = clientes.Bairro;
                    txt_cidade.Text = clientes.Cidade;
                    lp_estado.SelectedItem = clientes.Estado;
                }
                else
                {
                    clienteCnpj clientes = new clienteCnpj(cliente.retornaAtributos(doc));
                    txt_cliente.Text = clientes.Documento;
                    txt_nome.Text = clientes.Nome;
                    txt_telefone.Text = clientes.Telefone;
                    txt_email.Text = clientes.Email;
                    txt_logradouro.Text = clientes.Endereço;
                    txt_bairro.Text = clientes.Bairro;
                    txt_cidade.Text = clientes.Cidade;
                    lp_estado.SelectedItem = clientes.Estado;
                    txt_social.Text = clientes.RazaoSocial;
                    np_desconto.Value = clientes.Desconto;
                }
            }
        }

        private void Frm_clienteCriar_Load(object sender, EventArgs e)
        {
            rb_cpf.Checked = true;
            tipo = "CPF";
        }
    }
}
