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
            Console.Write("Ingrese la cantidad de alumnos: ");
            cantAlumnos = Convert.ToInt32(Console.ReadLine());

            Console.Write("\tAlumno [1] \nIngrese el numero de Libreta: ");
            numLibreta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el nombre: ");
            nombre = Convert.ToString(Console.ReadLine());
            Console.Write("Ingrese el promedio: ");
            promedio = Convert.ToSingle(Console.ReadLine());
            
            numLibretaMayorP = numLibreta;
            numLibretaMenorP = numLibreta;
            alumnoMayorProm = nombre;
            alumnoMenorProm = nombre;
            mayorPromedio = promedio;
            menorPromedio = promedio;


            for (i = 0; i < cantAlumnos - 1; i++)
            {
                Console.Write("\tAlumno [{0}] \nIngrese el numero de Libreta: ", i + 2);
                numLibreta = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el nombre: ");
                nombre = Convert.ToString(Console.ReadLine());
                Console.Write("Ingrese el promedio: ");
                promedio = Convert.ToSingle(Console.ReadLine());

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

            Console.WriteLine("Alumno con MAYOR Promedio \n \tNombre: {0}\n \tPromedio: {1}\n \tNumero de Libreta: {2}", alumnoMayorProm, mayorPromedio, numLibretaMayorP);
            Console.WriteLine("Alumno con MENOR Promedio \n \tNombre: {0}\n \tPromedio: {1}\n \tNumero de Libreta: {2}", alumnoMenorProm, menorPromedio, numLibretaMenorP);


            Console.ReadKey();
        }
    }
}
