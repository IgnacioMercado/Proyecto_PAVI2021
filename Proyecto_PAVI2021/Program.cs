using Proyecto_PAVI2021.Presentacion;
using Proyecto_PAVI2021.Presentacion.PresBarrios;
using Proyecto_PAVI2021.Presentacion.PresCompras;
using Proyecto_PAVI2021.Presentacion.PresFactura;
using Proyecto_PAVI2021.Presentacion.PresLotes;
using Proyecto_PAVI2021.Presentacion.PresMarcas;
using Proyecto_PAVI2021.Presentacion.PresMateriales;
using Proyecto_PAVI2021.Reportes;
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
            
            Application.Run(new frmLogin());
        }
    }
}
