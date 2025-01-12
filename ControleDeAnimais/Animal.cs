using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
	//Cria o tipo de dados enum
	public enum TipoAnimal {Cachorro, Gato, Peixe};
    public class Animal
    {
        public Animal()
        {
			this.Nome = "";
			this.Tipo = TipoAnimal.Peixe;
        }

        public Animal(String nome, TipoAnimal tipo)
        {
			this.Nome = nome;
			this.Tipo = tipo;
        }
        private String nome;

		public String Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}
		private TipoAnimal tipo;

		public TipoAnimal Tipo
		{//Valores definidos pelo dev: Gato, Cachorro e Peixe
			get { return tipo; }
			set { tipo = value; }
		}
	}
}
