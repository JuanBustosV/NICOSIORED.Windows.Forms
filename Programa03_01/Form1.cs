using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Un ejemplo sencillo.\r\nJuan Bustos", "Acerca de...");
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TxtA.Text);
            double b = Convert.ToDouble(TxtB.Text);

            double r = a + b;
            LblResultado.Text = r.ToString();

            // Para esta parte mejor sería crear un método, actualizar status
            toolStripStatusLabelValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            toolStripStatusLabelOperacion.Text = "Suma";
            toolStripStatusLabelResultado.Text = "R=" + r.ToString();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TxtA.Text);
            double b = Convert.ToDouble(TxtB.Text);

            double r = a - b;
            LblResultado.Text = r.ToString();

            toolStripStatusLabelValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            toolStripStatusLabelOperacion.Text = "Resta";
            toolStripStatusLabelResultado.Text = "R=" + r.ToString();
        }

        private void multiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TxtA.Text);
            double b = Convert.ToDouble(TxtB.Text);

            double r = a * b;
            LblResultado.Text = r.ToString();

            toolStripStatusLabelValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            toolStripStatusLabelOperacion.Text = "Multiplicación";
            toolStripStatusLabelResultado.Text = "R=" + r.ToString();
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TxtA.Text);
            double b = Convert.ToDouble(TxtB.Text);

            double r = a / b;
            LblResultado.Text = r.ToString();

            toolStripStatusLabelValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            toolStripStatusLabelOperacion.Text = "División";
            toolStripStatusLabelResultado.Text = "R=" + r.ToString();
        }

        private void habilitarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            TxtA.Enabled = habilitarToolStripMenuItem.Checked;
            TxtB.Enabled = habilitarToolStripMenuItem.Checked;
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtA.Text = "0";
        }

        private void aleatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int valor = rnd.Next(0, 100);

            TxtA.Text = valor.ToString();
        }
    }
}
