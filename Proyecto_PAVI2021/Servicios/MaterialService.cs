using Proyecto_PAVI2021.Datos.Daos;
using Proyecto_PAVI2021.Interfaces;
using Proyecto_PAVI2021.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Servicios
{
    class MaterialService
    {
        private IMaterial dao;

        public MaterialService()
        {
            dao = new MaterialDao();
        }

        public IList<Material> GetAll()
        {
            return dao.GetAll();
        }
    }
}
