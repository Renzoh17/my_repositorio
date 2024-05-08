using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAulaParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantZonas, i, idMedidor, descuento, contDomiciliosPorZona, contDomiciliosTotal,contDescuentos100;
            float estadoMedidor, estadoMedidorAnterior, M2Suministrados,montoBruto, montoConsumido, montoDescuento;
            float AcumRecTotalPorZona, AcumRecTotal,AcumDescuentos100, AcumDescuentos8;
            bool continuar;
            descuento = 0;
            contDomiciliosTotal = 0;
            AcumRecTotal = 0;
            Console.Write("Ingrese el precio del metro Cubico: ");
            montoBruto = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese la cantidad de zonas asignadas: ");
            cantZonas = Convert.ToInt16(Console.ReadLine());
            for (i = 0; i < cantZonas; i++)
            {
                Console.WriteLine("\tZona {0}", i + 1);
                contDomiciliosPorZona = 0;
                AcumRecTotalPorZona = 0;
                contDescuentos100 = 0;
                AcumDescuentos100 = 0;
                AcumDescuentos8 = 0;
                continuar = true;
                while (continuar)
                {
                    contDomiciliosPorZona++;
                    Console.Write("ID Medidor: ");
                    idMedidor = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Estado Medidor (en M2): ");
                    estadoMedidor = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Estado Medidor Mes Anterior (en M2): ");
                    estadoMedidorAnterior = Convert.ToSingle(Console.ReadLine());
                    M2Suministrados = estadoMedidor - estadoMedidorAnterior;
                    montoConsumido = M2Suministrados * montoBruto;
                    switch (idMedidor % 10)
                    {
                        case 4: case 6: case 7: case 8: case 9:
                            descuento = 100;
                            contDescuentos100++;
                            break;
                        case 5:
                            descuento = 8;
                            break;
                        default:
                            descuento = 0;
                            break;
                    }
                    montoDescuento = montoConsumido - (montoConsumido * descuento / 100);
                    if (descuento == 100) AcumDescuentos100 += montoDescuento;
                    else if (descuento == 8) AcumDescuentos8 +=montoDescuento;
                    AcumRecTotalPorZona += montoDescuento;
                    Console.WriteLine("\nDatos ingresados Domicilio {1}\nID Medidor: {0}\nMonto Bruto (por M2): {2}\nM2 Suministrados: {3}\nMonto Consumido: {4}\nMonto Consumido (con Descuento): {5}\nPorcentaje Descuento: {6}%\nMonto Final: {5}", idMedidor, contDomiciliosPorZona, montoBruto, M2Suministrados,montoConsumido, montoDescuento, descuento);
                    Console.WriteLine("¿Desea ingresar otro domicilio? (Si = true, No = false)");
                    continuar = Convert.ToBoolean(Console.ReadLine());
                }
                Console.WriteLine("\tZona {0}\nCantidad Domicilios: {1}", i + 1, contDomiciliosPorZona);
                Console.WriteLine("Recaudacion Total: {0}", AcumRecTotalPorZona);
                Console.WriteLine("Cantidad de Descuentos del 100%: {0}", contDescuentos100);
                Console.WriteLine("Monto Descuentos del 100%: {0}\nMonto Descuentos del 8%: {1}", AcumDescuentos100, AcumDescuentos8);
                if (contDescuentos100 > contDomiciliosPorZona / 2) Console.WriteLine("Se supero la cantidad de descuentos al 100% admitida");
                contDomiciliosTotal += contDomiciliosPorZona;
                AcumRecTotal += AcumRecTotalPorZona;
            }
            Console.WriteLine("\n\tFin del Dia\nCantidad domicilios relevados: {0}", contDomiciliosTotal);
            Console.WriteLine("Recaudacion Total: {0}", AcumRecTotal);
            Console.WriteLine("Promedio de Recaudacion por Domicilio: {0}", AcumRecTotal / contDomiciliosTotal);
            Console.ReadKey();
        }
    }
}
