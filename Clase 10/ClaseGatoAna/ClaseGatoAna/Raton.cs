using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGatoAna
{
    internal class Raton
    {
        public bool vivo;
        public bool tieneHambre;
        public void Comer(ref int queso)
        {
            if (vivo)
            {
                if (queso >= 2)
                {
                    tieneHambre = false;
                    queso -= 2;
                }
                else
                {
                    if (queso == 1)
                    {
                        queso -= 1;
                    }
                }
            }
        }
        public string VerEstado()
        {
            string resultado = "";
            if (vivo) resultado += "Vivo: Si";
            else resultado += "Vivo: No";
            return resultado;
        }
    }
}
