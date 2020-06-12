using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace controlePousada
{
    public partial class Frm_login : Form
    {
        Thread t1;
        public Frm_login()
        {
            InitializeComponent();
        }


        private void abrirJanela(object obj)
        {
            Application.Run(new MDIMain());
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (Mtxt_user.Text == "FELIPE" && Mtxt_password.Text == "123456")
            {
                this.Close();
                t1 = new Thread(abrirJanela);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
            else
            {
                DialogResult info;
                info = MessageBox.Show("Usuário ou senha incorretos", "Erro");
            }
        }
    }
}
