namespace pryKaplanClase1
{
    partial class frmVendedor
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
            this.cboCobra = new System.Windows.Forms.ComboBox();
            this.cboActivo = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblCobraComision = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.nudIDVendedor = new System.Windows.Forms.NumericUpDown();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.lblIdVendedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudIDVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCobra
            // 
            this.cboCobra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCobra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCobra.FormattingEnabled = true;
            this.cboCobra.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cboCobra.Location = new System.Drawing.Point(307, 244);
            this.cboCobra.Name = "cboCobra";
            this.cboCobra.Size = new System.Drawing.Size(121, 33);
            this.cboCobra.TabIndex = 19;
            // 
            // cboActivo
            // 
            this.cboActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActivo.FormattingEnabled = true;
            this.cboActivo.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cboActivo.Location = new System.Drawing.Point(307, 181);
            this.cboActivo.Name = "cboActivo";
            this.cboActivo.Size = new System.Drawing.Size(121, 33);
            this.cboActivo.TabIndex = 18;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(611, 149);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(102, 35);
            this.btnCrear.TabIndex = 17;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblCobraComision
            // 
            this.lblCobraComision.AutoSize = true;
            this.lblCobraComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCobraComision.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCobraComision.Location = new System.Drawing.Point(81, 247);
            this.lblCobraComision.Name = "lblCobraComision";
            this.lblCobraComision.Size = new System.Drawing.Size(179, 25);
            this.lblCobraComision.TabIndex = 16;
            this.lblCobraComision.Text = "Cobra Comision";
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblActivo.Location = new System.Drawing.Point(81, 184);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(77, 25);
            this.lblActivo.TabIndex = 15;
            this.lblActivo.Text = "Activo";
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVendedor.Location = new System.Drawing.Point(305, 110);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(227, 31);
            this.txtNombreVendedor.TabIndex = 14;
            // 
            // nudIDVendedor
            // 
            this.nudIDVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIDVendedor.Location = new System.Drawing.Point(307, 62);
            this.nudIDVendedor.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudIDVendedor.Name = "nudIDVendedor";
            this.nudIDVendedor.Size = new System.Drawing.Size(120, 31);
            this.nudIDVendedor.TabIndex = 13;
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombreVendedor.Location = new System.Drawing.Point(81, 113);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(201, 25);
            this.lblNombreVendedor.TabIndex = 12;
            this.lblNombreVendedor.Text = "Nombre Vendedor";
            // 
            // lblIdVendedor
            // 
            this.lblIdVendedor.AutoSize = true;
            this.lblIdVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVendedor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIdVendedor.Location = new System.Drawing.Point(81, 64);
            this.lblIdVendedor.Name = "lblIdVendedor";
            this.lblIdVendedor.Size = new System.Drawing.Size(142, 25);
            this.lblIdVendedor.TabIndex = 11;
            this.lblIdVendedor.Text = "ID Vendedor";
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboCobra);
            this.Controls.Add(this.cboActivo);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblCobraComision);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.nudIDVendedor);
            this.Controls.Add(this.lblNombreVendedor);
            this.Controls.Add(this.lblIdVendedor);
            this.Name = "frmVendedor";
            this.Text = "frmVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.nudIDVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCobra;
        private System.Windows.Forms.ComboBox cboActivo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblCobraComision;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.NumericUpDown nudIDVendedor;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblIdVendedor;
    }
}