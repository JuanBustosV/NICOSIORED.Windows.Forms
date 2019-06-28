using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa04_01
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        private int numero;

        public Form1()
        {
            InitializeComponent();
            numero = r.Next(0,100);
        }

        private void timerPrueba_Tick(object sender, EventArgs e)
        {
            numero = r.Next(0, 100);
            LblValor.Text = numero.ToString();

            if (progressBarTrabajo.Value < 100)
                progressBarTrabajo.Value++;
            else
                timerPrueba.Stop();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            //timerPrueba.Enabled = true;
            timerPrueba.Start(); // hace lo mismo que la línea de arriba
            progressBarTrabajo.Value = 0;
        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            //timerPrueba.Enabled = false;
            timerPrueba.Stop(); // hace lo mismo que la línea de arriba
            trackBarIntervalo.Value = trackBarIntervalo.Minimum;
            lblTBValor.Text = trackBarIntervalo.Minimum.ToString();
            timerPrueba.Interval = trackBarIntervalo.Value;
        }

        // Garantizar que el timer se detiene al cerrar el Form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerPrueba.Enabled = false;
        }

        private void trackBarIntervalo_Scroll(object sender, EventArgs e)
        {
            lblTBValor.Text = trackBarIntervalo.Value.ToString();
            timerPrueba.Interval = trackBarIntervalo.Value;
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < 100000; n++)
            {
                // aquí algun proceso

                if (n % 1000 == 0)
                    progressBarTrabajo.PerformStep();
            }
        }
    }
}
