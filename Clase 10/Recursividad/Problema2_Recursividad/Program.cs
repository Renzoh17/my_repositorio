using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2_Recursividad
{
    internal class Program
    {
        static public bool EsDivisible(int num, int d)
        {
            if (d > 2)
            {
                return num % d == 0 || EsDivisible(num, d - 1);
            }
            return num % 2 == 0;
        }
        static bool EsPrimo(int n)
        {
            return !EsDivisible(n, n - 1);
        }
        static void Main(string[] args)
        {
            int desde, hasta;
            Console.Write("Ingrese desde: ");
            desde = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese hasta: ");
            hasta = Convert.ToInt32(Console.ReadLine());
            for (int i = desde; i < hasta; i++)
            {
                if (EsPrimo(i)) Console.WriteLine(i);

            }

        }
    }
}
