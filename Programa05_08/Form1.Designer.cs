namespace Programa05_08
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
            this.listViewAlimentos = new System.Windows.Forms.ListView();
            this.textBoxElemento = new System.Windows.Forms.TextBox();
            this.groupBoxGrupos = new System.Windows.Forms.GroupBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.radioButtonCarnes = new System.Windows.Forms.RadioButton();
            this.radioButtonFrutas = new System.Windows.Forms.RadioButton();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBoxGrupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewAlimentos
            // 
            this.listViewAlimentos.Location = new System.Drawing.Point(12, 12);
            this.listViewAlimentos.Name = "listViewAlimentos";
            this.listViewAlimentos.Size = new System.Drawing.Size(369, 258);
            this.listViewAlimentos.TabIndex = 0;
            this.listViewAlimentos.UseCompatibleStateImageBehavior = false;
            this.listViewAlimentos.View = System.Windows.Forms.View.SmallIcon;
            this.listViewAlimentos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewAlimentos_MouseClick);
            // 
            // textBoxElemento
            // 
            this.textBoxElemento.Location = new System.Drawing.Point(13, 288);
            this.textBoxElemento.Name = "textBoxElemento";
            this.textBoxElemento.Size = new System.Drawing.Size(120, 20);
            this.textBoxElemento.TabIndex = 1;
            // 
            // groupBoxGrupos
            // 
            this.groupBoxGrupos.Controls.Add(this.buttonAdicionar);
            this.groupBoxGrupos.Controls.Add(this.radioButtonCarnes);
            this.groupBoxGrupos.Controls.Add(this.radioButtonFrutas);
            this.groupBoxGrupos.Location = new System.Drawing.Point(181, 276);
            this.groupBoxGrupos.Name = "groupBoxGrupos";
            this.groupBoxGrupos.Size = new System.Drawing.Size(200, 112);
            this.groupBoxGrupos.TabIndex = 2;
            this.groupBoxGrupos.TabStop = false;
            this.groupBoxGrupos.Text = "Grupo:";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(110, 26);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 2;
            this.buttonAdicionar.Text = "A&ñadir";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // radioButtonCarnes
            // 
            this.radioButtonCarnes.AutoSize = true;
            this.radioButtonCarnes.Location = new System.Drawing.Point(20, 53);
            this.radioButtonCarnes.Name = "radioButtonCarnes";
            this.radioButtonCarnes.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCarnes.TabIndex = 1;
            this.radioButtonCarnes.TabStop = true;
            this.radioButtonCarnes.Text = "Carnes";
            this.radioButtonCarnes.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrutas
            // 
            this.radioButtonFrutas.AutoSize = true;
            this.radioButtonFrutas.Checked = true;
            this.radioButtonFrutas.Location = new System.Drawing.Point(20, 29);
            this.radioButtonFrutas.Name = "radioButtonFrutas";
            this.radioButtonFrutas.Size = new System.Drawing.Size(54, 17);
            this.radioButtonFrutas.TabIndex = 0;
            this.radioButtonFrutas.TabStop = true;
            this.radioButtonFrutas.Text = "Frutas";
            this.radioButtonFrutas.UseVisualStyleBackColor = true;
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(388, 36);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(72, 13);
            this.lblSeleccionado.TabIndex = 3;
            this.lblSeleccionado.Text = "Seleccionado";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(388, 53);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 428);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.groupBoxGrupos);
            this.Controls.Add(this.textBoxElemento);
            this.Controls.Add(this.listViewAlimentos);
            this.Name = "Form1";
            this.Text = "Windows Forms C# 31-34 - ListView I-IV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxGrupos.ResumeLayout(false);
            this.groupBoxGrupos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAlimentos;
        private System.Windows.Forms.TextBox textBoxElemento;
        private System.Windows.Forms.GroupBox groupBoxGrupos;
        private System.Windows.Forms.RadioButton radioButtonCarnes;
        private System.Windows.Forms.RadioButton radioButtonFrutas;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

