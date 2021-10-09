using Proyecto_PAVI2021.Datos;
using ProyectoAutopartes.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Datos.Daos
{
    class BarrioDao : IBarrio
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT b.Id_Barrio, b.Descripcion FROM BARRIOS b WHERE b.Borrado = 0";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }


        public DataTable RecuperarFiltrados(string descripcion)
        {
            string consulta = "SELECT b.Id_Barrio, b.Descripcion FROM BARRIOS b WHERE b.Borrado = 0";

            if (!string.IsNullOrEmpty(descripcion))
                consulta += " AND b.Descripcion LIKE '%" + descripcion + "%'";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public void RegistrarBarrio(string descripcion)
        {
            string consulta = "INSERT INTO BARRIOS (Descripcion) " + "VALUES ('" + descripcion + "')";

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public void ModificarBarrioPorId(int id_barrio, string descripcion)
        {
            string consulta = "UPDATE BARRIOS SET Descripcion  = '" + descripcion + "' WHERE Id_Barrio = " + id_barrio;

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public void EliminarBarrio(int id_barrio)
        {
            string consulta = "UPDATE BARRIOS SET Borrado = 1 WHERE Id_Barrio = " + id_barrio;

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }
    }
}
