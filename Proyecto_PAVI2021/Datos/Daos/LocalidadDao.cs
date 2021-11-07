using Proyecto_PAVI2021.Datos;
using Proyecto_PAVI2021.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Datos.Daos
{
    class LocalidadDao : ILocalidad
    {
        public void RegistrarLocalidad(string nombre)
        {
            string consulta = "INSERT INTO LOCALIDADES (Descripcion, Borrado) " +
                              "VALUES ('" + nombre + "', '" + 0 + "')";

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT l.Id_Localidad, l.Descripcion, l.Borrado FROM LOCALIDADES l WHERE l.Borrado = 0 ORDER BY Descripcion";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable RecuperarFiltrados(string id)
        {
            string consulta = "SELECT l.Id_Localidad, l.Descripcion, l.Borrado FROM LOCALIDADES l WHERE l.Borrado = 0";

            if (!string.IsNullOrEmpty(id))
                consulta += " AND l.Id_Localidad = " + id;

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable RecuperarPorDescripcion(string nombre)
        {
            string consulta = "SELECT l.Id_Localidad, l.Descripcion, l.Borrado FROM LOCALIDADES l WHERE l.Borrado = 0";

            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND l.Descripcion LIKE '%" + nombre + "%'";

            consulta += "ORDER BY Descripcion";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public void ModificarLocalidadPorId(string id, string descripcion)
        {
            string consulta = "UPDATE LOCALIDADES SET Descripcion = '" + descripcion + "' WHERE Id_Localidad = " + id;

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }
    }
}
