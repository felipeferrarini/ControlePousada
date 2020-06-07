using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WindowsFormsApp1
{
    static class Program
    {
        public static string pathReserva = Directory.GetCurrentDirectory() + "\\Banco de dados\\baseReserva.txt";
        public static string pathClient = Directory.GetCurrentDirectory() + "\\Banco de dados\\baseClientes.txt";
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Banco de dados"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Banco de dados\\");
            }
            if (!File.Exists(pathReserva))
            {
                StreamWriter x;
                x = File.CreateText(pathReserva);
                x.Close();
            }
            if (!File.Exists(pathClient))
            {
                StreamWriter x;
                x = File.CreateText(pathClient);
                x.Close();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_login());
        }
    }
}
