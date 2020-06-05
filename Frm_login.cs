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

namespace WindowsFormsApp1
{
    public partial class Frm_login : Form
    {
        Thread t1;
        public Frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           if (txt_user.Text=="FELIPE" && txt_password.Text== "lipelipe")
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
        private void abrirJanela(object obj)
        {
            Application.Run(new Frm_main());
        }
    }
}
