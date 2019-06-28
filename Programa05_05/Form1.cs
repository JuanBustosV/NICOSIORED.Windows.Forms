using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Adicionar elementos al ListBox
            listBoxFrutas.Items.Add("Banana");
            listBoxFrutas.Items.Add("Durazno");
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            listBoxFrutas.Items.Add(textBoxFruta.Text);

            textBoxFruta.Clear(); // = string.Empty;
        }

        private void listBoxFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFrutas.SelectedIndex != -1)
                labelFruta.Text = (string) listBoxFrutas.Items[listBoxFrutas.SelectedIndex];
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int indice = listBoxFrutas.SelectedIndex;

            if (indice != -1)
            {
                listBoxFrutas.Items.RemoveAt(indice);
                labelFruta.Text = "Fruta seleccionada";
            }
        }
    }
}
