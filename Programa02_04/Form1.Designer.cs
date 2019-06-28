namespace Programa02_04
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
            this.LblMensaje = new System.Windows.Forms.Label();
            this.BtnForma2 = new System.Windows.Forms.Button();
            this.LblContenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Location = new System.Drawing.Point(50, 63);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(76, 13);
            this.LblMensaje.TabIndex = 0;
            this.LblMensaje.Text = "Mensaje inicial";
            // 
            // BtnForma2
            // 
            this.BtnForma2.Location = new System.Drawing.Point(312, 58);
            this.BtnForma2.Name = "BtnForma2";
            this.BtnForma2.Size = new System.Drawing.Size(75, 23);
            this.BtnForma2.TabIndex = 1;
            this.BtnForma2.Text = "Abrir &Forma2";
            this.BtnForma2.UseVisualStyleBackColor = true;
            this.BtnForma2.Click += new System.EventHandler(this.BtnForma2_Click);
            // 
            // LblContenido
            // 
            this.LblContenido.AutoSize = true;
            this.LblContenido.Location = new System.Drawing.Point(50, 101);
            this.LblContenido.Name = "LblContenido";
            this.LblContenido.Size = new System.Drawing.Size(55, 13);
            this.LblContenido.TabIndex = 2;
            this.LblContenido.Text = "Contenido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 287);
            this.Controls.Add(this.LblContenido);
            this.Controls.Add(this.BtnForma2);
            this.Controls.Add(this.LblMensaje);
            this.Name = "Form1";
            this.Text = "Windows Forms C# 12 - Comunicación entre formas II";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.Button BtnForma2;
        private System.Windows.Forms.Label LblContenido;
    }
}

