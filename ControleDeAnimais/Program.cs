using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{//Algoritmo deve receber dados sobre animais (nome e tipo) e somar a quantidade total de cada tipo de animal.
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal a2 = new Animal();
            //Animal a3 = new Animal();
            //Animal a4 = new Animal();
            //Animal a5= new Animal();
            int t1 = 0, t2 =0, t3 = 0;
            int tL = 0;
            Animal[] animais = new Animal[20];
            int tipoAnimal = 0;

            Console.WriteLine("Controle de Animais");
            //Leitura da quantidade de animais
            try
            {
                Console.Write("Quantos animais deseja informar? (máximo 20) ");
                tL = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                tL = 0;
            }
            for (int i = 0; i < tL; i++)
            {
                Animal a1 = new Animal();
                Console.Write("\nInforme o nome do " + (i+1) + "º animal: ");
                a1.Nome = Console.ReadLine();
                Console.Write("\nInforme o tipo do " + (i + 1) + "º animal (Cachorro (0) - Gato (1) - Peixe (2)): ");

                try
                {
                    tipoAnimal = Convert.ToInt32(Console.ReadLine());
                    if (tipoAnimal < 0 || tipoAnimal > 2) tipoAnimal = 2;
                }
                catch
                {
                    tipoAnimal = 2;
                }
                a1.Tipo = (TipoAnimal)tipoAnimal;
                //Contando tipo informado
                if (a1.Tipo == TipoAnimal.Cachorro) t1++;
                if (a1.Tipo == TipoAnimal.Gato) t2++;
                if (a1.Tipo == TipoAnimal.Peixe) t3++;
                //Armazenar animal no vetor
                animais[i] = a1;
            }
            //if (tipoAnimal == 0) a1.Tipo = TipoAnimal.Cachorro;
            //if (tipoAnimal == 1) a1.Tipo = TipoAnimal.Gato;
            //if (tipoAnimal == 2) a1.Tipo = TipoAnimal.Peixe;
            

            //Console.WriteLine("Informe o nome do 2º animal: ");
            //a2.Nome = Console.ReadLine();
            //Console.WriteLine("Informe o tipo do 2º animal: (Cachorro - Gato - Peixe)");
            //a2.Tipo = Console.ReadLine();
            //if (a2.Tipo == "Cachorro") t1++;
            //if (a2.Tipo == "Gato") t2++;
            //if (a2.Tipo == "Peixe") t3++;

            //Console.WriteLine("Informe o nome do 3º animal: ");
            //a3.Nome = Console.ReadLine();
            //Console.WriteLine("Informe o tipo do 3º animal: (Cachorro - Gato - Peixe)");
            //a3.Tipo = Console.ReadLine();
            //if (a3.Tipo == "Cachorro") t1++;
            //if (a3.Tipo == "Gato") t2++;
            //if (a3.Tipo == "Peixe") t3++;

            //Console.WriteLine("Informe o nome do 4º animal: ");
            //a4.Nome = Console.ReadLine();
            //Console.WriteLine("Informe o tipo do 4º animal: (Cachorro - Gato - Peixe)");
            //a4.Tipo = Console.ReadLine();
            //if (a4.Tipo == "Cachorro") t1++;
            //if (a4.Tipo == "Gato") t2++;
            //if (a4.Tipo == "Peixe") t3++;

            //Console.WriteLine("Informe o nome do 5º animal: ");
            //a5.Nome = Console.ReadLine();
            //Console.WriteLine("Informe o tipo do 5º animal: (Cachorro - Gato - Peixe)");
            //a5.Tipo = Console.ReadLine();
            //if (a5.Tipo == "Cachorro") t1++;
            //if (a5.Tipo == "Gato") t2++;
            //if (a5.Tipo == "Peixe") t3++;

            //Array.ForEach(animais, Console.WriteLine);

            Console.WriteLine("\nA quantidade de cachorros é: " + t1);
            Console.WriteLine("A quantidade de gatos é: " + t2);
            Console.WriteLine("A quantidade de peixes é: " + t3);
            Console.ReadKey();

            Console.WriteLine("\nAnimais Cadastrados:");

            for (int i = 0; i < tL; i++)
            {
                Console.WriteLine($"{animais[i].Nome}");
                Console.WriteLine($"{animais[i].Tipo}\n");
                Console.ReadKey();
            }
        }
    }
}
