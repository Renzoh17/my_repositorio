using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomMayor = "", nomMenor = "";
            float montoMenor=0, montoMayor=0;
            Console.WriteLine("Ingrese el nombre y el monto del apostador");
            string nom= Console.ReadLine();
            float monto= Convert.ToSingle(Console.ReadLine());
            montoMayor = monto;
            montoMenor = monto;
            nomMayor = nom;
            nomMenor= nom;
            while(monto>0)
            {
                if (monto < montoMenor)
                {
                    montoMenor= monto;
                    nomMenor=nom;
                }
                if (monto>montoMayor) 
                {
                    montoMayor= monto;
                    nomMayor= nom;
                }
                Console.WriteLine("Ingrese el nombre y el monto del apostador");
                 nom = Console.ReadLine();
                 monto = Convert.ToSingle(Console.ReadLine());
            }
            Console.WriteLine("el monto mayor es {0},{1}",montoMayor,nomMayor);
            Console.WriteLine("el monto menor es {0},{1}", montoMenor, nomMenor);
            Console.ReadKey();
        }
    }
}
