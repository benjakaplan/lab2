namespace pryKaplanClase1
{
    partial class Consultaclientes
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
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.dgvConsultaCliente = new System.Windows.Forms.DataGridView();
            this.idnombrecliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(496, 121);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(91, 23);
            this.btnConsultarCliente.TabIndex = 3;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaCliente
            // 
            this.dgvConsultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnombrecliente,
            this.nombreCliente});
            this.dgvConsultaCliente.Location = new System.Drawing.Point(29, 38);
            this.dgvConsultaCliente.Name = "dgvConsultaCliente";
            this.dgvConsultaCliente.Size = new System.Drawing.Size(386, 161);
            this.dgvConsultaCliente.TabIndex = 2;
            this.dgvConsultaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaCliente_CellContentClick);
            // 
            // idnombrecliente
            // 
            this.idnombrecliente.HeaderText = "ID Cliente";
            this.idnombrecliente.Name = "idnombrecliente";
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "Nombre Cliente";
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Width = 150;
            // 
            // Consultaclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 264);
            this.Controls.Add(this.btnConsultarCliente);
            this.Controls.Add(this.dgvConsultaCliente);
            this.Name = "Consultaclientes";
            this.Text = "Consultaclientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.DataGridView dgvConsultaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnombrecliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
    }
}