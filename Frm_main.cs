using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            btn_editar.Enabled = false;
            btn_consulta.Enabled = false;
            btn_financeiro.Enabled = false;
            btn_config.Enabled = false;
        }
    }
}
