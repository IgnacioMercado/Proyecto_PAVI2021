using Proyecto_PAVI2021.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Negocio
{
    class Perfil
    {
        private int id_perfil;
        private string nombre;
        private string descripcion;
        private bool borrado;

        public int Id_perfil { get => id_perfil; set => id_perfil = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Borrado { get => borrado; set => borrado = value; }


        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM PERFILES WHERE Borrado = 0 ORDER BY Id_Perfil";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }
    }
}
