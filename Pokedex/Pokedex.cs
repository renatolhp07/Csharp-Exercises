using System.Collections.Generic;

namespace Pokedex
{
    public class Pokedex
    {
        public Pokedex() 
        {
            this.InicializaLista();
        }

        private List<Pokemon> pokemons;
        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
        }

        private void InicializaLista()
        {
            //Instanciar a lista
            this.pokemons = new List<Pokemon>();
            Pokemon p = new Pokemon("Bulbasaur", "Planta");
            this.pokemons.Add(p);

            p = new Pokemon("Growlithe", "Fogo");
            this.pokemons.Add(p);

            p = new Pokemon("Charmander", "Fogo");
            this.pokemons.Add(p);

            p = new Pokemon("Squirtle", "Água");
            this.pokemons.Add(p);

            p = new Pokemon("Caterpie", "Inseto");
            this.pokemons.Add(p);

            p = new Pokemon("Pidgeotto", "Voador");
            this.pokemons.Add(p);

            p = new Pokemon("Pikachu", "Elétrico");
            this.pokemons.Add(p);

            p = new Pokemon("Vulpix", "Fogo");
            this.pokemons.Add(p);

            p = new Pokemon("Starmie", "Água");
            this.pokemons.Add(p);

            p = new Pokemon("Vaporeon", "Água");
            this.pokemons.Add(p);
        }
    }
}
