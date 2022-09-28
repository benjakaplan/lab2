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
namespace pryKaplanCultivos
{
    public partial class frmCultivo : Form
    {
        public frmCultivo()
        {
            InitializeComponent();
        }

        private void cmdCargarCultivo_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            StreamWriter swLocalidades = new StreamWriter("./Cultivos.txt", true);

            swLocalidades.Close();

            StreamReader srNumeros = new StreamReader("./Cultivos.txt");

            char varSeparador = Convert.ToChar(",");

            while (!srNumeros.EndOfStream)
            {
                string[] vecNombreNumeros = srNumeros.ReadLine().Split(varSeparador);

                if (txtCodigoCultivo.Text == vecNombreNumeros[0])
                {
                    MessageBox.Show("El archivo no pudo cargarse");

                    bandera = true;
                }
            }

            srNumeros.Close();

            if (bandera == false)
            {
                StreamWriter swGrabar = new StreamWriter("./Cultivos.txt", true);

                swGrabar.WriteLine(txtCodigoCultivo.Text + "," + txtNombreCultivo.Text);

                swGrabar.Close();

                MessageBox.Show("Archivo cargado correctamente");

                txtCodigoCultivo.Text = "";

                txtNombreCultivo.Text = "";

                txtCodigoCultivo.Focus();
            }

            else
            {
                txtCodigoCultivo.Text = "";

                txtNombreCultivo.Text = "";

                txtCodigoCultivo.Focus();
            }
        }

        private void frmCultivo_Load(object sender, EventArgs e)
        {
            cmdCargarCultivo.Enabled = false;
        }

        private void txtNombreCultivo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoCultivo.Text != "" && txtNombreCultivo.Text != "")
            {
                cmdCargarCultivo.Enabled = true;
            }
            else
            {
                cmdCargarCultivo.Enabled = false;
            }
        }

        private void txtCodigoCultivo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtCodigoCultivo.Text != "" && txtNombreCultivo.Text != "")
            {
                cmdCargarCultivo.Enabled = true;
            }
            else
            {
                cmdCargarCultivo.Enabled = false;
            }
        }
    }
}
