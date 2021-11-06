using Proyecto_PAVI2021.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Negocio
{
    class Usuario
    {
        private int id_usuario;
        private string nombre;
        private string contraseña;
        private DateTime fecha_alta;
        private int id_perfil;
        private bool borrado;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public DateTime Fecha_alta { get => fecha_alta; set => fecha_alta = value; }
        public int Id_perfil { get => id_perfil; set => id_perfil = value; }
        public bool Borrado { get => borrado; set => borrado = value; }


    }
}
