using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
  
        static void Main(string[] args)
        {

            int cantAlumnos, numLibreta, numLibretaMayorP, numLibretaMenorP;
            string nombre, alumnoMayorProm, alumnoMenorProm;
            float promedio, mayorPromedio, menorPromedio;
            int i;
            Console.WriteLine("Ingrese la cantidad de alumnos: ");
            cantAlumnos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el numero de Libreta [1]: ");
            numLibreta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del alumno [1]: ");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese el promedio [1]: ");
            promedio = Convert.ToSingle(Console.ReadLine());
            numLibretaMayorP = numLibreta;
            numLibretaMenorP = numLibreta;
            alumnoMayorProm = nombre;
            alumnoMenorProm = nombre;
            mayorPromedio = promedio;
            menorPromedio = promedio;


            for (i = 0; i < cantAlumnos - 1; i++)
            {
                Console.WriteLine("Ingrese el numero de Libreta [{0}]: ",i + 2);
                numLibreta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre del alumno [{0}]: ",i + 2);
                nombre = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingrese el promedio [{0}]: ", i + 2);
                promedio = Convert.ToSingle(Console.ReadLine());
                //if (i == 0)
                //{
                //    numLibretaMayorP = numLibreta;
                //    numLibretaMenorP = numLibreta;
                //    alumnoMayorProm = nombre;
                //    alumnoMenorProm = nombre;
                //    mayorPromedio = promedio;
                //    menorPromedio = promedio;
                //}

                if (mayorPromedio < promedio)
                {
                    mayorPromedio = promedio;
                    alumnoMayorProm = nombre;
                    numLibretaMayorP = numLibreta;
                }
                if (menorPromedio > promedio)
                {
                    menorPromedio = promedio;
                    alumnoMenorProm = nombre;
                    numLibretaMenorP = numLibreta;
                }

            }

            Console.WriteLine("Alumno con Mayor Promedio: {0}\n Promedio: {1}\n Numero de Libreta: {2}", alumnoMayorProm, mayorPromedio, numLibretaMayorP);
            Console.WriteLine("Alumno con Menor Promedio: {0}\n Promedio: {1}\n Numero de Libreta: {2}", alumnoMenorProm, menorPromedio, numLibretaMenorP);


            Console.ReadKey();
        }
    }
}
