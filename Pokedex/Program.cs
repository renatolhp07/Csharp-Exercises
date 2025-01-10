using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pokédex - Sua enciclopédia Pokémon\n=========================================");
            Console.WriteLine("Digite o nome do Pokémon: ");
            String nome = Console.ReadLine();
            Console.WriteLine("\nDigite o tipo do Pokémon: ");
            String descricao = Console.ReadLine();

            Pokemon p = new Pokemon(nome, descricao);

            p.ExibirDados();
        }
    }
}
