using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimosConMetodos
{
    internal class Program
    {
        static bool VerificarPrimo(int num)
        {
            int divisivilidad = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0) divisivilidad++;
            }
            if (divisivilidad <= 2) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            int desde, hasta, i;
            Console.WriteLine("Ingrese el intervalo desde: ");
            desde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el intervalo hasta: ");
            hasta = Convert.ToInt32(Console.ReadLine());
            for (i = desde; i <= hasta; i++)
            {
                if (VerificarPrimo(i)) Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
