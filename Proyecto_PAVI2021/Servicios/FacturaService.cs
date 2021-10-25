using ProyectoAutopartes.Datos.Daos;
using ProyectoAutopartes.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Servicios
{
    public class FacturaService
    {
        private FacturaVentaDao oFacturaDao;
        private FacturaCompraDao oFacturaCompraDao;
        public FacturaService()
        {
            oFacturaDao = new FacturaVentaDao();
            oFacturaCompraDao = new FacturaCompraDao();
        }


        //------------------------------FACTURA VENTA ------------------------//
        internal bool Crear(FacturaVenta factura)
        {
            return oFacturaDao.Create(factura);
        }

        internal bool ValidarDatos(FacturaVenta factura)
        {
            if (factura.DetalleFactura.Count == 0)
            {
                throw new Exception("Debe ingresar al menos un item de factura.");
            }

            return true;
        }

        //------------------------------FACTURA COMPRA ------------------------//
        internal bool Crear(FacturaCompra factura)
        {
            return oFacturaCompraDao.Create(factura);
        }

        internal bool ValidarDatos(FacturaCompra factura)
        {
            if (factura.DetalleFactura.Count == 0)
            {
                throw new Exception("Debe ingresar al menos un item de factura.");
            }

            return true;
        }
    }
}
