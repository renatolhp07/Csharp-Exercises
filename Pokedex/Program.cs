using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pokédex - Sua enciclopédia Pokémon\n=========================================");
            Pokedex pokedex = new Pokedex();
            Pokemon p = pokedex.Pokemons[1];
            p.ExibirDados();
        }
    }
}
