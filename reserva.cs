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
        protected int qtdPessoas;
        protected bool feriado;
        protected string feriadoTipo;
        protected double desconto;
        protected double valor;
        protected bool confirmacao;

        ///Construto vazio (Para nova reserva)
        public reserva()
        {

        }
        ///Construtor com todos os atributos (para consulta)
        public reserva(int numero, string cliente, string clienteNome, string telefone, string cidade, 
            string email, DateTime dataEntrada, DateTime dataSaida, bool confirmacao, int qtdPessoas, 
            bool feriado, string feriadoTipo, double desconto, double valor)
        {
            this.numero = numero;
            this.cliente = cliente;
            this.clienteNome = clienteNome;
            this.telefone = telefone;
            this.cidade = cidade;
            this.email = email;
            this.dataEntrada = dataEntrada;
            this.dataSaida = dataSaida;
            this.qtdPessoas = qtdPessoas;
            this.feriado = feriado;
            this.feriadoTipo = feriadoTipo;
            this.desconto = desconto;
            this.valor = valor;
            this.confirmacao = confirmacao;
        }
        ///Gets e sets
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
        public int QtdPessoas
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
        public bool Confirmacao
        {
            get { return confirmacao; }
            set { confirmacao = value; }
        }
        public double Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
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

            return true;
        }

    }
}
