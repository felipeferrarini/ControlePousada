using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Threading;
using Microsoft.SqlServer.Server;
using System.Drawing.Printing;
using controlePousada;
using Newtonsoft.Json.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace ControlePousada
{
    class Financeiro
    {        
        public static double valorMedioMensal(int ano, bool real)
        {
            double valor = 0;

            string[] bd = File.ReadAllLines(Program.pathReserva);

            foreach (var element in bd)
            {
                reserva dados = new reserva(element.Split(';'));
                if (dados.DataEntrada.Year == ano)
                {
                    if (real)
                    {
                        if(dados.Pago)
                            valor = valor + dados.Valor;
                    }
                    else
                    {
                        valor = valor + dados.Valor;
                    }
                    
                }
            }

            valor = valor / 12;

            return valor;
        }

        public static double ValorMensal(int mes, int ano, bool real)
        {
            double valor = 0;

            string[] bd = File.ReadAllLines(Program.pathReserva);

            foreach(var element in bd)
            {
                reserva dados = new reserva(element.Split(';'));

                if(dados.DataEntrada.Month == mes && dados.DataEntrada.Year == ano)
                {
                    if (real)
                    {
                        if (dados.Pago)
                            valor = valor + dados.Valor;
                    }
                    else
                    {
                        valor = valor + dados.Valor;
                    }
                }

            }

            return valor;
        }

        public static double valorAnual(int ano, bool real)
        {
            double valor = 0;

            string[] bd = File.ReadAllLines(Program.pathReserva);

            foreach (var element in bd)
            {
                reserva dados = new reserva(element.Split(';'));

                if (dados.DataEntrada.Year == ano)
                {
                    if (real)
                    {
                        if (dados.Pago)
                            valor = valor + dados.Valor;
                    }
                    else
                    {
                        valor = valor + dados.Valor;
                    }
                }

            }

            return valor;
        }
    }
}
