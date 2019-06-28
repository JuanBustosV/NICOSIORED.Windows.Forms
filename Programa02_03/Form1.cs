using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_03
{
    public partial class Form1 : Form
    {
        // Creamos la instancia de la forma 2
        Form2 miForma2 = new Form2("Nicosiored"); // para el mensaje (constructor)

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnvio1_Click(object sender, EventArgs e)
        {
            

            miForma2.Comentario = txtMensaje.Text; // para el comentario (propiedad)

            // Mostramos la forma
            miForma2.Show();
            //miForma2.ShowDialog();
        }

        private void BtnEnvio2_Click(object sender, EventArgs e)
        {
            miForma2.Comentario = txtMensaje.Text;
        }
    }
}
