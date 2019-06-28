namespace Programa05_06
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
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Image = global::Programa05_06.Properties.Resources.cvinfojobs;
            this.pictureBoxImagen.Location = new System.Drawing.Point(95, 22);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(145, 351);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagen.TabIndex = 0;
            this.pictureBoxImagen.TabStop = false;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(331, 22);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(75, 23);
            this.buttonCargar.TabIndex = 1;
            this.buttonCargar.Text = "&Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Enabled = false;
            this.buttonReiniciar.Location = new System.Drawing.Point(331, 69);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(75, 23);
            this.buttonReiniciar.TabIndex = 2;
            this.buttonReiniciar.Text = "&Reiniciar";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.pictureBoxImagen);
            this.Name = "Form1";
            this.Text = "Windows Forms C# 28 - PictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonReiniciar;
    }
}

