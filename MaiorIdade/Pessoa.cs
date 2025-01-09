using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdade
{
    internal class Pessoa
    {
		public Pessoa(String nome, int idade)
		{
			this.nomePessoa = nome;
			this.idadePessoa = idade;
		}

		private int idadePessoa;

		public int IdadePessoa
		{
			get { return this.idadePessoa; }
			set { this.idadePessoa = value; }
		}
		private String nomePessoa;

		public String NomePessoa
		{
			get { return this.nomePessoa; }
			set { this.nomePessoa = value; }
		}

		public void ExibirDados()
		{
			Console.WriteLine("\nVeja abaixo a pessoa com a maior idade: ");
			Console.WriteLine("Nome: " + this.nomePessoa);
			Console.WriteLine("Idade: " + this.idadePessoa + "\n");
			Console.ReadKey();
		}

	}
}
