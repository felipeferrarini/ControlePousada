using controlePousada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlePousada
{
    public partial class Frm_config : Form
    {
        public Frm_config()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(configuracao.cadastraFeriado(txt_novoFeriado.Text, np_novoFeriado.Value))
            {
                MessageBox.Show("Feriado Cadastrado com Sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                carregaLista();
            }
            else
            {
                MessageBox.Show("Feriado ja Cadastrado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_novoFeriado.Text = "";
            np_novoFeriado.Value = 0;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Frm_inicio janelaInicio = new Frm_inicio();
            janelaInicio.TopLevel = false;
            janelaInicio.FormBorderStyle = FormBorderStyle.None;
            janelaInicio.Dock = DockStyle.Fill;

            this.Parent.Controls.Add(janelaInicio);
            janelaInicio.Show();
            janelaInicio.BringToFront();
            this.Close();
        }

        private void Frm_config_Load(object sender, EventArgs e)
        {
            carregaLista();
        }

        private void carregaLista()
        {
            if (lp_editaFeriado.Items.Count > 0)
            {
                lp_editaFeriado.Items.Clear();
            }
            try
            {
                int i = 0;
                string[] feriados = configuracao.retornaFeriados();
                foreach (var element in feriados)
                {
                    lp_editaFeriado.Items.Add(feriados[i]);
                    i++;
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("O arquivo de configurações foi excluido ou está inacessivel! Por favor, feche o aplicativo e abra-o novamente.", "Erro de Arquivo");
            }
        }

        private void lp_editaFeriado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lp_editaFeriado.SelectedIndex > 0)
                np_editaFeriado.Value = configuracao.ValorBase(lp_editaFeriado.SelectedItem.ToString());
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if(configuracao.editaFeriado(lp_editaFeriado.SelectedItem.ToString(), np_editaFeriado.Value))
            {
                MessageBox.Show("Feriado Editado com Sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lp_editaFeriado.SelectedIndex = -1;
                np_editaFeriado.Value = 0;
                carregaLista();
            }
        }
    }
}
