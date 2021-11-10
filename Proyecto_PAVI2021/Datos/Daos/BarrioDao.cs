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
    class BarrioDao : IBarrio
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT b.Id_Barrio, b.Descripcion, l.Descripcion as Localidad FROM BARRIOS b JOIN LOCALIDADES l on b.Id_Localidad = l.Id_Localidad WHERE b.Borrado = 0";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable RecuperarPorLocalidad(int id_localidad)
        {
            string consulta = "SELECT b.Id_Barrio, b.Descripcion FROM BARRIOS b where b.Borrado = 0 AND b.Id_Localidad = " + id_localidad;
            return BDHelper.obtenerInstancia().consultar(consulta);
        }


        public DataTable RecuperarFiltrados(string descripcion, string id_localidad)
        {
            string consulta = "SELECT b.Id_Barrio, b.Descripcion, l.Descripcion as Localidad FROM BARRIOS b JOIN LOCALIDADES l on b.Id_Localidad = l.Id_Localidad WHERE b.Borrado = 0";

            if (!string.IsNullOrEmpty(descripcion))
                consulta += " AND b.Descripcion LIKE '%" + descripcion + "%'";
            if (!string.IsNullOrEmpty(id_localidad))
                consulta += "AND b.Id_Localidad = " + id_localidad;

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public void RegistrarBarrio(string descripcion, string id_localidad)
        {
            string consulta = "INSERT INTO BARRIOS (Descripcion, Id_Localidad, BORRADO) " + "VALUES ('" + descripcion + "', " + id_localidad + ", 0)";

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public void ModificarBarrioPorId(int id_barrio, string descripcion, string id_localidad)
        {
            string consulta = "UPDATE BARRIOS SET Descripcion  = '" + descripcion + "', Id_Localidad = " + id_localidad + "WHERE Id_Barrio = " + id_barrio;

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public void EliminarBarrio(int id_barrio)
        {
            string consulta = "UPDATE BARRIOS SET Borrado = 1 WHERE Id_Barrio = " + id_barrio;

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public DataTable RecuperarBarrioPorId(int id_barrio)
        {
            string consulta = "SELECT b.* FROM BARRIOS b WHERE b.Borrado = 0 AND b.Id_Barrio = " + id_barrio;

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
