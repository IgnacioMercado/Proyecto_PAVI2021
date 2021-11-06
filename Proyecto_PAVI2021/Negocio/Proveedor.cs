using Proyecto_PAVI2021.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Negocio
{
    class Proveedor
    {

        private int id_proveedor;
        private string nombre;
        private string telefono;
        private string cuit;
        private string calle;
        private string nro_calle;
        private int id_barrio;
        private int id_localidad;
        private bool borrado;

        public int Id_Proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Cuit { get => cuit; set => cuit = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Nro_calle { get => nro_calle; set => nro_calle = value; }
        public int Id_Barrio { get => id_barrio; set => id_barrio = value; }
        public int Id_Localidad { get => id_localidad; set => id_localidad = value; }
        public bool Borrado { get => borrado; set => borrado = value; }


    }
}
