using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_03
{
    public partial class Form1 : Form
    {
        private int ri = -1; // row index

        public Form1()
        {
            InitializeComponent();
//            labelInformacion.Text = dataGridViewProductos.Rows.Count.ToString();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            // Adicionamos nuevo renglon
            int n = dataGridViewProductos.Rows.Add();

            // Colocamos la informacion
            dataGridViewProductos.Rows[n].Cells[0].Value = textBoxCodigo.Text;
            dataGridViewProductos.Rows[n].Cells[1].Value = textBoxNombre.Text;
            dataGridViewProductos.Rows[n].Cells[2].Value = textBoxPrecio.Text;

            // Limpiamos los textBox
            textBoxCodigo.Clear();
            textBoxNombre.Clear();
            textBoxPrecio.Clear();
        }

        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ri = e.RowIndex;

            if(ri != -1) // si seleciono el  encabezado el índice es igual a -1
            {
                labelInformacion.Text = (string) dataGridViewProductos.Rows[ri].Cells[1].Value;
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            int totalFilas = dataGridViewProductos.Rows.Count; // número de filas incluso la nueva vacía

            if (ri != -1 && ri < (totalFilas-1))
            {
                dataGridViewProductos.Rows.RemoveAt(ri);               
            }
        }
    }
}
