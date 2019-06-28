namespace Programa05_04
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
            this.domainUpDownFrutas = new System.Windows.Forms.DomainUpDown();
            this.textBoxFrutas = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // domainUpDownFrutas
            // 
            this.domainUpDownFrutas.Location = new System.Drawing.Point(41, 147);
            this.domainUpDownFrutas.Name = "domainUpDownFrutas";
            this.domainUpDownFrutas.Size = new System.Drawing.Size(120, 20);
            this.domainUpDownFrutas.TabIndex = 0;
            this.domainUpDownFrutas.Text = "Frutas";
            this.domainUpDownFrutas.SelectedItemChanged += new System.EventHandler(this.domainUpDownFrutas_SelectedItemChanged);
            // 
            // textBoxFrutas
            // 
            this.textBoxFrutas.Location = new System.Drawing.Point(41, 45);
            this.textBoxFrutas.Name = "textBoxFrutas";
            this.textBoxFrutas.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrutas.TabIndex = 1;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(239, 43);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 2;
            this.buttonAdicionar.Text = "&Añadir";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Location = new System.Drawing.Point(41, 97);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(47, 13);
            this.labelMensaje.TabIndex = 3;
            this.labelMensaje.Text = "Mensaje";
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(239, 87);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrar.TabIndex = 4;
            this.buttonBorrar.Text = "&Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 333);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.textBoxFrutas);
            this.Controls.Add(this.domainUpDownFrutas);
            this.Name = "Form1";
            this.Text = "Windows Forms C# 26 - DomainUpDown";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown domainUpDownFrutas;
        private System.Windows.Forms.TextBox textBoxFrutas;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.Button buttonBorrar;
    }
}

