using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generar_Numeros_Primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int desde, hasta, i;
            Console.WriteLine("Ingrese el intervalo desde: ");
            desde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el intervalo hasta: ");
            hasta = Convert.ToInt32(Console.ReadLine());
            for (i = desde; i<=hasta; i++)
            {
                int num = i, divisor;
                int divisivilidad = 0;
                for (divisor = 1; divisor < num; divisor++)
                {
                    if (num % divisor == 0) divisivilidad++;
                }
                if (divisivilidad <= 2) Console.WriteLine("{0}", num);
            } ;
            Console.ReadKey();
        }
    }
}
