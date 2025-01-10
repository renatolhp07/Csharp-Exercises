using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de área do retângulo: \n===========================================");
            Console.WriteLine("\nDigite o comprimento da base do retângulo em centímetros: ");
            int baseRetangulo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite a altura do retângulo em centímetros: ");
            int alturaRetangulo = Convert.ToInt32(Console.ReadLine());
            Retangulo r = new Retangulo();
            r.BaseRet = baseRetangulo;
            r.AlturaRet = alturaRetangulo;
            r.AreaDoRetangulo(baseRetangulo, alturaRetangulo);
        }
    }
}
