using Proyecto_PAVI2021.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Negocio
{
    class FacturaVenta
    {
        public int IdFactura { get; set; }
        public int NroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Cliente { get; set; }
        public string TipoFactura { get; set; }
        public IList<DetalleFactura> DetalleFactura { get; set; }
        
        public int Legajo_Empleado { get; set; }
    }
}
