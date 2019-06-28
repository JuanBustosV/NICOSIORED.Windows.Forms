namespace Programa05_02
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
            this.comboBoxAlimentos = new System.Windows.Forms.ComboBox();
            this.textBoxAlimento = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.labelIndice = new System.Windows.Forms.Label();
            this.labelTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxAlimentos
            // 
            this.comboBoxAlimentos.FormattingEnabled = true;
            this.comboBoxAlimentos.Items.AddRange(new object[] {
            "Frijol",
            "Tomate"});
            this.comboBoxAlimentos.Location = new System.Drawing.Point(112, 44);
            this.comboBoxAlimentos.Name = "comboBoxAlimentos";
            this.comboBoxAlimentos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlimentos.TabIndex = 0;
            this.comboBoxAlimentos.Text = "Alimentos";
            this.comboBoxAlimentos.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlimentos_SelectedIndexChanged);
            // 
            // textBoxAlimento
            // 
            this.textBoxAlimento.Location = new System.Drawing.Point(72, 135);
            this.textBoxAlimento.Name = "textBoxAlimento";
            this.textBoxAlimento.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlimento.TabIndex = 1;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(213, 133);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 2;
            this.buttonAdicionar.Text = "A&ñadir";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // labelIndice
            // 
            this.labelIndice.AutoSize = true;
            this.labelIndice.Location = new System.Drawing.Point(109, 98);
            this.labelIndice.Name = "labelIndice";
            this.labelIndice.Size = new System.Drawing.Size(36, 13);
            this.labelIndice.TabIndex = 3;
            this.labelIndice.Text = "Índice";
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Location = new System.Drawing.Point(199, 98);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(34, 13);
            this.labelTexto.TabIndex = 4;
            this.labelTexto.Text = "Texto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 220);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.labelIndice);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.textBoxAlimento);
            this.Controls.Add(this.comboBoxAlimentos);
            this.Name = "Form1";
            this.Text = "Windows Forms C# 24 - ComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAlimentos;
        private System.Windows.Forms.TextBox textBoxAlimento;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label labelIndice;
        private System.Windows.Forms.Label labelTexto;
    }
}

