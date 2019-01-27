using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class VentanaLista : Form
    {
        public VentanaLista()
        {
            InitializeComponent();
        }

        private void VentanaLista_Load(object sender, EventArgs e)
        {

        }

        private void ListaIngresos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CerrarBoton_Click(object sender, EventArgs e)
        {

            this.Close();
            VentanaPrincipal ventana = new VentanaPrincipal();
            ventana.Show();

        }

        private void ExaminarBut_Click_1(object sender, EventArgs e)
        {
            File.InitialDirectory = ".//P1//Proyecto1-Integrador//Proyecto1";
            if (File.ShowDialog() == DialogResult.OK)
            {
                String nombre = File.FileName + ".txt";
                Console.Write(nombre);

            }


        }
    }
}
