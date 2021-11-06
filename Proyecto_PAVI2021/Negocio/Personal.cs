using Proyecto_PAVI2021.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Negocio
{
    class Personal
    {
        private int legajo;
        private string tipo_doc;
        private string nro_doc;
        private string nombre;
        private string apellido;
        private string telefono;
        private string calle;
        private string nro_calle;
        private int id_barrio;
        private int id_localidad;
        private int id_usuario;
        private bool borrado;

        public int Legajo { get => legajo; set => legajo = value; }
        public string Tipo_doc { get => tipo_doc; set => tipo_doc = value; }
        public string Nro_doc { get => nro_doc; set => nro_doc = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Nro_calle { get => nro_calle; set => nro_calle = value; }
        public int Id_barrio { get => id_barrio; set => id_barrio = value; }
        public int Id_localidad { get => id_localidad; set => id_localidad = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

        

    }
}

