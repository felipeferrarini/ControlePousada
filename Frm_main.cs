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

namespace WindowsFormsApp1
{
    public partial class Frm_main : Form
    {

        public Frm_main()
        {
            InitializeComponent();
        }

        private void btn_novaReserva_Click(object sender, EventArgs e)
        {
            gb_novaReserva.Visible = true;
            btn_salvar.Visible = true;
            btn_cancelar.Visible = true;
            btn_reserva.Enabled = false;
            btn_financeiro.Enabled = false;
            btn_config.Enabled = false;
            btn_newCliente.Enabled = false;
            btn_config.Enabled = false;
            btn_cliente.Enabled = false;

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
    }
}
