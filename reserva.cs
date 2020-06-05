using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
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
        protected bool confirmacao;
    }
}
