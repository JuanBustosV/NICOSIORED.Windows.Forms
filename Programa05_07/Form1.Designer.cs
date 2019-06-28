namespace Programa05_07
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageListFotos = new System.Windows.Forms.ImageList(this.components);
            this.labelFoto = new System.Windows.Forms.Label();
            this.buttonCambiarImg = new System.Windows.Forms.Button();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListFotos
            // 
            this.imageListFotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFotos.ImageStream")));
            this.imageListFotos.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFotos.Images.SetKeyName(0, "uno.png");
            this.imageListFotos.Images.SetKeyName(1, "dos.png");
            this.imageListFotos.Images.SetKeyName(2, "tres.png");
            this.imageListFotos.Images.SetKeyName(3, "cuatro.png");
            this.imageListFotos.Images.SetKeyName(4, "cinco.png");
            this.imageListFotos.Images.SetKeyName(5, "seis.png");
            this.imageListFotos.Images.SetKeyName(6, "siete.png");
            this.imageListFotos.Images.SetKeyName(7, "ocho.png");
            this.imageListFotos.Images.SetKeyName(8, "Bitmap1.bmp");
            // 
            // labelFoto
            // 
            this.labelFoto.ImageIndex = 0;
            this.labelFoto.ImageList = this.imageListFotos;
            this.labelFoto.Location = new System.Drawing.Point(28, 36);
            this.labelFoto.Name = "labelFoto";
            this.labelFoto.Size = new System.Drawing.Size(100, 100);
            this.labelFoto.TabIndex = 0;
            this.labelFoto.Text = "label1";
            // 
            // buttonCambiarImg
            // 
            this.buttonCambiarImg.Location = new System.Drawing.Point(53, 173);
            this.buttonCambiarImg.Name = "buttonCambiarImg";
            this.buttonCambiarImg.Size = new System.Drawing.Size(104, 23);
            this.buttonCambiarImg.TabIndex = 1;
            this.buttonCambiarImg.Text = "Cambiar Imagen";
            this.buttonCambiarImg.UseVisualStyleBackColor = true;
            this.buttonCambiarImg.Click += new System.EventHandler(this.buttonCambiarImg_Click);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Location = new System.Drawing.Point(189, 36);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxImagen.TabIndex = 2;
            this.pictureBoxImagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 296);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.buttonCambiarImg);
            this.Controls.Add(this.labelFoto);
            this.Name = "Form1";
            this.Text = "Windows Forms C# 29 - ImageList";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListFotos;
        private System.Windows.Forms.Label labelFoto;
        private System.Windows.Forms.Button buttonCambiarImg;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
    }
}

