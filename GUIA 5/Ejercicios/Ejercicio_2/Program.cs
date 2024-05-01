using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, f = 0;
            Console.Write("Ingresa la cantidad de veces que quiere mostrar Fibonacci: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fibonacci: ");
            for (int i = 0; i < num; i++)
            {
                if(i == num - 1 ) Console.WriteLine("{0} ", f);
                else Console.Write("{0}, ", f);
                a = b;
                b = f;
                f = a + b;
            }
            Console.ReadKey();
        }
    }
}
