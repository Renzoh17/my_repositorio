using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_Numeros_Primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,i;
            int divisivilidad = 0;
            Console.WriteLine("Ingrese un numero para verificar si es primo o no");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < num; i++)
            {
                if (num % i == 0) divisivilidad++;
            }
            if (divisivilidad <= 2) Console.WriteLine("Es primo");
            else Console.WriteLine("No es primo");
            Console.ReadKey();
        }
    }
}
