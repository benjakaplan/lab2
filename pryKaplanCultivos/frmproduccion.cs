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
using System.Globalization;

namespace pryKaplanCultivos
{
  

    public partial class frmproduccion : Form
    {
        public frmproduccion()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            cmdCargar.Enabled = false;

            lblMostrarFecha.Text = DateTime.Now.ToString();

            StreamReader srLocalidad = new StreamReader("./Localidades.txt");

            StreamReader srCultivos = new StreamReader("./Cultivos.txt");

            char varSeparador = Convert.ToChar(",");

            while (!srLocalidad.EndOfStream)
            {
                string[] vecNombreLocalidad = srLocalidad.ReadLine().Split(varSeparador);
                lstLocalidad.Items.Add(vecNombreLocalidad[1]);

            }
            srLocalidad.Close();

            while (!srCultivos.EndOfStream)
            {
                string[] vecnombreCultivos = srCultivos.ReadLine().Split(varSeparador);
                lstCultivo.Items.Add(vecnombreCultivos[1]);

            }
            srCultivos.Close();
        }

        private void lstLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLocalidad.Text != "" && lstCultivo.Text != "" && txtCantidad.Text != "")
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
            }
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (lstLocalidad.Text != "" && lstCultivo.Text != "" && txtCantidad.Text != "")
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
            }
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            StreamWriter swToneladas = new StreamWriter("./Toneladas.txt", true);

            swToneladas.Close();

            StreamWriter swCargar = new StreamWriter("./Toneladas.txt", true);

            swCargar.WriteLine(lstLocalidad.Text + "," + lstCultivo.Text + "," + txtCantidad.Text);

            swCargar.Close();

            MessageBox.Show("Archivo cargado correctamente");

            lstLocalidad.Text = "";

            lstCultivo.Text = "";

            txtCantidad.Text = "";

            lstLocalidad.Focus();

        }
    }
  
}
