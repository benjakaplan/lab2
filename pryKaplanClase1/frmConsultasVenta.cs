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
    public partial class frmConsultasVenta : Form
    {
        string[,] matConsultaVentas = new string[100, 6];
        public frmConsultasVenta()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvConsultaVentas.Rows.Clear();
            int f = 0;
            char separador = Convert.ToChar(",");

            StreamReader srConsultaVentas = new StreamReader("./Ventas.txt");
            while (!srConsultaVentas.EndOfStream)
            {
                string[] arrayConsultaVentas = srConsultaVentas.ReadLine().Split(separador);
                matConsultaVentas[f, 0] = arrayConsultaVentas[3];
                matConsultaVentas[f, 1] = arrayConsultaVentas[4];
                matConsultaVentas[f, 2] = arrayConsultaVentas[2];
                matConsultaVentas[f, 3] = arrayConsultaVentas[0];
                matConsultaVentas[f, 4] = arrayConsultaVentas[1];
                matConsultaVentas[f, 5] = arrayConsultaVentas[5];

                dgvConsultaVentas.Rows.Add(matConsultaVentas[f, 0], matConsultaVentas[f, 1], matConsultaVentas[f, 2], matConsultaVentas[f, 3], matConsultaVentas[f, 4]
                , matConsultaVentas[f, 5]);
                f++;
            }
        }
    }
}
