namespace Programa04_01
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
            this.components = new System.ComponentModel.Container();
            this.timerPrueba = new System.Windows.Forms.Timer(this.components);
            this.LblValor = new System.Windows.Forms.Label();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.BtnDetener = new System.Windows.Forms.Button();
            this.trackBarIntervalo = new System.Windows.Forms.TrackBar();
            this.lblTBValor = new System.Windows.Forms.Label();
            this.progressBarTrabajo = new System.Windows.Forms.ProgressBar();
            this.btnCalculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // timerPrueba
            // 
            this.timerPrueba.Tick += new System.EventHandler(this.timerPrueba_Tick);
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Location = new System.Drawing.Point(82, 68);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(90, 13);
            this.LblValor.TabIndex = 0;
            this.LblValor.Text = "Valores aleatorios";
            // 
            // BtnInicio
            // 
            this.BtnInicio.Location = new System.Drawing.Point(279, 63);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(75, 23);
            this.BtnInicio.TabIndex = 1;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // BtnDetener
            // 
            this.BtnDetener.Location = new System.Drawing.Point(279, 101);
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(75, 23);
            this.BtnDetener.TabIndex = 2;
            this.BtnDetener.Text = "Detener";
            this.BtnDetener.UseVisualStyleBackColor = true;
            this.BtnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // trackBarIntervalo
            // 
            this.trackBarIntervalo.Location = new System.Drawing.Point(12, 171);
            this.trackBarIntervalo.Maximum = 1000;
            this.trackBarIntervalo.Minimum = 100;
            this.trackBarIntervalo.Name = "trackBarIntervalo";
            this.trackBarIntervalo.Size = new System.Drawing.Size(402, 45);
            this.trackBarIntervalo.TabIndex = 3;
            this.trackBarIntervalo.TickFrequency = 100;
            this.trackBarIntervalo.Value = 100;
            this.trackBarIntervalo.Scroll += new System.EventHandler(this.trackBarIntervalo_Scroll);
            // 
            // lblTBValor
            // 
            this.lblTBValor.AutoSize = true;
            this.lblTBValor.Location = new System.Drawing.Point(82, 106);
            this.lblTBValor.Name = "lblTBValor";
            this.lblTBValor.Size = new System.Drawing.Size(48, 13);
            this.lblTBValor.TabIndex = 4;
            this.lblTBValor.Text = "Intervalo";
            // 
            // progressBarTrabajo
            // 
            this.progressBarTrabajo.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarTrabajo.Location = new System.Drawing.Point(12, 222);
            this.progressBarTrabajo.Name = "progressBarTrabajo";
            this.progressBarTrabajo.Size = new System.Drawing.Size(402, 23);
            this.progressBarTrabajo.TabIndex = 5;
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(279, 275);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 6;
            this.btnCalculo.Text = "&Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 328);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.progressBarTrabajo);
            this.Controls.Add(this.lblTBValor);
            this.Controls.Add(this.trackBarIntervalo);
            this.Controls.Add(this.BtnDetener);
            this.Controls.Add(this.BtnInicio);
            this.Controls.Add(this.LblValor);
            this.Name = "Form1";
            this.Text = "Windows Forms C# 20 - Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerPrueba;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button BtnDetener;
        private System.Windows.Forms.TrackBar trackBarIntervalo;
        private System.Windows.Forms.Label lblTBValor;
        private System.Windows.Forms.ProgressBar progressBarTrabajo;
        private System.Windows.Forms.Button btnCalculo;
    }
}

