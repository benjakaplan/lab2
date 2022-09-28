namespace pryKaplanCultivos
{
    partial class frmCultivo
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
            this.txtCodigoCultivo = new System.Windows.Forms.MaskedTextBox();
            this.cmdCargarCultivo = new System.Windows.Forms.Button();
            this.lblCultivo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombreCultivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCodigoCultivo
            // 
            this.txtCodigoCultivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoCultivo.Location = new System.Drawing.Point(236, 74);
            this.txtCodigoCultivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoCultivo.Mask = "99999";
            this.txtCodigoCultivo.Name = "txtCodigoCultivo";
            this.txtCodigoCultivo.Size = new System.Drawing.Size(67, 20);
            this.txtCodigoCultivo.TabIndex = 16;
            this.txtCodigoCultivo.ValidatingType = typeof(int);
            this.txtCodigoCultivo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCodigoCultivo_MaskInputRejected);
            // 
            // cmdCargarCultivo
            // 
            this.cmdCargarCultivo.AccessibleDescription = "";
            this.cmdCargarCultivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCargarCultivo.Location = new System.Drawing.Point(379, 96);
            this.cmdCargarCultivo.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCargarCultivo.Name = "cmdCargarCultivo";
            this.cmdCargarCultivo.Size = new System.Drawing.Size(63, 25);
            this.cmdCargarCultivo.TabIndex = 15;
            this.cmdCargarCultivo.Text = "Cargar";
            this.cmdCargarCultivo.UseVisualStyleBackColor = true;
            this.cmdCargarCultivo.Click += new System.EventHandler(this.cmdCargarCultivo_Click);
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCultivo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCultivo.Location = new System.Drawing.Point(157, 120);
            this.lblCultivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(39, 13);
            this.lblCultivo.TabIndex = 14;
            this.lblCultivo.Text = "Cultivo";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCodigo.Location = new System.Drawing.Point(156, 76);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 13;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtNombreCultivo
            // 
            this.txtNombreCultivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCultivo.Location = new System.Drawing.Point(236, 120);
            this.txtNombreCultivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCultivo.Name = "txtNombreCultivo";
            this.txtNombreCultivo.Size = new System.Drawing.Size(67, 20);
            this.txtNombreCultivo.TabIndex = 12;
            this.txtNombreCultivo.TextChanged += new System.EventHandler(this.txtNombreCultivo_TextChanged);
            // 
            // frmCultivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigoCultivo);
            this.Controls.Add(this.cmdCargarCultivo);
            this.Controls.Add(this.lblCultivo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNombreCultivo);
            this.Name = "frmCultivo";
            this.Text = "frmCultivo";
            this.Load += new System.EventHandler(this.frmCultivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCodigoCultivo;
        private System.Windows.Forms.Button cmdCargarCultivo;
        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombreCultivo;
    }
}