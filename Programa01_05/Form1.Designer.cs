﻿namespace Programa01_05
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gBoxOperaciones = new System.Windows.Forms.GroupBox();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.rbResta = new System.Windows.Forms.RadioButton();
            this.rbMulti = new System.Windows.Forms.RadioButton();
            this.rbDiv = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.gBoxOperaciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(12, 13);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            this.txtA.Text = "0";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(12, 39);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 1;
            this.txtB.Text = "0";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(201, 10);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gBoxOperaciones
            // 
            this.gBoxOperaciones.Controls.Add(this.rbDiv);
            this.gBoxOperaciones.Controls.Add(this.rbMulti);
            this.gBoxOperaciones.Controls.Add(this.rbResta);
            this.gBoxOperaciones.Controls.Add(this.rbSuma);
            this.gBoxOperaciones.Location = new System.Drawing.Point(12, 125);
            this.gBoxOperaciones.Name = "gBoxOperaciones";
            this.gBoxOperaciones.Size = new System.Drawing.Size(152, 139);
            this.gBoxOperaciones.TabIndex = 3;
            this.gBoxOperaciones.TabStop = false;
            this.gBoxOperaciones.Text = "Operaciones";
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.Checked = true;
            this.rbSuma.Location = new System.Drawing.Point(6, 19);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(55, 17);
            this.rbSuma.TabIndex = 0;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "Sumar";
            this.rbSuma.UseVisualStyleBackColor = true;
            // 
            // rbResta
            // 
            this.rbResta.AutoSize = true;
            this.rbResta.Location = new System.Drawing.Point(7, 43);
            this.rbResta.Name = "rbResta";
            this.rbResta.Size = new System.Drawing.Size(56, 17);
            this.rbResta.TabIndex = 1;
            this.rbResta.Text = "Restar";
            this.rbResta.UseVisualStyleBackColor = true;
            // 
            // rbMulti
            // 
            this.rbMulti.AutoSize = true;
            this.rbMulti.Location = new System.Drawing.Point(7, 67);
            this.rbMulti.Name = "rbMulti";
            this.rbMulti.Size = new System.Drawing.Size(72, 17);
            this.rbMulti.TabIndex = 2;
            this.rbMulti.Text = "Multiplicar";
            this.rbMulti.UseVisualStyleBackColor = true;
            // 
            // rbDiv
            // 
            this.rbDiv.AutoSize = true;
            this.rbDiv.Location = new System.Drawing.Point(7, 91);
            this.rbDiv.Name = "rbDiv";
            this.rbDiv.Size = new System.Drawing.Size(54, 17);
            this.rbDiv.TabIndex = 3;
            this.rbDiv.Text = "Dividir";
            this.rbDiv.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 80);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(201, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 105);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 276);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.gBoxOperaciones);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Windows Forms C# 7";
            this.gBoxOperaciones.ResumeLayout(false);
            this.gBoxOperaciones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gBoxOperaciones;
        private System.Windows.Forms.RadioButton rbDiv;
        private System.Windows.Forms.RadioButton rbMulti;
        private System.Windows.Forms.RadioButton rbResta;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

