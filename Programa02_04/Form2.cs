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
    public partial class Form2 : Form
    {
        private string mensaje;
        private string contenido;


        public Form2()
        {
            InitializeComponent();
            toolTipBtnSalir.SetToolTip(BtnSalir, "Cierra la ventana Form2.");
            toolTipBtnCancel.SetToolTip(BtnCancel, "Cancela el envío de información.");
        }

        public string Mensaje
        {
            get { return mensaje; }

            set { TxtMensaje.Text = value; }
        }

        public string Contenido
        {
            get { return contenido; }

            set { TxtContenido.Text = value; }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
/*            mensaje = TxtMensaje.Text;
            contenido = TxtContenido.Text;
*/           this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            mensaje = TxtMensaje.Text;
            contenido = TxtContenido.Text;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
