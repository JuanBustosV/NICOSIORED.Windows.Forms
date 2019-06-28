using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_04
{
    public partial class Form1 : Form
    {
        Form2 miForm2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnForma2_Click(object sender, EventArgs e)
        {
            // Inicializo los txtBoxs de Form2 y muestro ventana Form2
            miForm2.Mensaje = "";
            miForm2.Contenido = "";
            DialogResult resultado = miForm2.ShowDialog();
            
            switch(resultado)
            {
                case DialogResult.OK:
                    LblMensaje.Text = miForm2.Mensaje;
                    LblContenido.Text = miForm2.Contenido;
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Cancelaste la operación.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                default:
                    break;
            }
            /*
            if (resultado == DialogResult.OK)
            {                
                LblMensaje.Text = miForm2.Mensaje;
                LblContenido.Text = miForm2.Contenido;
            }*/
        }
    }
}
