using Proyecto_PAVI2021.Datos.Daos;
using Proyecto_PAVI2021.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Servicios
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


        public DataTable RecuperarFiltrados(string descripcion, string id_localidad)
        {
            return dao.RecuperarFiltrados(descripcion, id_localidad);
        }

        public void RegistrarBarrio(string descripcion, string id_localidad)
        {
            dao.RegistrarBarrio(descripcion, id_localidad);
        }

        public void ModificarBarrioPorId(int id_barrio, string descripcion, string id_localidad)
        {
            dao.ModificarBarrioPorId(id_barrio, descripcion, id_localidad);
        }

        public void EliminarBarrio(int id_barrio)
        {
            dao.EliminarBarrio(id_barrio);
        }

        public DataTable RecuperarPorLocalidad(int id_localidad)
        {
            return dao.RecuperarPorLocalidad(id_localidad);
        }
        
        public DataTable RecuperarBarrioPorId(int id_barrio)
        {
            return dao.RecuperarBarrioPorId(id_barrio);
        }
    }
}
