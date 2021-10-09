using ProyectoAutopartes.Datos.Daos;
using ProyectoAutopartes.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Servicios
{
    class BarrioService
    {
        private IBarrio dao;

        public BarrioService()
        {
            dao = new BarrioDao();
        }

        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }


        public DataTable RecuperarFiltrados(string descripcion)
        {
            return dao.RecuperarFiltrados(descripcion);
        }

        public void RegistrarBarrio(string descripcion)
        {
            dao.RegistrarBarrio(descripcion);
        }

        public void ModificarBarrioPorId(int id_barrio, string descripcion)
        {
            dao.ModificarBarrioPorId(id_barrio, descripcion);
        }

        public void EliminarBarrio(int id_barrio)
        {
            dao.EliminarBarrio(id_barrio);
        }
    }
}
