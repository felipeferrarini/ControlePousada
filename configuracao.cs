using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace controlePousada
{
    class configuracao
    {
        /// <summary>
        /// Regras do arquivo de configurações:
        /// Linha 1 = lista de feriados e valor base de cada (ex: Natal:2000;Reveion:3000);
        /// Linha 2 = 
        /// </summary>

        //Atributos
        protected decimal valorBase;
        protected string feriadoTipo;

        public static void configOriginal()
        {
            string[] configOriginal = { "Carnaval:3000;Páscoa:2000;Corpus Christ:2000;Natal:3000;Reveion:3000" };
            File.WriteAllLines(Program.pathConfig, configOriginal);
        }

        public static decimal ValorBase(string feriado)
        {
            string[] bd = File.ReadAllLines(Program.pathConfig);

            string[] line = bd[0].Split(';');

            foreach(var element in line)
            {
                if(element.Split(':')[0] == feriado)
                {
                    return (Convert.ToDecimal(element.Split(':')[1]));
                }
            }
            return 0;
        }

        public static string[] retornaFeriados()
        {
            string[] bd = File.ReadAllLines(Program.pathConfig);

            string[] line = bd[0].Split(';');

            int i = 0;
            string[] feriados = new string[line.Length];
            foreach(var element in line)
            {
                feriados[i] = element.Split(':')[0];
                i++;
            }

            return feriados;
        }

        public static bool editaFeriado(string feriado, decimal valorBase)
        {
            string[] bd = File.ReadAllLines(Program.pathConfig);

            string[] line = bd[0].Split(';');

            for(int i= 0; i < line.Length; i++)
            {
                string[] valor = line[i].Split(':');
                if (valor[0] == feriado)
                {
                    valor[1] = valorBase.ToString();
                    line[i] = string.Join(":", valor);
                    bd[0] = string.Join(";", line);
                    File.WriteAllLines(Program.pathConfig, bd);
                    return true;
                }
            }
            return false;
        }

        public static bool cadastraFeriado(string feriado, decimal valorBase)
        {
            string[] bd = File.ReadAllLines(Program.pathConfig);
            string[] linha = bd[0].Split(';');
            foreach (var element in linha)
            {
                if(element.Split(':')[0] == feriado)
                {
                    return false;
                }
            }
            bd[0] = bd[0] + ";" + feriado + ":" + valorBase;

            File.WriteAllLines(Program.pathConfig, bd);
            return true;
        }
    }
}
