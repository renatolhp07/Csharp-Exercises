using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    public class Mensagem
    {
        //        private String TextoMensagem;
        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }
        //        {
        //            Console.WriteLine(this.TextoMensagem);
        //        }
        //        public String getTextoMensagem()
        //        {
        //            return this.TextoMensagem;
        //        }
        //        public void setTextoMensagem(String valor)
        //        {
        //            this.TextoMensagem = valor;
        //        }
        private String textoMensagem;
        public String TextoMensagem
        {
            get
            {
                return this.textoMensagem;
            }
            set
            {
                this.textoMensagem = value;
            }   
        }
    }
}