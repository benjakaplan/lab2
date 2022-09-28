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
    public partial class Consultaclientes : Form

    {
        string[,] matConsultaCliente = new string[100, 2];
        public Consultaclientes()
        {
            InitializeComponent();
        }

        private void dgvConsultaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvConsultaCliente.Rows.Clear();
            char separador = Convert.ToChar(",");
            StreamReader srConsultarCliente = new StreamReader("./cliente.txt");
            int f = 0;
            while (!srConsultarCliente.EndOfStream)
            {
                string[] arrayConsultaCliente = srConsultarCliente.ReadLine().Split(separador);
                matConsultaCliente[f, 0] = arrayConsultaCliente[0];
                matConsultaCliente[f, 1] = arrayConsultaCliente[1];
                dgvConsultaCliente.Rows.Add(matConsultaCliente[f, 0], matConsultaCliente[f, 1]);
                f++;
            }
        }
    }
}
