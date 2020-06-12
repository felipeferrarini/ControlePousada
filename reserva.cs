using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
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

namespace ControlePousada
{
    class reserva
    {
        ///Atributos
        protected int numero;
        protected string cliente;
        protected string clienteNome;
        protected string telefone;
        protected string cidade;
        protected string email;
        protected DateTime dataEntrada;
        protected DateTime dataSaida;
        protected decimal qtdPessoas;
        protected bool feriado;
        protected string feriadoTipo;
        protected decimal desconto;
        protected double valor;
        protected bool pago;
        protected DateTime dataPago;

        ///Construto vazio (Para nova reserva)
        public reserva()
        {

        }
        ///Construtor com todos os atributos (para consulta)
        public reserva(string[] dados)
        {
            Numero = Convert.ToInt32(dados[0]);
            Cliente = dados[1];
            ClienteNome = dados[2];
            Telefone = dados[3];
            Cidade = dados[4];
            Email = dados[5];
            DataEntrada = DateTime.Parse(dados[6]);
            DataSaida = DateTime.Parse(dados[7]);
            QtdPessoas = Convert.ToInt32(dados[8]);
            Feriado = bool.Parse(dados[9]);
            FeriadoTipo = dados[10];
            Desconto = Convert.ToDecimal(dados[11]);
            Valor = Convert.ToInt32(dados[12]);
            Pago = bool.Parse(dados[13]);
            DataPago = DateTime.Parse(dados[14]);
        }
        ///Gets e sets
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public string ClienteNome
        {
            get { return clienteNome; }
            set { clienteNome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public DateTime DataEntrada
        {
            get { return dataEntrada; }
            set { dataEntrada = value; }
        }
        public DateTime DataSaida
        {
            get { return dataSaida; }
            set { dataSaida = value; }
        }
        public decimal QtdPessoas
        {
            get { return qtdPessoas; }
            set { qtdPessoas = value; }
        }
        public bool Feriado
        {
            get { return feriado; }
            set { feriado = value; }
        }
        public string FeriadoTipo
        {
            get { return feriadoTipo; }
            set { feriadoTipo = value; }
        }
        public bool Pago
        {
            get { return pago; }
            set { pago = value; }
        }
        public decimal Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public DateTime DataPago
        {
            get { return dataPago; }
            set { dataPago = value; }
        }

        ///Funções Staticas
        public static int getNextNumber (string path)
        {
            int nextNumber = File.ReadLines(path).Count();
            nextNumber++;
            return nextNumber;
        }
        public static bool salvarReserva (reserva dados)
        {
            StreamWriter bdW;
            bdW = File.AppendText(Program.pathReserva);
            bdW.Write(dados.Numero);
            bdW.Write(";");
            bdW.Write(dados.Cliente);
            bdW.Write(";");
            bdW.Write(dados.ClienteNome);
            bdW.Write(";");
            bdW.Write(dados.Telefone);
            bdW.Write(";");
            bdW.Write(dados.Cidade);
            bdW.Write(";");
            bdW.Write(dados.Email);
            bdW.Write(";");
            bdW.Write(dados.DataEntrada);
            bdW.Write(";");
            bdW.Write(dados.DataSaida);
            bdW.Write(";");
            bdW.Write(dados.QtdPessoas);
            bdW.Write(";");
            bdW.Write(dados.Feriado);
            bdW.Write(";");
            bdW.Write(dados.FeriadoTipo);
            bdW.Write(";");
            bdW.Write(dados.Desconto);
            bdW.Write(";");
            bdW.Write(dados.Valor);
            bdW.Write(";");
            bdW.Write(dados.Pago);
            bdW.Write(";");
            bdW.WriteLine(dados.DataPago);
            bdW.Close();
            return true;
        }

        public static string[] retornaReserva(int numero)
        {
            string[] bd = File.ReadAllLines(Program.pathReserva);
            foreach (var element in bd)
            {
                string[] line = element.Split(';');
                if (line[0] == numero.ToString())
                {
                    return line;
                }
            }
            string[] erro = { "erro" };
            return erro;
        }

    }
}
