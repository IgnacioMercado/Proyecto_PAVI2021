using ProyectoAutopartes.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Interfaces
{
    interface IFacturaCompra
    {
        bool Create(FacturaCompra factura);
        DataTable RecuperarComprasXProveedor(string desde, string hasta, string nombre, string localidad);
    }
}
