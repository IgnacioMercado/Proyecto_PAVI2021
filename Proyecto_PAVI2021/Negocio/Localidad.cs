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

        public void RegistrarLocalidad(string nombre)
        {
            string consulta = "INSERT INTO LOCALIDADES (Descripcion, Borrado) " +
                              "VALUES ('" + nombre + "', '" + 0 + "')";
            BDHelper oDatos = new BDHelper();
            oDatos.EjecutarConsulta(consulta);
        }
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT l.id_Localidad, l.Descripcion, l.Borrado FROM LOCALIDADES l WHERE l.Borrado = 0 ORDER BY Descripcion";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }
        public DataTable RecuperarFiltrados(string id)
        {
            string consulta = "SELECT l.id_Localidad, l.Descripcion, l.Borrado FROM LOCALIDADES l WHERE l.Borrado = 0";

            if (!string.IsNullOrEmpty(id))
                consulta += " AND l.id_Localidad = '" + id;

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }
        public DataTable RecuperarPorDescripcion(string nombre)
        {
            string consulta = "SELECT l.id_Localidad, l.Descripcion, l.Borrado FROM LOCALIDADES l WHERE l.Borrado = 0";

            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND l.Descripcion LIKE '%" + nombre + "%'";

            consulta += "ORDER BY Descripcion";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }
        
        public void ModificarLocalidadPorId(string id, string descripcion)
        {
            string consulta = "UPDATE LOCALIDADES SET Descripcion = '" + descripcion + "' WHERE Id_Localidad = " + id;
            BDHelper oDatos = new BDHelper();
            oDatos.EjecutarConsulta(consulta);
        }
    }
}
