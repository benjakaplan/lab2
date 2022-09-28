namespace pryKaplanCultivos
{
    partial class frmproduccion
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
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.lstCultivo = new System.Windows.Forms.ComboBox();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombreCultivo = new System.Windows.Forms.Label();
            this.lblNombreLocalidad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(258, 198);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Mask = "99999";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 22;
            this.txtCantidad.ValidatingType = typeof(int);
            this.txtCantidad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCantidad_MaskInputRejected);
            // 
            // lstCultivo
            // 
            this.lstCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCultivo.FormattingEnabled = true;
            this.lstCultivo.Location = new System.Drawing.Point(258, 156);
            this.lstCultivo.Name = "lstCultivo";
            this.lstCultivo.Size = new System.Drawing.Size(121, 21);
            this.lstCultivo.TabIndex = 21;
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(258, 113);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(121, 21);
            this.lstLocalidad.TabIndex = 20;
            this.lstLocalidad.SelectedIndexChanged += new System.EventHandler(this.lstLocalidad_SelectedIndexChanged);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(511, 139);
            this.cmdCargar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(61, 30);
            this.cmdCargar.TabIndex = 19;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCantidad.Location = new System.Drawing.Point(128, 198);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 18;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // lblNombreCultivo
            // 
            this.lblNombreCultivo.AccessibleDescription = "";
            this.lblNombreCultivo.AutoSize = true;
            this.lblNombreCultivo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombreCultivo.Location = new System.Drawing.Point(128, 156);
            this.lblNombreCultivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCultivo.Name = "lblNombreCultivo";
            this.lblNombreCultivo.Size = new System.Drawing.Size(42, 13);
            this.lblNombreCultivo.TabIndex = 17;
            this.lblNombreCultivo.Text = "Cultivo:";
            // 
            // lblNombreLocalidad
            // 
            this.lblNombreLocalidad.AutoSize = true;
            this.lblNombreLocalidad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombreLocalidad.Location = new System.Drawing.Point(128, 113);
            this.lblNombreLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreLocalidad.Name = "lblNombreLocalidad";
            this.lblNombreLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblNombreLocalidad.TabIndex = 16;
            this.lblNombreLocalidad.Text = "Localidad:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFecha.Location = new System.Drawing.Point(137, 79);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 13);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblMostrarFecha
            // 
            this.lblMostrarFecha.AutoSize = true;
            this.lblMostrarFecha.Location = new System.Drawing.Point(255, 79);
            this.lblMostrarFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMostrarFecha.Name = "lblMostrarFecha";
            this.lblMostrarFecha.Size = new System.Drawing.Size(28, 13);
            this.lblMostrarFecha.TabIndex = 14;
            this.lblMostrarFecha.Text = "-------";
            // 
            // frmproduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lstCultivo);
            this.Controls.Add(this.lstLocalidad);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombreCultivo);
            this.Controls.Add(this.lblNombreLocalidad);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblMostrarFecha);
            this.Name = "frmproduccion";
            this.Text = "frmproduccion";
            this.Load += new System.EventHandler(this.frmproduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCantidad;
        private System.Windows.Forms.ComboBox lstCultivo;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNombreCultivo;
        private System.Windows.Forms.Label lblNombreLocalidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMostrarFecha;
    }
}