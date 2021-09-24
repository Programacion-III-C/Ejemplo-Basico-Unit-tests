using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Numeros
    {
        public int numero1;
        public int numero2;

        public int Sumar()
        {
            return numero1 + numero2;
        }

        public int RetornarMayor()
        {
            if (numero1 > numero2)
                return numero1;
            else
                return numero2;
        }
    }
}
