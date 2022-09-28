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
using System.Reflection;

namespace pryKaplanCultivos
{
    public partial class frmLocalidades : Form
    {
        public frmLocalidades()
        {
            InitializeComponent();
        }

        private void cmdCargarLocalidad_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            StreamWriter swLocalidades = new StreamWriter("./Localidades.txt", true);

            swLocalidades.Close();

            StreamReader srNumeros = new StreamReader("./Localidades.txt");

            char varSeparador = Convert.ToChar(",");

            while (!srNumeros.EndOfStream)
            {
                string[] vecNombreNumeros = srNumeros.ReadLine().Split(varSeparador);

                if (txtCodigoLocalidad.Text == vecNombreNumeros[0])
                {
                    MessageBox.Show("El archivo no pudo cargarse");

                    bandera = true;
                }
            }

            srNumeros.Close();

            if (bandera == false)
            {
                StreamWriter swGrabar = new StreamWriter("./Localidades.txt", true);

                swGrabar.WriteLine(txtCodigoLocalidad.Text + "," + txtNombreLocalidad.Text);

                swGrabar.Close();

                MessageBox.Show("Archivo cargado correctamente");

                txtCodigoLocalidad.Text = "";

                txtNombreLocalidad.Text = "";

                txtCodigoLocalidad.Focus();
            }

            else
            {
                txtCodigoLocalidad.Text = "";

                txtNombreLocalidad.Text = "";

                txtCodigoLocalidad.Focus();
            }

        }

        private void frmLocalidades_Load(object sender, EventArgs e)
        {
            cmdCargarLocalidad.Enabled = false;
        }

        private void txtNombreLocalidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoLocalidad.Text != "" && txtNombreLocalidad.Text != "")
            {
                cmdCargarLocalidad.Enabled = true;
            }
            else
            {
                cmdCargarLocalidad.Enabled = false;
            }
        }

        private void txtCodigoLocalidad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
             if (txtCodigoLocalidad.Text != "" && txtNombreLocalidad.Text != "")
            {
                cmdCargarLocalidad.Enabled = true;
            }
            else
            {
                cmdCargarLocalidad.Enabled = false;
            }
        }
    }
}
