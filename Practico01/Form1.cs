using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCotizar_Click(object sender, EventArgs e)
        {
            double precio = 0.0;
            string cotizacion = "";

            cotizacion = "Cotización de coche para " + TxtNombre.Text + ".\r\n\r\n";
            // Obtener precio inicial
            precio = Convert.ToDouble(TxtPrecio.Text);

            // Verificar seguros
            if(RbnBasico.Checked == true)
            {
                precio = precio + 500.0;
                cotizacion += "LLeva seguro básico de 500€ \r\n";
            }
            else if(RbnTerceros.Checked == true)
            {
                precio += 700.0;
                cotizacion += "Lleva seguro a terceros de 700€ \r\n";
            } else // seguro total, única opción pendiente
            {
                precio += 1000.0;
                cotizacion += "Lleva seguro total de 1000€ \r\n";
            }

            // Verificar equipo

            if(ChkAire.Checked == true)
            {
                precio += 500.0;
                cotizacion += "Con aire acondicionado de 500€ \r\n";
            }
            if(ChkAudio.Checked == true)
            {
                precio += 700.0;
                cotizacion += "Con sistema de audio de 700€ \r\n";
            }

            // Mostramos total
            cotizacion += "\r\nEl total a pagar es de " + precio.ToString() + " €.";

            TxtCotizacion.Text = cotizacion;
        }
    }
}
