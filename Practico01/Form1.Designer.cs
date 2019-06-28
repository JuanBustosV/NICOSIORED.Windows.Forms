namespace Practico01
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
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblSeguro = new System.Windows.Forms.Label();
            this.RbnBasico = new System.Windows.Forms.RadioButton();
            this.RbnTerceros = new System.Windows.Forms.RadioButton();
            this.RbnTotal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblEquipo = new System.Windows.Forms.Label();
            this.ChkAire = new System.Windows.Forms.CheckBox();
            this.ChkAudio = new System.Windows.Forms.CheckBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.BtnCotizar = new System.Windows.Forms.Button();
            this.TxtCotizacion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(12, 31);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(76, 28);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // LblSeguro
            // 
            this.LblSeguro.AutoSize = true;
            this.LblSeguro.Location = new System.Drawing.Point(19, 30);
            this.LblSeguro.Name = "LblSeguro";
            this.LblSeguro.Size = new System.Drawing.Size(41, 13);
            this.LblSeguro.TabIndex = 2;
            this.LblSeguro.Text = "Seguro";
            // 
            // RbnBasico
            // 
            this.RbnBasico.AutoSize = true;
            this.RbnBasico.Checked = true;
            this.RbnBasico.Location = new System.Drawing.Point(83, 30);
            this.RbnBasico.Name = "RbnBasico";
            this.RbnBasico.Size = new System.Drawing.Size(57, 17);
            this.RbnBasico.TabIndex = 3;
            this.RbnBasico.TabStop = true;
            this.RbnBasico.Text = "Básico";
            this.RbnBasico.UseVisualStyleBackColor = true;
            // 
            // RbnTerceros
            // 
            this.RbnTerceros.AutoSize = true;
            this.RbnTerceros.Location = new System.Drawing.Point(83, 53);
            this.RbnTerceros.Name = "RbnTerceros";
            this.RbnTerceros.Size = new System.Drawing.Size(77, 17);
            this.RbnTerceros.TabIndex = 4;
            this.RbnTerceros.Text = "A Terceros";
            this.RbnTerceros.UseVisualStyleBackColor = true;
            // 
            // RbnTotal
            // 
            this.RbnTotal.AutoSize = true;
            this.RbnTotal.Location = new System.Drawing.Point(83, 77);
            this.RbnTotal.Name = "RbnTotal";
            this.RbnTotal.Size = new System.Drawing.Size(49, 17);
            this.RbnTotal.TabIndex = 5;
            this.RbnTotal.Text = "Total";
            this.RbnTotal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbnTerceros);
            this.groupBox1.Controls.Add(this.RbnTotal);
            this.groupBox1.Controls.Add(this.LblSeguro);
            this.groupBox1.Controls.Add(this.RbnBasico);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 112);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seguros a seleccionar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChkAudio);
            this.groupBox2.Controls.Add(this.ChkAire);
            this.groupBox2.Controls.Add(this.LblEquipo);
            this.groupBox2.Location = new System.Drawing.Point(242, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 112);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipamiento";
            // 
            // LblEquipo
            // 
            this.LblEquipo.AutoSize = true;
            this.LblEquipo.Location = new System.Drawing.Point(24, 30);
            this.LblEquipo.Name = "LblEquipo";
            this.LblEquipo.Size = new System.Drawing.Size(40, 13);
            this.LblEquipo.TabIndex = 0;
            this.LblEquipo.Text = "Equipo";
            // 
            // ChkAire
            // 
            this.ChkAire.AutoSize = true;
            this.ChkAire.Location = new System.Drawing.Point(99, 25);
            this.ChkAire.Name = "ChkAire";
            this.ChkAire.Size = new System.Drawing.Size(117, 17);
            this.ChkAire.TabIndex = 1;
            this.ChkAire.Text = "Aire acondicionado";
            this.ChkAire.UseVisualStyleBackColor = true;
            // 
            // ChkAudio
            // 
            this.ChkAudio.AutoSize = true;
            this.ChkAudio.Location = new System.Drawing.Point(99, 49);
            this.ChkAudio.Name = "ChkAudio";
            this.ChkAudio.Size = new System.Drawing.Size(107, 17);
            this.ChkAudio.TabIndex = 2;
            this.ChkAudio.Text = "Sistema de audio";
            this.ChkAudio.UseVisualStyleBackColor = true;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(12, 223);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(37, 13);
            this.LblPrecio.TabIndex = 8;
            this.LblPrecio.Text = "Precio";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(76, 220);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecio.TabIndex = 9;
            this.TxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnCotizar
            // 
            this.BtnCotizar.Location = new System.Drawing.Point(242, 218);
            this.BtnCotizar.Name = "BtnCotizar";
            this.BtnCotizar.Size = new System.Drawing.Size(75, 23);
            this.BtnCotizar.TabIndex = 10;
            this.BtnCotizar.Text = "Cotizar";
            this.BtnCotizar.UseVisualStyleBackColor = true;
            this.BtnCotizar.Click += new System.EventHandler(this.BtnCotizar_Click);
            // 
            // TxtCotizacion
            // 
            this.TxtCotizacion.Location = new System.Drawing.Point(15, 256);
            this.TxtCotizacion.Multiline = true;
            this.TxtCotizacion.Name = "TxtCotizacion";
            this.TxtCotizacion.Size = new System.Drawing.Size(534, 166);
            this.TxtCotizacion.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.TxtCotizacion);
            this.Controls.Add(this.BtnCotizar);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Name = "Form1";
            this.Text = "Windows Forms C# 11 - Ejercicio práctico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblSeguro;
        private System.Windows.Forms.RadioButton RbnBasico;
        private System.Windows.Forms.RadioButton RbnTerceros;
        private System.Windows.Forms.RadioButton RbnTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblEquipo;
        private System.Windows.Forms.CheckBox ChkAudio;
        private System.Windows.Forms.CheckBox ChkAire;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Button BtnCotizar;
        private System.Windows.Forms.TextBox TxtCotizacion;
    }
}

