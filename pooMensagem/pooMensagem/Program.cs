using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1, msg2;
            msg1 = new Mensagem();
            msg1.TextoMensagem = "Hello World";
            msg1.ExibirMensagem();
            Console.ReadKey();

            msg2 = new Mensagem();
            msg2.TextoMensagem = "Segundo Objeto";
            msg2.ExibirMensagem();
            Console.ReadKey();

        }
    }
}
