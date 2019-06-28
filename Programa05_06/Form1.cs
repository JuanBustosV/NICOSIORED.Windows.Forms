using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            Image miImagen = Image.FromFile("..\\..\\Images\\cvlinkedin.jpg");

            pictureBoxImagen.Image = miImagen;
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;

            buttonCargar.Enabled = false;
            buttonReiniciar.Enabled = true;
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            Image miImagen = Image.FromFile("..\\..\\Images\\cvinfojobs.png");

            pictureBoxImagen.Image = miImagen;
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;

            buttonCargar.Enabled = true;
            buttonReiniciar.Enabled = false;
        }
    }
}
