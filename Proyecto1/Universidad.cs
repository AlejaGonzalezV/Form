using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Universidad
    {

        private string nombre;

        public Universidad(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public void Guardar(string nombre, string apellido, string cedula, string fecha){

            //      StreamWriter sw = new StreamWriter("C:\\Users\\VALENTINA.LAPTOP-B1KGBNOV\\Desktop\\INTEGRADOR\\P1\\Proyecto1Integrador\\Proyecto1\\Miguel.txt");

            StreamWriter sw = new StreamWriter("..\\..\\" + fecha + ".txt",true);
            sw.Write(nombre+"/");
            sw.Write(apellido + "/");
            sw.Write(cedula + "/");
            sw.Write(fecha);
            sw.WriteLine();
            sw.Close();
        }

        public ArrayList Leer(string file)
        {
            StreamReader sr = new StreamReader(file);
            string linea = "";
            ArrayList registro = new ArrayList();


            while ((linea = sr.ReadLine()) != null)
            {
                registro.Add(linea);
            }

            sr.Close();

            return registro;
        }


    }
}
