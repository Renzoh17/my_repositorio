using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGatoAna
{
    internal class Gato
    {
        public bool tieneHambre;
        public string dueño;   
        
        public void Cazar(Raton r)
        {
            if (r.vivo && tieneHambre)
            {
                r.vivo = false;
                tieneHambre = false;
            }
        }
    }
}
