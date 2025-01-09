using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {// Nessa primeira parte, é criado um objeto Pessoa que recebe os parâmetros "nome" e "idade"
            Console.WriteLine("Aplicativo - Maior Idade");
            Console.WriteLine("\nDigite o nome da primeira pessoa: ");
            String nome = Console.ReadLine();
            Console.WriteLine("\nDigite a idade da primeira pessoa: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Pessoa p1 = new Pessoa(nome, idade);

            Console.WriteLine("\nDigite o nome da segunda pessoa: ");
            nome = Console.ReadLine();
            Console.WriteLine("\nDigite a idade da segunda pessoa: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Pessoa p2 = new Pessoa(nome, idade);

            Console.WriteLine("\nDigite o nome da terceira pessoa: ");
            nome = Console.ReadLine();
            Console.WriteLine("\nDigite a idade da terceira pessoa: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Pessoa p3 = new Pessoa(nome, idade);

            //Usei o condicional if-else aqui mas acho que haja outras formas mais efetivas de fazer essa verificação,
            //mas isso eu vejo depois...

            if (p1.IdadePessoa > p2.IdadePessoa & p1.IdadePessoa > p3.IdadePessoa)
            {
                p1.ExibirDados();
            }
            else if (p2.IdadePessoa > p1.IdadePessoa & p2.IdadePessoa > p3.IdadePessoa)
            {
                p2.ExibirDados();
            } 
            else if (p3.IdadePessoa > p1.IdadePessoa & p3.IdadePessoa > p2.IdadePessoa)
            {
                p3.ExibirDados();
            }
            else
            {
                    Console.WriteLine("As três pessoas têm a mesma idade");
                    Console.ReadKey();
            }
        }
            
    }
}
