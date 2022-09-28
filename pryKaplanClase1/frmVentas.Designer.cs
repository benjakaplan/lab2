namespace pryKaplanClase1
{
    partial class Ventas
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.nudFactura = new System.Windows.Forms.NumericUpDown();
            this.cboTipoFactura = new System.Windows.Forms.ComboBox();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFacturaNumero = new System.Windows.Forms.Label();
            this.lblFacturaTipo = new System.Windows.Forms.Label();
            this.lblidvendedor = new System.Windows.Forms.Label();
            this.lblidCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFecha.Location = new System.Drawing.Point(53, 141);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(84, 25);
            this.lblFecha.TabIndex = 25;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(293, 135);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(145, 31);
            this.dtpFecha.TabIndex = 24;
            // 
            // nudMonto
            // 
            this.nudMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMonto.Location = new System.Drawing.Point(293, 288);
            this.nudMonto.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(145, 31);
            this.nudMonto.TabIndex = 23;
            // 
            // nudFactura
            // 
            this.nudFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFactura.Location = new System.Drawing.Point(293, 243);
            this.nudFactura.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFactura.Name = "nudFactura";
            this.nudFactura.Size = new System.Drawing.Size(144, 31);
            this.nudFactura.TabIndex = 22;
            // 
            // cboTipoFactura
            // 
            this.cboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoFactura.FormattingEnabled = true;
            this.cboTipoFactura.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboTipoFactura.Location = new System.Drawing.Point(293, 189);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(146, 33);
            this.cboTipoFactura.TabIndex = 21;
            // 
            // cboVendedor
            // 
            this.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(293, 86);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(146, 33);
            this.cboVendedor.TabIndex = 20;
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(293, 41);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(146, 33);
            this.cboCliente.TabIndex = 19;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(547, 167);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(94, 34);
            this.btnCargar.TabIndex = 18;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMonto.Location = new System.Drawing.Point(53, 290);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(84, 25);
            this.lblMonto.TabIndex = 17;
            this.lblMonto.Text = "Monto:";
            // 
            // lblFacturaNumero
            // 
            this.lblFacturaNumero.AutoSize = true;
            this.lblFacturaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaNumero.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFacturaNumero.Location = new System.Drawing.Point(53, 245);
            this.lblFacturaNumero.Name = "lblFacturaNumero";
            this.lblFacturaNumero.Size = new System.Drawing.Size(220, 25);
            this.lblFacturaNumero.TabIndex = 16;
            this.lblFacturaNumero.Text = "Numero de Factura:";
            // 
            // lblFacturaTipo
            // 
            this.lblFacturaTipo.AutoSize = true;
            this.lblFacturaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaTipo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFacturaTipo.Location = new System.Drawing.Point(53, 192);
            this.lblFacturaTipo.Name = "lblFacturaTipo";
            this.lblFacturaTipo.Size = new System.Drawing.Size(185, 25);
            this.lblFacturaTipo.TabIndex = 15;
            this.lblFacturaTipo.Text = "Tipo de Factura:";
            // 
            // lblidvendedor
            // 
            this.lblidvendedor.AutoSize = true;
            this.lblidvendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidvendedor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblidvendedor.Location = new System.Drawing.Point(53, 89);
            this.lblidvendedor.Name = "lblidvendedor";
            this.lblidvendedor.Size = new System.Drawing.Size(120, 25);
            this.lblidvendedor.TabIndex = 14;
            this.lblidvendedor.Text = "Vendedor:";
            // 
            // lblidCliente
            // 
            this.lblidCliente.AutoSize = true;
            this.lblidCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidCliente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblidCliente.Location = new System.Drawing.Point(53, 44);
            this.lblidCliente.Name = "lblidCliente";
            this.lblidCliente.Size = new System.Drawing.Size(93, 25);
            this.lblidCliente.TabIndex = 13;
            this.lblidCliente.Text = "Cliente:";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.nudMonto);
            this.Controls.Add(this.nudFactura);
            this.Controls.Add(this.cboTipoFactura);
            this.Controls.Add(this.cboVendedor);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblFacturaNumero);
            this.Controls.Add(this.lblFacturaTipo);
            this.Controls.Add(this.lblidvendedor);
            this.Controls.Add(this.lblidCliente);
            this.Name = "Ventas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.NumericUpDown nudFactura;
        private System.Windows.Forms.ComboBox cboTipoFactura;
        private System.Windows.Forms.ComboBox cboVendedor;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFacturaNumero;
        private System.Windows.Forms.Label lblFacturaTipo;
        private System.Windows.Forms.Label lblidvendedor;
        private System.Windows.Forms.Label lblidCliente;
    }
}