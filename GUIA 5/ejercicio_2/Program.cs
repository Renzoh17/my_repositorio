using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=1, f=0;
            Console.WriteLine("ingresa un numero");
            int num= Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < num; i++) {
                Console.WriteLine(f);
                a = b;
                b= f;
                f= a+b;  
            }
            Console.ReadKey();
        }
    }
}
