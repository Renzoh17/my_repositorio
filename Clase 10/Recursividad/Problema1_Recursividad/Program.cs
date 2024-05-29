using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1_Recursividad
{
    internal class Program
    {
        static public int fibonnaci(int n, int a, int b, int f)
        {
            Console.WriteLine(f);
            if (n == 0)
            {
                return 0;
            }
          
            return fibonnaci(n - 1, a = b, b = f, f = a + b);
        }
        static void Main(string[] args)
        {
            int n = 10;
            int a = 0; int b = 1; int f = 0;

            fibonnaci(n, a, b, f);

        }
    }
}
