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
    class financeiro
    {        
        public static double[] valorMedioMensal(int ano)
        {
            double[] valor = { 0, 0, 0 };

            string[] bd = File.ReadAllLines(Program.pathReserva);

            foreach (var element in bd)
            {
                reserva dados = new reserva(element.Split(';'));
                if (dados.DataEntrada.Year == ano)
                {
                    if (dados.Pago)
                    {
                        valor[0] = valor[0] + dados.Valor;
                    }
                    else
                    {
                        valor[1] = valor[1] + dados.Valor;
                    }
                    valor[2] = valor[2] + dados.Valor;
                }
            }

            valor[0] = valor[0] / 12;
            valor[1] = valor[1] / 12;
            valor[2] = valor[2] / 12;

            return valor;
        }

        public static double[] ValorMensal(int mes, int ano)
        {
            double[] valor = { 0, 0 };

            string[] bd = File.ReadAllLines(Program.pathReserva);

            foreach(var element in bd)
            {
                reserva dados = new reserva(element.Split(';'));

                if(dados.DataEntrada.Month == mes && dados.DataEntrada.Year == ano)
                {
                    if (dados.Pago)
                    {
                        valor[0] = valor[0] + dados.Valor;
                    }
                    else
                    {
                        valor[1] = valor[1] + dados.Valor;
                    }
                }

            }

            return valor;
        }

        //criar outra com o valor a receber no mes informado

        //criar outras duas com a mesma logiva para o ano informado

        //criar outras duas para o periodo informado (00/00/00 a 00/00/00)

        //
    }
}
