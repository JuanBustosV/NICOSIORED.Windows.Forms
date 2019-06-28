namespace Programa02_04
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxtMensaje = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.toolTipBtnSalir = new System.Windows.Forms.ToolTip(this.components);
            this.TxtContenido = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.toolTipBtnCancel = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // TxtMensaje
            // 
            this.TxtMensaje.Location = new System.Drawing.Point(24, 31);
            this.TxtMensaje.Name = "TxtMensaje";
            this.TxtMensaje.Size = new System.Drawing.Size(157, 20);
            this.TxtMensaje.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.BtnSalir.Location = new System.Drawing.Point(24, 107);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // toolTipBtnSalir
            // 
            this.toolTipBtnSalir.Tag = "";
            this.toolTipBtnSalir.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipBtnSalir.ToolTipTitle = "Ayuda:";
            // 
            // TxtContenido
            // 
            this.TxtContenido.Location = new System.Drawing.Point(24, 68);
            this.TxtContenido.Name = "TxtContenido";
            this.TxtContenido.Size = new System.Drawing.Size(157, 20);
            this.TxtContenido.TabIndex = 2;
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(241, 29);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 3;
            this.BtnOk.Text = "&OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(241, 66);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "&Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // toolTipBtnCancel
            // 
            this.toolTipBtnCancel.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipBtnCancel.ToolTipTitle = "Ayuda";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 152);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TxtContenido);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtMensaje);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMensaje;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ToolTip toolTipBtnSalir;
        private System.Windows.Forms.TextBox TxtContenido;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ToolTip toolTipBtnCancel;
    }
}