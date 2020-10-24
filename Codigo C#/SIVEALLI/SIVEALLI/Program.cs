using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibClases;

namespace SIVEALLI
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

            CNegocio negocio = new CNegocio();

            if(negocio.NumeroRegistros() >= 1)
            {
                Application.Run(new FormLogin());
            }
            else
            {
                Application.Run(new FormInicioSistema());
            }            
        }
    }
}
