using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Servicio serv = new Servicio();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarExpediente_Click(object sender, EventArgs e)
        {
            FormDatos vtnDatos = new FormDatos();
            while (vtnDatos.ShowDialog() == DialogResult.OK)
            {
                int nro = Convert.ToInt32(vtnDatos.tbNroCausa.Text);
                int dni = Convert.ToInt32(vtnDatos.tbDNI.Text);
                double monto = Convert.ToDouble(vtnDatos.tbMonto.Text);
                serv.RegistrarEx(nro, dni, monto);
            }
        }

        private void btnVerListado_Click(object sender, EventArgs e)
        {
            FormVer vtnVer = new FormVer();
            int nro;
            double monto;
            for (int i = 0; i < serv.VerCont(); i++)
            {
                serv.VerEx(i, out nro, out monto);
                vtnVer.lbListar.Items.Add($"Nro: {nro}, Monto: {monto}");
            }
            vtnVer.ShowDialog();
        }

        private void btnMayores_Click(object sender, EventArgs e)
        {
            FormVer vtnVer = new FormVer();
            int cant;
            int[] may = serv.MayoresAlProm(out cant);
            if (cant != 0)
            {
                for (int i = 0; i < cant; i++)
                {
                    vtnVer.lbListar.Items.Add(may[i]);
                }
            }
            vtnVer.ShowDialog();
            
        }

        private void btnVerExpedientes_Click(object sender, EventArgs e)
        {
            FormVer vtnVer = new FormVer();
            int cant;
            int dni = Convert.ToInt32(tbDNI.Text);
            int[] exps = serv.VerExpPorDNI(dni, out cant);
            if(cant != 0)
            for (int i = 0; i < cant; i++)
            {
                vtnVer.lbListar.Items.Add(exps[i]);
            }
            vtnVer.ShowDialog();
            
        }

        private void btnVerCausaPorNumero_Click(object sender, EventArgs e)
        {
            FormVer vtnVer = new FormVer();
            int causa = Convert.ToInt32(tbNroCausa.Text);
            int nro = serv.VerExPorNum(causa);
            vtnVer.lbListar.Items.Add(nro);
            vtnVer.ShowDialog();
        }
    }
}
