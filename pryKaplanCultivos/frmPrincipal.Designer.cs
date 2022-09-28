namespace pryKaplanCultivos
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalidad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCultivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProduccion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMantenimiento,
            this.tsmConsulta});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmMantenimiento
            // 
            this.tsmMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLocalidad,
            this.tsmCultivo,
            this.tsmProduccion,
            this.tsmSalir});
            this.tsmMantenimiento.Name = "tsmMantenimiento";
            this.tsmMantenimiento.Size = new System.Drawing.Size(101, 22);
            this.tsmMantenimiento.Text = "Mantenimiento";
            // 
            // tsmLocalidad
            // 
            this.tsmLocalidad.Name = "tsmLocalidad";
            this.tsmLocalidad.Size = new System.Drawing.Size(180, 22);
            this.tsmLocalidad.Text = "Localidad";
            this.tsmLocalidad.Click += new System.EventHandler(this.tsmLocalidad_Click);
            // 
            // tsmCultivo
            // 
            this.tsmCultivo.Name = "tsmCultivo";
            this.tsmCultivo.Size = new System.Drawing.Size(180, 22);
            this.tsmCultivo.Text = "Cultivos";
            this.tsmCultivo.Click += new System.EventHandler(this.tsmCultivo_Click);
            // 
            // tsmProduccion
            // 
            this.tsmProduccion.Name = "tsmProduccion";
            this.tsmProduccion.Size = new System.Drawing.Size(180, 22);
            this.tsmProduccion.Text = "Producción";
            this.tsmProduccion.Click += new System.EventHandler(this.tsmProduccion_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(180, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // tsmConsulta
            // 
            this.tsmConsulta.Name = "tsmConsulta";
            this.tsmConsulta.Size = new System.Drawing.Size(66, 22);
            this.tsmConsulta.Text = "Consulta";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPrincipal";
            this.Text = "frmprincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem tsmLocalidad;
        private System.Windows.Forms.ToolStripMenuItem tsmCultivo;
        private System.Windows.Forms.ToolStripMenuItem tsmProduccion;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmConsulta;
    }
}