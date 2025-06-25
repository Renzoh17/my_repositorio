using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Servicio
    {
        int[] expedientes = new int[100];
        int[] DNIs = new int[100];
        double[] montos = new double[100];
        int cont = 0;
        

        //metodos 

        public void RegistrarEx(int ex, int dni, double monto)
        {
            expedientes[cont] = ex;
            DNIs[cont] = dni;
            montos[cont] = monto;
            cont++;
        }

        public void VerEx(int idx, out int nro, out double monto)
        {
            nro = DNIs[idx];
            monto = montos[idx];
        }

        public void OrdenarEx()//ordenamiento con metodo burbuja.
        {
            int aux1 = 0;
            int aux2 = 0;
            double aux3 = 0;

            for(int i = 0; i < cont - 1; i++)
            {
                for(int j = i+1; i < cont; i++)
                {
                    if (expedientes[i] > expedientes[j])
                    {
                        aux1 = expedientes[i];
                        expedientes[i] = expedientes[j];
                        expedientes[j] = aux1;

                        aux2 = DNIs[i];
                        DNIs[i] = DNIs[j];
                        DNIs[j] = aux2;

                        aux3 = montos[i];
                        montos[i] = montos[j];
                        montos[j] = aux3;
                    }
                }
            }
        }

        public double CalcularMontoProm()//el promedio de todos los montos.
        {
            double prom = 0;
            double acum = 0;
            for(int i = 0; i < cont; i++)
            {
                acum += montos[i];
            }
            prom = acum/cont;

            return prom;
        }

        public int[] MayoresAlProm(out int cantidad)
        {
            cantidad = 0;
            int[] mayP = new int[cont];
            double prom = CalcularMontoProm();
            for (int i = 0; i < cont; i++)
            {
                if (montos[i] > prom)
                {
                    mayP[cantidad++] = expedientes[i];
                }
            }
            return mayP;
        }

        public int VerCont()
        {
            return cont;
        }

        public int[] VerExpPorDNI(int dni, out int cantidad)
        {
            int[] expDni = new int[cont];
            cantidad = 0;
            for(int i = 0; i < cont; i++)
            {
                if (DNIs[i] == dni)
                {
                    expDni[cantidad++] = expedientes[i];
                }
                
            }
            return expDni;
        }

        public int VerExPorNum(int numero)
        {
            int c = VerCont();
            int n = 0;
            for (int i = 0; i < c; i++)
            {
                if (expedientes[i] == numero) n = expedientes[i];
            }
            return n;
        }
    }
}
