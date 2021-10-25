using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Negocio
{
    class FacturaCompra
    {
        public int IdFactura { get; set; }
        public int NroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Proveedor { get; set; }
        public string TipoFactura { get; set; }
        public IList<DetalleFactura> DetalleFactura { get; set; }

        public int Legajo_Empleado { get; set; }
    }
}
