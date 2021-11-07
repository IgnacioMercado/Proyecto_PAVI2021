using Proyecto_PAVI2021.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Negocio
{
    class Barrio
    {
        private int id_barrio;
        private string descripcion;
        private bool borrado;
        private int id_localidad;

        public int Id_barrio { get => id_barrio; set => id_barrio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
        public int Id_localidad { get => id_localidad; set => id_localidad = value; }
    }
}
