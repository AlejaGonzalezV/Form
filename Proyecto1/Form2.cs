using System;
using System.Collections;
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
        Universidad icesi;
        public VentanaLista()
        {
            InitializeComponent();
            icesi = new Universidad("ICESI");
        }

        private void VentanaLista_Load(object sender, EventArgs e)
        {

        }


        private void ExaminarBut_Click(object sender, EventArgs e)
        {

            
        }

        private void ListaIngresos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CerrarBoton_Click(object sender, EventArgs e)
        {

            this.Close();
            VentanaPrincipal ventana = new VentanaPrincipal();
            

        }


        private void File_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void ExaminarBut_Click_1(object sender, EventArgs e)
        {
            File.InitialDirectory = @"\Proyecto1\Proyecto1";
            if (File.ShowDialog() == DialogResult.OK)
            {

                string nombre = File.FileName;
                string archivo = nombre + ".txt";

                ListaIngresos.Items.Clear();

                ArrayList registro = icesi.Leer(nombre);

                ListaIngresos.BeginUpdate();

                for(int i = 0; i< registro.Count; i++)
                {
                    ListaIngresos.Items.Add(registro[i]);
                }


                ListaIngresos.EndUpdate();

            }


        }

    }
}
