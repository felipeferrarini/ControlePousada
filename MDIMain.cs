using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using ControlePousada;

namespace controlePousada
{
    public partial class MDIMain : Form
    {
        ///Parametros para mover a janela
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public MDIMain()
        {
            InitializeComponent();
        }

        //Funções de controle da janela
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void panelForms_ControlRemoved(object sender, ControlEventArgs e)
        {
            btn_novaReserva.Enabled = true;
            btn_reserva.Enabled = true;
            btn_financeiro.Enabled = true;
            btn_newCliente.Enabled = true;
            btn_cliente.Enabled = true;
            btn_config.Enabled = true;
            btn_inicio.Enabled = true;

            if (panelMenu.Controls.Count == 0)
            {
                AbrirFormNoPanel(new Frm_inicio());
            }
        }

        ///Função para abrir outros forms no panel do form principal (MDIMain)
        private void AbrirFormNoPanel(object janelas)
        {
            if (panelForms.Controls.Count > 0)
            {
                panelForms.Controls.RemoveAt(0);
            }
            Form janela = janelas as Form;
            janela.TopLevel = false;
            janela.FormBorderStyle = FormBorderStyle.None;
            janela.Dock = DockStyle.Fill;
            panelForms.Controls.Add(janela);
            panelForms.Tag = janela;
            janela.Show();
                        
        }
        private void escondePanelMenu()
        {
            if (panelMenu.Width == 242)
            {
                for (int i = 242; i >= 50; i = i - 24)
                {

                    panelMenu.Width = i;
                }
            }
        }

        private void btn_novaReserva_Click(object sender, EventArgs e)
        {
            escondePanelMenu();
            AbrirFormNoPanel(new Frm_reservaCriar());
            btn_cliente.Enabled = false;
            btn_config.Enabled = false;
            btn_newCliente.Enabled = false;
            btn_reserva.Enabled = false;
            btn_financeiro.Enabled = false;
            btn_inicio.Enabled = false;
        }

        private void btn_newCliente_Click(object sender, EventArgs e)
        {
            escondePanelMenu();
            AbrirFormNoPanel(new Frm_clienteCriar());
            btn_cliente.Enabled = false;
            btn_config.Enabled = false;
            btn_novaReserva.Enabled = false;
            btn_reserva.Enabled = false;
            btn_financeiro.Enabled = false;
            btn_inicio.Enabled = false;
        }

        private void btn_reserva_Click(object sender, EventArgs e)
        {
            escondePanelMenu();
            AbrirFormNoPanel(new Frm_reservaConsulta());
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            escondePanelMenu();
            AbrirFormNoPanel(new Frm_clienteConsulta());
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if(panelMenu.Width == 242)
            {
                for (int i = 242; i >= 50; i = i - 24)
                {

                    panelMenu.Width = i;
                    
                }
            }
            else
            {
                for (int i = 50; i < 243; i = i + 24)
                {

                    panelMenu.Width = i;
                }
            }
        }

        private void btn_newCliente_MouseHover(object sender, EventArgs e)
        {
            if (panelMenu.Width != 242)
            {
                for (int i = 50; i < 243; i = i + 24)
                {
                    panelMenu.Width = i;
                }
            }
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new Frm_inicio());
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new Frm_inicio());
            if (panelMenu.Width == 242)
            {
                for (int i = 242; i >= 50; i = i - 24)
                {
                    panelMenu.Width = i;
                }
            }
        }

        private void btn_financeiro_Click(object sender, EventArgs e)
        {
            escondePanelMenu();
            AbrirFormNoPanel(new Frm_financeiro());
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            escondePanelMenu();
            AbrirFormNoPanel(new Frm_config());
        }
    }
}
