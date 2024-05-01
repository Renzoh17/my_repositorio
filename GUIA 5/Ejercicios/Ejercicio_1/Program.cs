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
            string nombre, nomMayor, nomMenor;
            float monto, montoMenor, montoMayor;
            Console.Write("Ingrese el nombre del apostador: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese monto del apostador (Ingrese un numero menor a 0 para finalizar): ");
            monto = Convert.ToSingle(Console.ReadLine());
            montoMayor = monto;
            montoMenor = monto;
            nomMayor = nombre;
            nomMenor = nombre;
            while (monto > 0)
            {
                if (monto < montoMenor)
                {
                    montoMenor = monto;
                    nomMenor = nombre;
                }
                if (monto > montoMayor)
                {
                    montoMayor = monto;
                    nomMayor = nombre;
                }
                Console.Write("Ingrese el nombre del apostador: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese monto del apostador (Ingrese un numero menor a 0 para finalizar): ");
                monto = Convert.ToSingle(Console.ReadLine());
            }
            if (montoMayor < 0 && montoMenor < 0) Console.WriteLine("No se ingresaron montos"); 
            else
            {
                Console.WriteLine("El monto MAYOR es de {1} con {0}", montoMayor, nomMayor);
                Console.WriteLine("El monto MENOR es de {1} con {0}", montoMenor, nomMenor);
            }
            Console.ReadKey();
        }
    }
}
