namespace Programa05_01
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
            this.checkedListBoxAlimentos = new System.Windows.Forms.CheckedListBox();
            this.txtNuevoAlimento = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBoxAlimentos
            // 
            this.checkedListBoxAlimentos.CheckOnClick = true;
            this.checkedListBoxAlimentos.FormattingEnabled = true;
            this.checkedListBoxAlimentos.Items.AddRange(new object[] {
            "Frijol",
            "Tomate"});
            this.checkedListBoxAlimentos.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxAlimentos.Name = "checkedListBoxAlimentos";
            this.checkedListBoxAlimentos.Size = new System.Drawing.Size(389, 94);
            this.checkedListBoxAlimentos.TabIndex = 0;
            this.checkedListBoxAlimentos.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxAlimentos_SelectedIndexChanged);
            // 
            // txtNuevoAlimento
            // 
            this.txtNuevoAlimento.Location = new System.Drawing.Point(37, 161);
            this.txtNuevoAlimento.Name = "txtNuevoAlimento";
            this.txtNuevoAlimento.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoAlimento.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(192, 159);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Añadir";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 124);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 377);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtNuevoAlimento);
            this.Controls.Add(this.checkedListBoxAlimentos);
            this.Name = "Form1";
            this.Text = "Windows Forms C# 23 - CheckedListBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxAlimentos;
        private System.Windows.Forms.TextBox txtNuevoAlimento;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblNombre;
    }
}

