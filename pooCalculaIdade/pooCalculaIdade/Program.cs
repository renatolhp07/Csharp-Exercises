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
            Console.Write("Digite o nome da pessoa: ");
            String nome = Console.ReadLine();
            Console.Write("Digite o ano de nascimento da pessoa: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Pessoa p = new Pessoa(nome, ano);
            p.ExibirDados();
            Console.ReadKey();
        }
    }
}
