namespace Programa05_05
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
            this.listBoxFrutas = new System.Windows.Forms.ListBox();
            this.textBoxFruta = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.labelFruta = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxFrutas
            // 
            this.listBoxFrutas.FormattingEnabled = true;
            this.listBoxFrutas.Items.AddRange(new object[] {
            "Manzana",
            "Aguacate",
            "Pera"});
            this.listBoxFrutas.Location = new System.Drawing.Point(84, 162);
            this.listBoxFrutas.Name = "listBoxFrutas";
            this.listBoxFrutas.Size = new System.Drawing.Size(201, 95);
            this.listBoxFrutas.TabIndex = 0;
            this.listBoxFrutas.SelectedIndexChanged += new System.EventHandler(this.listBoxFrutas_SelectedIndexChanged);
            // 
            // textBoxFruta
            // 
            this.textBoxFruta.Location = new System.Drawing.Point(43, 47);
            this.textBoxFruta.Name = "textBoxFruta";
            this.textBoxFruta.Size = new System.Drawing.Size(100, 20);
            this.textBoxFruta.TabIndex = 1;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(256, 44);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 2;
            this.buttonAdicionar.Text = "&Añadir";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // labelFruta
            // 
            this.labelFruta.AutoSize = true;
            this.labelFruta.Location = new System.Drawing.Point(84, 107);
            this.labelFruta.Name = "labelFruta";
            this.labelFruta.Size = new System.Drawing.Size(97, 13);
            this.labelFruta.TabIndex = 3;
            this.labelFruta.Text = "Fruta seleccionada";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(256, 84);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "&Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 326);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelFruta);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.textBoxFruta);
            this.Controls.Add(this.listBoxFrutas);
            this.Name = "Form1";
            this.Text = "Windows Forms C# 27 - ListBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFrutas;
        private System.Windows.Forms.TextBox textBoxFruta;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label labelFruta;
        private System.Windows.Forms.Button buttonEliminar;
    }
}

