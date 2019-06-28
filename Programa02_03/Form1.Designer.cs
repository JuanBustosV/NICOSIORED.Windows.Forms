namespace Programa02_03
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
            this.btnEnvio1 = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.BtnEnvio2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnvio1
            // 
            this.btnEnvio1.Location = new System.Drawing.Point(309, 86);
            this.btnEnvio1.Name = "btnEnvio1";
            this.btnEnvio1.Size = new System.Drawing.Size(75, 23);
            this.btnEnvio1.TabIndex = 0;
            this.btnEnvio1.Text = "Envio1";
            this.btnEnvio1.UseVisualStyleBackColor = true;
            this.btnEnvio1.Click += new System.EventHandler(this.btnEnvio1_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(55, 88);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(185, 20);
            this.txtMensaje.TabIndex = 1;
            // 
            // BtnEnvio2
            // 
            this.BtnEnvio2.Location = new System.Drawing.Point(309, 129);
            this.BtnEnvio2.Name = "BtnEnvio2";
            this.BtnEnvio2.Size = new System.Drawing.Size(75, 23);
            this.BtnEnvio2.TabIndex = 2;
            this.BtnEnvio2.Text = "Envio 2";
            this.BtnEnvio2.UseVisualStyleBackColor = true;
            this.BtnEnvio2.Click += new System.EventHandler(this.BtnEnvio2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.BtnEnvio2);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btnEnvio1);
            this.Name = "Form1";
            this.Text = "Windows Forms C# 10 --- Comunicación entre formas I";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnvio1;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button BtnEnvio2;
    }
}

