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
    class PerfilService
    {
        private IPerfil dao;

        public PerfilService()
        {
            dao = new PerfilDao();
        }
        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
