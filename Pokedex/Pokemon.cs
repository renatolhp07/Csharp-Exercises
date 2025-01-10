using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Pokemon
    {
		public Pokemon(String nomePokemon, String descPokemon)
			{
				this.Nome = nomePokemon;
				this.Descricao = descPokemon;
			}

		private String nome;

		public String Nome
		{
			get { return this.nome; }
			set { this.nome = value; }
		}

		private String descricao;

		public String Descricao
		{
			get { return this.descricao; }
			set { this.descricao = value; }
		}

		public void ExibirDados()
		{
			Console.WriteLine("\nPokémon: " + this.nome);
			Console.WriteLine("Tipo: " + this.descricao);
			Console.ReadKey();
		}
	}
}
