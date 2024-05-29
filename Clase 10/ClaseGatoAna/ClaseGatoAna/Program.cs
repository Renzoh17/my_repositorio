using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGatoAna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato gatoAna = new Gato();
            gatoAna.dueño = "Ana";
            gatoAna.tieneHambre = true;
            Raton raton1 = new Raton();
            raton1.vivo = true;
            raton1.tieneHambre = true;

            int quesos = 5;

            raton1.Comer(ref quesos);
            if(!raton1.tieneHambre) Console.WriteLine("El raton comio");
            else Console.WriteLine("No hay quesos para el raton");
            Console.WriteLine("Quedan {0} quesos", quesos);
            gatoAna.Cazar(raton1);
            if (!gatoAna.tieneHambre) Console.WriteLine("El gato comio al raton");
            else Console.WriteLine("No hay raton vivo");

            Console.ReadKey();
        }
    }
}
