using Proyecto_PAVI2021.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Negocio
{
    class Cliente
    {
        private int id_cliente;
        private string tipo_doc;
        private string nro_doc;
        private string nombre;
        private string apellido;
        private string telefono;
        private string calle;
        private string nro_calle;
        private DateTime fecha_alta;
        private bool borrado;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Tipo_doc { get => tipo_doc; set => tipo_doc = value; }
        public string Nro_doc { get => nro_doc; set => nro_doc = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Nro_calle { get => nro_calle; set => nro_calle = value; }
        public DateTime Fecha_alta { get => fecha_alta; set => fecha_alta = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

       
    }
}
