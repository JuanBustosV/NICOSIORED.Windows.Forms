namespace Programa03_01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.CMnuTxtA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.toolStripOperaciones = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSuma = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonResta = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMulti = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDiv = new System.Windows.Forms.ToolStripButton();
            this.statusStripInformacion = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelValores = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelOperacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelResultado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.CMnuTxtA.SuspendLayout();
            this.toolStripOperaciones.SuspendLayout();
            this.statusStripInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.AutoToolTip = true;
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.SalirToolStripMenuItem.Text = "&Salir";
            this.SalirToolStripMenuItem.ToolTipText = "Cerrar la aplicación";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem,
            this.multiplicaciónToolStripMenuItem,
            this.divisiónToolStripMenuItem,
            this.toolStripSeparator1,
            this.habilitarToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "&Operaciones";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.sumaToolStripMenuItem.Text = "S&uma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.restaToolStripMenuItem.Text = "&Resta";
            this.restaToolStripMenuItem.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // multiplicaciónToolStripMenuItem
            // 
            this.multiplicaciónToolStripMenuItem.Name = "multiplicaciónToolStripMenuItem";
            this.multiplicaciónToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.multiplicaciónToolStripMenuItem.Text = "&Multiplicación";
            this.multiplicaciónToolStripMenuItem.Click += new System.EventHandler(this.multiplicacionToolStripMenuItem_Click);
            // 
            // divisiónToolStripMenuItem
            // 
            this.divisiónToolStripMenuItem.Name = "divisiónToolStripMenuItem";
            this.divisiónToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.divisiónToolStripMenuItem.Text = "&División";
            this.divisiónToolStripMenuItem.Click += new System.EventHandler(this.divisionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Checked = true;
            this.habilitarToolStripMenuItem.CheckOnClick = true;
            this.habilitarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.habilitarToolStripMenuItem.Text = "Habilitar";
            this.habilitarToolStripMenuItem.CheckedChanged += new System.EventHandler(this.habilitarToolStripMenuItem_CheckedChanged);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "A&yuda";
            // 
            // AcercaDeToolStripMenuItem
            // 
            this.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem";
            this.AcercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.AcercaDeToolStripMenuItem.Text = "A&cerca de...";
            this.AcercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
            // 
            // TxtA
            // 
            this.TxtA.ContextMenuStrip = this.CMnuTxtA;
            this.TxtA.Location = new System.Drawing.Point(12, 57);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(100, 20);
            this.TxtA.TabIndex = 1;
            this.TxtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CMnuTxtA
            // 
            this.CMnuTxtA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarToolStripMenuItem,
            this.aleatorioToolStripMenuItem});
            this.CMnuTxtA.Name = "CMnuTxtA";
            this.CMnuTxtA.Size = new System.Drawing.Size(123, 48);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.borrarToolStripMenuItem.Text = "&Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // aleatorioToolStripMenuItem
            // 
            this.aleatorioToolStripMenuItem.Name = "aleatorioToolStripMenuItem";
            this.aleatorioToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aleatorioToolStripMenuItem.Text = "A&leatorio";
            this.aleatorioToolStripMenuItem.Click += new System.EventHandler(this.aleatorioToolStripMenuItem_Click);
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(12, 84);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(100, 20);
            this.TxtB.TabIndex = 2;
            this.TxtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(227, 60);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(35, 13);
            this.LblResultado.TabIndex = 3;
            this.LblResultado.Text = "label1";
            // 
            // toolStripOperaciones
            // 
            this.toolStripOperaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSuma,
            this.toolStripButtonResta,
            this.toolStripButtonMulti,
            this.toolStripButtonDiv});
            this.toolStripOperaciones.Location = new System.Drawing.Point(0, 24);
            this.toolStripOperaciones.Name = "toolStripOperaciones";
            this.toolStripOperaciones.Size = new System.Drawing.Size(441, 25);
            this.toolStripOperaciones.TabIndex = 4;
            this.toolStripOperaciones.Text = "toolStrip1";
            // 
            // toolStripButtonSuma
            // 
            this.toolStripButtonSuma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSuma.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSuma.Image")));
            this.toolStripButtonSuma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSuma.Name = "toolStripButtonSuma";
            this.toolStripButtonSuma.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSuma.Text = "Suma";
            this.toolStripButtonSuma.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // toolStripButtonResta
            // 
            this.toolStripButtonResta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonResta.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonResta.Image")));
            this.toolStripButtonResta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonResta.Name = "toolStripButtonResta";
            this.toolStripButtonResta.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonResta.Text = "Resta";
            this.toolStripButtonResta.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // toolStripButtonMulti
            // 
            this.toolStripButtonMulti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMulti.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMulti.Image")));
            this.toolStripButtonMulti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMulti.Name = "toolStripButtonMulti";
            this.toolStripButtonMulti.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMulti.Text = "Multiplicación";
            this.toolStripButtonMulti.Click += new System.EventHandler(this.multiplicacionToolStripMenuItem_Click);
            // 
            // toolStripButtonDiv
            // 
            this.toolStripButtonDiv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDiv.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDiv.Image")));
            this.toolStripButtonDiv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDiv.Name = "toolStripButtonDiv";
            this.toolStripButtonDiv.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDiv.Text = "División";
            this.toolStripButtonDiv.Click += new System.EventHandler(this.divisionToolStripMenuItem_Click);
            // 
            // statusStripInformacion
            // 
            this.statusStripInformacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelValores,
            this.toolStripStatusLabelOperacion,
            this.toolStripStatusLabelResultado});
            this.statusStripInformacion.Location = new System.Drawing.Point(0, 242);
            this.statusStripInformacion.Name = "statusStripInformacion";
            this.statusStripInformacion.Size = new System.Drawing.Size(441, 24);
            this.statusStripInformacion.TabIndex = 5;
            this.statusStripInformacion.Text = "statusStrip1";
            // 
            // toolStripStatusLabelValores
            // 
            this.toolStripStatusLabelValores.AutoSize = false;
            this.toolStripStatusLabelValores.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelValores.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabelValores.Name = "toolStripStatusLabelValores";
            this.toolStripStatusLabelValores.Size = new System.Drawing.Size(100, 19);
            this.toolStripStatusLabelValores.Text = "A=0, B=0";
            // 
            // toolStripStatusLabelOperacion
            // 
            this.toolStripStatusLabelOperacion.AutoSize = false;
            this.toolStripStatusLabelOperacion.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelOperacion.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.toolStripStatusLabelOperacion.Name = "toolStripStatusLabelOperacion";
            this.toolStripStatusLabelOperacion.Size = new System.Drawing.Size(90, 19);
            this.toolStripStatusLabelOperacion.Text = "Sin seleccionar";
            // 
            // toolStripStatusLabelResultado
            // 
            this.toolStripStatusLabelResultado.AutoSize = false;
            this.toolStripStatusLabelResultado.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelResultado.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.toolStripStatusLabelResultado.Name = "toolStripStatusLabelResultado";
            this.toolStripStatusLabelResultado.Size = new System.Drawing.Size(50, 19);
            this.toolStripStatusLabelResultado.Text = "R=0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 266);
            this.Controls.Add(this.statusStripInformacion);
            this.Controls.Add(this.toolStripOperaciones);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.TxtB);
            this.Controls.Add(this.TxtA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Windows Forms C# 14 - Menú en Windows Forms";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CMnuTxtA.ResumeLayout(false);
            this.toolStripOperaciones.ResumeLayout(false);
            this.toolStripOperaciones.PerformLayout();
            this.statusStripInformacion.ResumeLayout(false);
            this.statusStripInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AcercaDeToolStripMenuItem;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMnuTxtA;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripOperaciones;
        private System.Windows.Forms.ToolStripButton toolStripButtonSuma;
        private System.Windows.Forms.ToolStripButton toolStripButtonResta;
        private System.Windows.Forms.ToolStripButton toolStripButtonMulti;
        private System.Windows.Forms.ToolStripButton toolStripButtonDiv;
        private System.Windows.Forms.StatusStrip statusStripInformacion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelValores;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelOperacion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelResultado;
    }
}

