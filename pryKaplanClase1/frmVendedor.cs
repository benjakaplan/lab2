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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int idVendedor;
            string NombreVendedor;
            string Activo = "", CobraComision = "";
            char separador = Convert.ToChar(",");
            bool bandera = false;

            idVendedor = Convert.ToInt32(nudIDVendedor.Text);
            NombreVendedor = txtNombreVendedor.Text;


            switch (cboActivo.Text)
            {
                case "Si":
                    Activo = "0";
                    break;
                case "No":
                    Activo = "-1";
                    break;
            }
            switch (cboCobra.Text)
            {
                case "Si":
                    CobraComision = "0";
                    break;
                case "No":
                    CobraComision = "-1";
                    break;
            }
            StreamReader srVendedor = new StreamReader("./Vendedor.txt");
            while (!srVendedor.EndOfStream && bandera == false)
            {
                string[] arrayVendedor = srVendedor.ReadLine().Split(separador);
                int idVendedorRepetido = Convert.ToInt32(arrayVendedor[0]);

                if (idVendedorRepetido == idVendedor)
                {
                    MessageBox.Show("Esta ID ya esta registrada");
                    bandera = true;
                    nudIDVendedor.Value = 0;
                    txtNombreVendedor.Text = "";
                    cboActivo.Items.Clear();
                    cboCobra.Items.Clear();
                    nudIDVendedor.Focus();
                }
            }
            srVendedor.Close();
            if (bandera == false)
            {
                if (idVendedor != 0 && NombreVendedor != "" && Activo != " " && CobraComision != "")
                {
                    StreamWriter swVendedor = new StreamWriter("./Vendedor.txt", true);

                    swVendedor.WriteLine(idVendedor + "," + NombreVendedor + "," + Activo + "," + CobraComision);
                    swVendedor.Close();
                    MessageBox.Show("Datos ingresados con exito");

                    nudIDVendedor.Value = 0;
                    txtNombreVendedor.Text = "";
                    cboActivo.Items.Clear();
                    cboCobra.Items.Clear();

                }
                else
                {
                    MessageBox.Show("Complete todos los datos!");
                }
            }
    }
        private void frmVendedor_Load(object sender, EventArgs e)
        {
            StreamWriter swVendedo = new StreamWriter("./Vendedor.txt", true);
            swVendedo.Close();
        }
    
}
