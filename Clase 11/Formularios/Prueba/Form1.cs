using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        int[] listnum = new int[100];
        int cont = 0;
        float acum = 0;
        float prom;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarNum_Click(object sender, EventArgs e)
        {
            listnum[cont] = Convert.ToInt32(tbIngresarNum.Text);
            cont++;
            tbIngresarNum.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lbProm.Text = "Promedio: ";
            for (int i = 0; i < cont; i++)
            {
                acum += listnum[i];
            }
            if (acum != 0)
            {
            prom = acum / cont;
            acum = 0;
            lbProm.Text += $"{prom:f2}";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbSecuencial.Checked == true){
                BusquedaSecuencial(tbBusqueda.Text);
            }
            if (rbBinaria.Checked == true)
            {
                BusquedaBinaria(tbBusqueda.Text);
            }
            else
            {
                MessageBox.Show("Seleccione un metodo de busqueda");
            }
        }

        private void BusquedaSecuencial(string tbBus)
        {
            bool encontrado = false; ;
            for (int i = 0; i < cont; i++)
            {
                if (listnum[i] == Convert.ToInt32(tbBus)) encontrado = true;
            }
            if (encontrado) MessageBox.Show("Valor Encontrado");
            else MessageBox.Show("Valor No Encontrado");
        }

        private void BusquedaBinaria(string tbBusq)
        {
            int pivot = 0, minl = 0, maxl = cont;
            bool encontrado = false;
            OrdenamientoBurbuja();
            while (minl <= maxl && !encontrado)
            {
                pivot = (minl + maxl) / 2;
                if (listnum[pivot] == Convert.ToInt32(tbBusq))
                {
                    encontrado = true;
                }
                if (listnum[pivot] > Convert.ToInt32(tbBusq))
                {
                    maxl = pivot - 1;
                }
                else
                {
                    minl = pivot + 1;
                }
            }
            if (!encontrado)
            {
                MessageBox.Show("Valor No encontrado");
            }
            else
            {
                MessageBox.Show("Valor Encontrado");
            }
        }

        private void OrdenamientoBurbuja()
        {
            int aux;
            for(int i = 0; i < cont; i++)
            {
                for(int j = i + 1; j < cont; j++)
                {
                    if (listnum[i] > listnum[j])
                    {
                        aux = listnum[i];
                        listnum[i] = listnum[j];
                        listnum[j] = aux;
                    }
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            OrdenamientoBurbuja();
            listBox1.Items.Clear();
            for(int i = 0; i < cont; i++)
            {
                listBox1.Items.Add(listnum[i]);
            }
        }
    }
}
