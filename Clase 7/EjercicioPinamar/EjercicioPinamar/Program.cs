using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPinamar
{
    internal class Program
    {
        static double recaudacion = 0;
        static double cantidadaccesos;
        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("\tMenu\n1-Registrar acceso\n2-Mostrar Recaudación\n3-Mostrar Cantidad de accesos");
        }
        static void MostrarMenuTicket()
        {
            Console.Clear();
            Console.WriteLine("Ingrese tipo de Vehiculo:\n1-Sin Vehiculo\n2-Moto\n3-Auto\n4-Camioneta\n5-Bugy\n6-Vehiculo Nautico");
        }
        static bool VerificarOpcion(int op)
        {
            switch (op)
            {
                case 1:
                    RegistrarAcceso();
                    break;
                case 2:
                    MostrarRecaudacion();
                    break;
                case 3:
                    MostrarInformeCaja();
                    break;
                case -1:
                    return false;
                default:
                    Console.WriteLine("Opcion Incorrecta, para salir ingrese -1");
                    break;
            }
            return true;
        }
        static void RegistrarAcceso()
        {
            char ticket;
            do
            {
            Console.WriteLine("Tiene ticket? (S/N)");
            ticket = Convert.ToChar(Console.ReadLine());
            } while (ticket != 'S' && ticket != 's' && ticket != 'N' && ticket != 'n');
            if (ticket == 'N' || ticket == 'n')
            {
                GenerarTicket();
            }
            else
            {
                cantidadaccesos++;
            }
        }
        static void MostrarRecaudacion()
        {
            Console.WriteLine("La recaudacion es: {0}", recaudacion);
            Console.ReadKey();
        }
        static void MostrarInformeCaja()
        {
            Console.WriteLine("La cantidad de accesos es: {0}", cantidadaccesos);
            Console.ReadKey();
        }
        static void GenerarTicket()
        {
            bool continuar = true;
            int op;
            int montoBruto = 0, dias, porcenjate = 0,impuestos21, montofinal;
            int cantidad;
            Console.WriteLine("\tNuevo Ticket\nIngrese el tipo de vehiculo");
            MostrarMenuTicket();
            op = Convert.ToInt32(Console.ReadLine());
            while (continuar)
            {
                switch (op)
                {
                    case 1:
                        Console.Write("Cantidad: ");
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        montoBruto += 100 * cantidad;
                        break;
                    case 2:
                        Console.Write("Cantidad: ");
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        montoBruto += 800 * cantidad;
                        break;
                    case 3:
                        Console.Write("Cantidad: ");
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        montoBruto += 1000 * cantidad;
                        break;
                    case 4:
                        Console.Write("Cantidad: ");
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        montoBruto += 1500 * cantidad;
                        break;
                    case 5:
                        Console.Write("Cantidad: ");
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        montoBruto += 5000 * cantidad;
                        break;
                    case 6:
                        Console.Write("Cantidad: ");
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        montoBruto += 1200 * cantidad;
                        break;
                    case -1:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta, ingrese nuevamente una opcion valida");
                        break;
                }
                if (op != -1)
                {
                    Console.WriteLine("Desea ingresar otro vehiculo? (-1 para finalizar)");
                    op = Convert.ToInt32(Console.ReadLine());
                }
            }
            do {
            Console.WriteLine("Cuantos dias solicita?");
            dias = Convert.ToInt32(Console.ReadLine());
            switch (dias)
            {
                case 1:
                    porcenjate = 100;
                    break;
                case 2:
                    porcenjate = 120;
                    break;
                case 3:
                    porcenjate = 220;
                    break;
                case 4:
                    porcenjate = 320;
                    break;
                case 5: case 6: case 7: case 8: case 9: case 10:
                    porcenjate = 380;
                    break;
                default:
                    Console.WriteLine("Ingrese un dia correcto");
                    break;
            }
        }while(dias <= 1 && dias >= 10 );
            impuestos21 = (montoBruto * porcenjate / 100) * 121 / 100;
            montofinal = impuestos21 * 115 / 100;
            recaudacion += montofinal;
            MostrarTicket(montofinal);
        }
        static void MostrarTicket(int montofinal)
        {
            Console.WriteLine("Monto Final de Ticket generado: {0}", montofinal);
            cantidadaccesos++;
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            bool continuar = true;
            int o;
            MostrarMenu();
            o = Convert.ToInt32(Console.ReadLine());
            while (continuar)
            {
                continuar = VerificarOpcion(o);
                MostrarMenu();
                o = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
