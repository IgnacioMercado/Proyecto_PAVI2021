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
    class MaterialService
    {
        private IMaterial dao;

        public MaterialService()
        {
            dao = new MaterialDao();
        }

        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
