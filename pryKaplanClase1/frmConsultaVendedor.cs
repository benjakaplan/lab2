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
    public partial class frmConsultaVendedor : Form
    {
        string[,] matConsultaVendedor = new string[100, 4];
        public frmConsultaVendedor()
        {
           
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
             int f = 0;
            char separador = Convert.ToChar(",");
            StreamReader srConsultaVendedor = new StreamReader("./Vendedor.txt");


            while (!srConsultaVendedor.EndOfStream)
            {
                string[] arrayConsultaVendedor = srConsultaVendedor.ReadLine().Split(separador);
                matConsultaVendedor[f,0] = arrayConsultaVendedor[0];
                matConsultaVendedor [f,1] = arrayConsultaVendedor[1];
                matConsultaVendedor[f,2] = arrayConsultaVendedor[2];
                matConsultaVendedor[f, 3] = arrayConsultaVendedor[3];

                dgvConsultaVendedor.Rows.Add(matConsultaVendedor[f,0], matConsultaVendedor[f,1], matConsultaVendedor[f,2], matConsultaVendedor[f,3]);
                f++;
            }
        }
    }
}
