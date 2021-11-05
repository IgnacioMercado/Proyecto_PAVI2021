using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Negocio
{
    class DetalleFactura
    {
        private int id_detalle_factura;
        private int id_factura;
        private Material material;
        private int cantidad;
        private int id_lote;

        public int Id_detalle_factura { get => id_detalle_factura; set => id_detalle_factura = value; }
        public int Id_factura { get => id_factura; set => id_factura = value; }
        internal Material Material { get => material; set => material = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public int id_material
        {
            get
            {
                return Material.Id_material;
            }
        }
        public string MaterialDescripcion
        {
            get
            {
                return Material.Nombre;
            }
        }
        public Double PrecioUnitario
        {
            get
            {
                return Material.Precio;
            }
        }

        public Double Importe
        {
            get
            {
                return Cantidad * PrecioUnitario;
            }
        }

        public int Id_lote { get => id_lote; set => id_lote = value; }
    }
}
