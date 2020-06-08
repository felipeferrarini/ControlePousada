using System;
using System.Collections.Generic;
using System.Linq;
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
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    class cliente
    {
        ///Atributos
        protected string tipo;
        protected string nome;
        protected string telefone;
        protected string email;
        protected string endereço;
        protected string bairro;
        protected string cidade;
        protected string estado;


        ///Construtor Vazio
        public cliente()
        {

        }

        ///Funções publicas
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Endereço
        {
            get { return endereço; }
            set { endereço = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        ///Funções estaticas
        public static bool clienteExiste (string documento)
        {
            string[] bd = File.ReadAllLines(Program.pathClient);
            foreach(var elemento in bd)
            {
                string[] linha = elemento.Split(';');
                foreach (var element in linha)
                {
                    if (element == documento)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static string[] retornaAtributos(string doc)
        {
            string[] bd = File.ReadAllLines(Program.pathClient);
            foreach (var element in bd)
            {
                string[] line = element.Split(';');
                if (line[1] == doc)
                {
                    return line;
                }
            }
            string[] erro = { "err" };
            return erro;
        }
    }
    class clienteCpf : cliente
    {
        ///Atributos
        protected string documento;

        public clienteCpf()
        {

        }
        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public static bool salvarCliente(clienteCpf cliente)
        {
            StreamWriter bdW;
            bdW = File.AppendText(Program.pathClient);
            bdW.Write(cliente.documento);
            bdW.Write(";");
            bdW.Write(cliente.tipo);
            bdW.Write(";");
            bdW.Write(cliente.nome);
            bdW.Write(";");
            bdW.Write(cliente.telefone);
            bdW.Write(";");
            bdW.Write(cliente.email);
            bdW.Write(";");
            bdW.Write(cliente.endereço);
            bdW.Write(";");
            bdW.Write(cliente.bairro);
            bdW.Write(";");
            bdW.Write(cliente.cidade);
            bdW.Write(";");
            bdW.WriteLine(cliente.estado);
            return true;
        }
    }
    class clienteCnpj : cliente 
    {
        ///Atributos
        protected string documento;
        protected string razaoSocial;
        protected decimal desconto;

        public clienteCnpj()
        {

        }

        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }
        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }
        public decimal Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }

        public static bool salvarCliente(clienteCnpj cliente)
        {
            StreamWriter bdW;
            bdW = File.AppendText(Program.pathClient);
            bdW.Write(cliente.documento);
            bdW.Write(";");
            bdW.Write(cliente.tipo);
            bdW.Write(";");
            bdW.Write(cliente.nome);
            bdW.Write(";");
            bdW.Write(cliente.telefone);
            bdW.Write(";");
            bdW.Write(cliente.email);
            bdW.Write(";");
            bdW.Write(cliente.endereço);
            bdW.Write(";");
            bdW.Write(cliente.bairro);
            bdW.Write(";");
            bdW.Write(cliente.cidade);
            bdW.Write(";");
            bdW.Write(cliente.estado);
            bdW.Write(";");
            bdW.Write(cliente.razaoSocial);
            bdW.Write(";");
            bdW.WriteLine(cliente.desconto);
            return true;
        }
    }
}
