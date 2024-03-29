﻿using Proyecto_PAVI2021.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Negocio
{
    class FacturaVenta
    {
        public int IdFactura { get; set; }
        public int NroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Cliente { get; set; }
        public string TipoFactura { get; set; }
        public IList<DetalleFactura> DetalleFactura { get; set; }
        public IList<PagoPorFactura> PagosPorFactura { get; set; }
        public int Legajo_Empleado { get; set; }

        public static DataTable RecuperarFacturasV()
        {
            DataTable tabla = new DataTable();

            string consulta = "SELECT * FROM FACTURA_VENTA";

            tabla = BDHelper.obtenerInstancia().consultar(consulta);

            return tabla; 
        }
    }
}
