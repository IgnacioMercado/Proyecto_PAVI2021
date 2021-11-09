using Proyecto_PAVI2021.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Interfaces
{
    interface IFacturaVenta
    {
        bool Create(FacturaVenta factura);
        DataTable RecuperarVentasXCliente(string desde, string hasta, string nombre, string apellido, string alta_desde, string alta_hasta);
        DataTable RecuperarVentasXEmpleado(string desde, string hasta, string nombre, string apellido, string alta_desde, string alta_hasta);
        DataTable RecuperarArtMasVendido(string desde, string hasta, string nombre, string marca);


    }
}
