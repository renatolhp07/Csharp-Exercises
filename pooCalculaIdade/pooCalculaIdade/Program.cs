using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular a idade de uma pessoa");
            Pessoa p = new Pessoa();
            Console.Write("Digite o nome da pessoa: ");
            p.Nome = Console.ReadLine();
            Console.Write("Digite o ano de nascimento da pessoa: ");
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine());
            p.ExibirDados();
            Console.ReadKey();
        }
    }
}
