using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryKaplanClase1
{
    public partial class Ventas : Form
    {

        public Ventas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            StreamWriter swVent = new StreamWriter("./Ventas.txt", true);
            swVent.Close();
            char separador = Convert.ToChar(",");
            if (File.Exists("./cliente.txt") && File.Exists("./Vendedor.txt"))
            {
                StreamReader srClientes = new StreamReader("./cliente.txt");
                StreamReader srVendedor = new StreamReader("./Vendedor.txt");
                while (!srClientes.EndOfStream)
                {
                    string[] arrayClientes = srClientes.ReadLine().Split(separador);
                    cboCliente.Items.Add(arrayClientes[0]);
                }
                while (!srVendedor.EndOfStream)
                {
                    string[] arrayVendedor = srVendedor.ReadLine().Split(separador);
                    cboVendedor.Items.Add(arrayVendedor[0]);
                }
                srClientes.Close();
                srVendedor.Close();
            }
            else
            {
                MessageBox.Show("Los archivos no existen, carguelos");
                this.Close();
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value < DateTime.Today)
            {
                StreamWriter swVentas = new StreamWriter("./Ventas.txt", true);
                swVentas.WriteLine(cboCliente.Text + "," + cboVendedor.Text + "," + dtpFecha.Text + "," + cboTipoFactura.Text + "," + nudFactura.Text + "," + nudMonto.Text);
                swVentas.Close();
                MessageBox.Show("Datos ingresados con exito");
                nudFactura.Value = 0;
                nudMonto.Value = 0;
            }
            else
            {
                MessageBox.Show("Ingrese una fecha valida");
            }
        }
    }
}
