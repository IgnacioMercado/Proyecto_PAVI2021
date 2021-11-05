using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Negocio
{
    public class PagoPorFactura
    {
        private int id_pago_factura;
        private int id_factura;
        private int id_forma_pago;
        private double monto;
        private bool borrado;

        public int Id_pago_factura { get => id_pago_factura; set => id_pago_factura = value; }
        public int Id_factura { get => id_factura; set => id_factura = value; }
        public int Id_forma_pago { get => id_forma_pago; set => id_forma_pago = value; }
        public double Monto { get => monto; set => monto = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
    }
}
