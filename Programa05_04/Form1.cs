using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelMensaje.Text = domainUpDownFrutas.SelectedIndex.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            domainUpDownFrutas.Items.Add("Melón");
            domainUpDownFrutas.Items.Add("Manzana");
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            domainUpDownFrutas.Items.Add(textBoxFrutas.Text);

            textBoxFrutas.Clear();
        }

        private void domainUpDownFrutas_SelectedItemChanged(object sender, EventArgs e)
        {
            string fruta = (string) domainUpDownFrutas.SelectedItem;

            labelMensaje.Text = string.Format("Tú fruta favorita es {0}, muy sabrosa", fruta);
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            int indice = domainUpDownFrutas.SelectedIndex;

            if (domainUpDownFrutas.Items.Count > 0 && indice > -1)
            {
                domainUpDownFrutas.Items.RemoveAt(indice);

                if (domainUpDownFrutas.Items.Count > 0)
                    // Seleccionamos el elemento que queremos que se muestre
                    domainUpDownFrutas.SelectedIndex = 0; // 0 el primer elemento
                else // no tiene elementos
                    domainUpDownFrutas.Text = "(Vacío...)";
            } 
        }
    }
}
