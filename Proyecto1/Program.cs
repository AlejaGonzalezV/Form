using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Universidad u = new Universidad("ICESI");
            u.Guardar("aleja", "gon", "2352", "dffsddf");
            u.Guardar("angi", "gon", "2352", "dffsddf");
            Application.Run(new Form1());
            
          

        }
    }
}
