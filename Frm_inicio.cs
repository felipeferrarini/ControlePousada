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
    public partial class Frm_inicio : Form
    {
        public Frm_inicio()
        {
            InitializeComponent();
        }

        public void AbrirFormNoPanel(object janelas)
        {
            Form novaJanela = janelas as Form;
            novaJanela.TopLevel = false;
            novaJanela.FormBorderStyle = FormBorderStyle.None;
            novaJanela.Dock = DockStyle.Fill;

            this.Parent.Controls.Add(novaJanela);
            novaJanela.Show();
            novaJanela.BringToFront();
            this.Close();
        }

        private void btn_novaReserva_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new Frm_reservaCriar());
        }

        private void btn_reserva_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new Frm_reservaConsulta());
        }

        private void btn_newCliente_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new Frm_clienteCriar());
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new Frm_clienteConsulta());
        }

        private void btn_financeiro_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new Frm_financeiro());
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new Frm_config());
        }
    }
}
