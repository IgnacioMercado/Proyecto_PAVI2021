using Proyecto_PAVI2021.Datos.Daos;
using Proyecto_PAVI2021.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Servicios
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

        internal DataTable RecuperarVentas(string desde, string hasta, string nombreC, string apellidoC, string nombreE, string apellidoE)
        {
            return oFacturaDao.RecuperarVentas(desde, hasta, nombreC, apellidoC, nombreE, apellidoE);
        }

        internal DataTable RecuperarVentasXCliente(string desde, string hasta, string nombre, string apellido, string alta_desde, string alta_hasta)
        {
            return oFacturaDao.RecuperarVentasXCliente(desde, hasta, nombre, apellido, alta_desde, alta_hasta);
        }
        internal DataTable RecuperarVentasXEmpleado(string desde, string hasta, string nombre, string apellido, string alta_desde, string alta_hasta)
        {
            return oFacturaDao.RecuperarVentasXEmpleado(desde, hasta, nombre, apellido, alta_desde, alta_hasta);
        }

        internal DataTable RecuperarArtMasVendido(string desde, string hasta, string nombre, string marca)
        {
            return oFacturaDao.RecuperarArtMasVendido(desde, hasta, nombre, marca);
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

        internal DataTable RecuperarComprasXProveedor(string desde, string hasta, string nombre, string localidad)
        {
            return oFacturaCompraDao.RecuperarComprasXProveedor(desde, hasta, nombre, localidad);
        }
    }
}
