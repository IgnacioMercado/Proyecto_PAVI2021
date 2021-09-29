using Proyecto_PAVI2021.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Negocio
{
    class Localidad
    {

        private int id_localidad;
        private string descripcion;
        private bool borrado;


        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
        public int Id_localidad { get => id_localidad; set => id_localidad = value; }

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT l.Id_Localidad, l.Descripcion FROM LOCALIDADES l WHERE l.Borrado = 0";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }

    }
}
