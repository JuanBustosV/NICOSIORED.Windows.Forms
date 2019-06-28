using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBoxAlimentos.Items.Add("Carne");
            checkedListBoxAlimentos.Items.Add("Pescado", true);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            checkedListBoxAlimentos.Items.Add(txtNuevoAlimento.Text);
        }

        private void checkedListBoxAlimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = checkedListBoxAlimentos.SelectedIndex;

            if (indice != -1) // tiene un elemento seleccionado (azul)
            {
                lblNombre.Text = checkedListBoxAlimentos.Items[indice].ToString();
            }

            if (checkedListBoxAlimentos.GetItemChecked(3) == true)
                MessageBox.Show("El pescado es bueno");
        }
    }
}
