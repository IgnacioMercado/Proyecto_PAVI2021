using Proyecto_PAVI2021.Presentacion;
using ProyectoAutopartes.Presentacion.PresFactura;
using ProyectoAutopartes.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PAVI2021
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
            //Application.Run(new FormPrincipal());
            Application.Run(new FormReporteVentas());
        }
    }
}
