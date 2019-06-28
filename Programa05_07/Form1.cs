using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_07
{
    public partial class Form1 : Form
    {
        private int indice;

        public Form1()
        {
            InitializeComponent();
            indice = 0;
        }

        private void buttonCambiarImg_Click(object sender, EventArgs e)
        {
            indice++;

            if (indice > 8)
                indice = 0;

            labelFoto.ImageIndex = indice;

            // Recuerda, tam máx de imageList 256x256
            pictureBoxImagen.Image = imageListFotos.Images[indice];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxImagen.Image = imageListFotos.Images[0];
        }
    }
}
