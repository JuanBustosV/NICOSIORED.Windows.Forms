using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxAlimentos.Items.Add("Lechuga");
            comboBoxAlimentos.Items.Add("Leche");
            comboBoxAlimentos.Items.Add("Patata");
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            comboBoxAlimentos.Items.Add(textBoxAlimento.Text);
        }

        private void comboBoxAlimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBoxAlimentos.SelectedIndex;

            labelIndice.Text = indice.ToString();

            labelTexto.Text = comboBoxAlimentos.Items[indice].ToString();
        }
    }
}
