using ProyectoAutopartes.Datos.Daos;
using ProyectoAutopartes.Interfaces;
using ProyectoAutopartes.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Servicios
{
    class LoteService
    {
        private ILote dao;

        public LoteService()
        {
            dao = new LoteDao();
        }

        public IList<Lote> GetConfirmed()
        {
            return dao.GetConfirmed();
        }

        public IList<Lote> GetConfirmedFilteredByMaterial(int id_material)
        {
            return dao.GetConfirmedFilteredByMaterial(id_material);
        }
    }
}
