using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class ValorMuitoBaixoException : Exception
    {
        public ValorMuitoBaixoException() : base()
        {

        }

        public ValorMuitoBaixoException(string mensagem) : base(mensagem)
        {

        }
    
    }
}
