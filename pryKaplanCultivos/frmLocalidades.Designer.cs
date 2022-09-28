namespace pryKaplanCultivos
{
    partial class frmLocalidades
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
            this.txtCodigoLocalidad = new System.Windows.Forms.MaskedTextBox();
            this.cmdCargarLocalidad = new System.Windows.Forms.Button();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblCodigoLocalidad = new System.Windows.Forms.Label();
            this.txtNombreLocalidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCodigoLocalidad
            // 
            this.txtCodigoLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoLocalidad.Location = new System.Drawing.Point(238, 83);
            this.txtCodigoLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoLocalidad.Mask = "99999";
            this.txtCodigoLocalidad.Name = "txtCodigoLocalidad";
            this.txtCodigoLocalidad.Size = new System.Drawing.Size(67, 20);
            this.txtCodigoLocalidad.TabIndex = 15;
            this.txtCodigoLocalidad.ValidatingType = typeof(int);
            this.txtCodigoLocalidad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCodigoLocalidad_MaskInputRejected);
            // 
            // cmdCargarLocalidad
            // 
            this.cmdCargarLocalidad.AccessibleDescription = "";
            this.cmdCargarLocalidad.Location = new System.Drawing.Point(344, 108);
            this.cmdCargarLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCargarLocalidad.Name = "cmdCargarLocalidad";
            this.cmdCargarLocalidad.Size = new System.Drawing.Size(63, 25);
            this.cmdCargarLocalidad.TabIndex = 14;
            this.cmdCargarLocalidad.Text = "Cargar";
            this.cmdCargarLocalidad.UseVisualStyleBackColor = true;
            this.cmdCargarLocalidad.Click += new System.EventHandler(this.cmdCargarLocalidad_Click);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLocalidad.Location = new System.Drawing.Point(156, 150);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 13;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblCodigoLocalidad
            // 
            this.lblCodigoLocalidad.AutoSize = true;
            this.lblCodigoLocalidad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCodigoLocalidad.Location = new System.Drawing.Point(156, 90);
            this.lblCodigoLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoLocalidad.Name = "lblCodigoLocalidad";
            this.lblCodigoLocalidad.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoLocalidad.TabIndex = 12;
            this.lblCodigoLocalidad.Text = "Codigo";
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreLocalidad.Location = new System.Drawing.Point(238, 143);
            this.txtNombreLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(67, 20);
            this.txtNombreLocalidad.TabIndex = 11;
            this.txtNombreLocalidad.TextChanged += new System.EventHandler(this.txtNombreLocalidad_TextChanged);
            // 
            // frmLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigoLocalidad);
            this.Controls.Add(this.cmdCargarLocalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblCodigoLocalidad);
            this.Controls.Add(this.txtNombreLocalidad);
            this.Name = "frmLocalidades";
            this.Text = "frmLocalidades";
            this.Load += new System.EventHandler(this.frmLocalidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCodigoLocalidad;
        private System.Windows.Forms.Button cmdCargarLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblCodigoLocalidad;
        private System.Windows.Forms.TextBox txtNombreLocalidad;
    }
}