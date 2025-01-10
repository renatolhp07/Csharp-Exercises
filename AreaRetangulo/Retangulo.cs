using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo
{
    public class Retangulo
    {
		private int baseRet;

		public int BaseRet
		{
			get { return baseRet; }
			set { this.baseRet = value; }
		}

		private int alturaRet;

		public int AlturaRet
		{
			get { return alturaRet; }
			set { this.alturaRet = value; }
		}
		
		public void AreaDoRetangulo(int retBase, int retAltura)
		{
			retBase = this.baseRet;
			retAltura = this.alturaRet;

			int areaRet = retBase * retAltura;
			Console.WriteLine("\nA área do retângulo é de: " + areaRet + " cm");
			Console.ReadKey();
        }
    }
}
