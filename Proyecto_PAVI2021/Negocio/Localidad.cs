using Proyecto_PAVI2021.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Negocio
{
    class Localidad
    {
        private int id_localidad;
        private string descripcion;
        private bool borrado;
        public int id_Localidad { get; set; }
        public string Descripcion { get; set; }
        public bool Borrado { get; set; }

        
    }
}
