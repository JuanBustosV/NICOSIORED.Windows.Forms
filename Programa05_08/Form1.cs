using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Para la ruta imagenes, contenido carpeta
using System.IO;

namespace Programa05_08
{
    public partial class Form1 : Form
    {
        private ListViewGroup frutas = new ListViewGroup("Frutas", HorizontalAlignment.Center);
        private ListViewGroup carnes = new ListViewGroup("Carne", HorizontalAlignment.Center);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Creamos un imagelist
            ImageList misImagenes = new ImageList();
            misImagenes.ImageSize = new Size(100, 100);

            // Obtener el listado de imágenes (directorio solo con imágenes)
            string[] archivos = Directory.GetFiles("imagenes");

            // Cargamos los archivos
            try
            {
                foreach (string archivo in archivos)
                    misImagenes.Images.Add(Image.FromFile(archivo));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salió mal al cargar las imágenes");
            }

            listViewAlimentos.SmallImageList = misImagenes;

            listViewAlimentos.Items.Add(new ListViewItem("Manzana",0, frutas));
            listViewAlimentos.Items.Add(new ListViewItem("Pera",1, frutas));
            listViewAlimentos.Items.Add(new ListViewItem("Sandía",2, frutas));
            listViewAlimentos.Items.Add(new ListViewItem("Plátano",3, frutas));
            listViewAlimentos.Items.Add(new ListViewItem("Melón",4, frutas));
            listViewAlimentos.Items.Add(new ListViewItem("ciruela",5, frutas));

            ListViewItem miElemento = new ListViewItem("Pollo", carnes);
            listViewAlimentos.Items.Add(miElemento);

            listViewAlimentos.Items.Add(new ListViewItem("Vaca", carnes));
            listViewAlimentos.Items.Add(new ListViewItem("Pavo", carnes));
            listViewAlimentos.Items.Add(new ListViewItem("Cerdo", carnes));
            listViewAlimentos.Items.Add(new ListViewItem("Codorníz", carnes));

            listViewAlimentos.Groups.Add(frutas);
            listViewAlimentos.Groups.Add(carnes);
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if(radioButtonFrutas.Checked == true)
            {
                listViewAlimentos.Items.Add(new ListViewItem(textBoxElemento.Text, frutas));
            }
            else // si no es fruta solo puede ser Carne
            {
                listViewAlimentos.Items.Add(new ListViewItem(textBoxElemento.Text, carnes));
            }
        }

        private void listViewAlimentos_MouseClick(object sender, MouseEventArgs e)
        {
            lblSeleccionado.Text = listViewAlimentos.SelectedItems[0]/*.SubItems[0]*/.Text;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblSeleccionado.Text = string.Empty;
            listViewAlimentos.Items.Clear();
        }
    }
}
