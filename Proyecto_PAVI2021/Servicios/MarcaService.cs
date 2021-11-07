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
    class MarcaService
    {
        private IMarca dao;

        public MarcaService()
        {
            dao = new MarcaDao();
        }

        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
