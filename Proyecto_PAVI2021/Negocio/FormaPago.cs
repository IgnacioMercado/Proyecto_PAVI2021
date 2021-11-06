using Proyecto_PAVI2021.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Negocio
{
    class FormaPago
    {
        private int id_forma_pago;
        private string descripcion;
        private bool borrado;

        public int Id_forma_pago { get => id_forma_pago; set => id_forma_pago = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

       
    }
}

