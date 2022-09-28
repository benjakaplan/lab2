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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int varIDCliente;
            string varNombreCliente;
            char separador = Convert.ToChar(",");
            bool bandera = false;

            varIDCliente = Convert.ToInt32(nudIDCliente.Text);
            varNombreCliente = txtNombre.Text;

            StreamReader srCliente = new StreamReader("./cliente.txt");
            while (!srCliente.EndOfStream && bandera == false)
            {
                string[] arrayCliente = srCliente.ReadLine().Split(separador);
                int idClienteRepetido = Convert.ToInt32(arrayCliente[0]);

                if (idClienteRepetido == varIDCliente)
                {
                    MessageBox.Show("Esta ID ya esta registrada");
                    bandera = true;
                }
            }
            srCliente.Close();
            if (varIDCliente != 0 && varNombreCliente != "")
            {
                if (bandera == false)
                {
                    using (StreamWriter swCliente = new StreamWriter("./cliente.txt", true))
                    {
                        swCliente.WriteLine(varIDCliente + "," + varNombreCliente);
                        swCliente.Close();
                        MessageBox.Show("Agregado con exito");
                        nudIDCliente.Value = 0;
                        txtNombre.Text = "";
                        txtNombre.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese datos validos");
            }
        }
    }
    private void FrmClientes_Load(object sender, EventArgs e)
    {
        StreamWriter swClient = new StreamWriter("./cliente.txt", true);
        swClient.Close();
    }
}
