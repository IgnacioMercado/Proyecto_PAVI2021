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

        public DataTable ObtenerFiltrados(string articulo, string legajo, string confirmacion, string fechaDesde, string fechaHasta)
        {
            return dao.ObtenerFiltrados(articulo, legajo, confirmacion, fechaDesde, fechaHasta);
        }

        public void RegistrarLote(string articulo, string cantidad, string legajo, string fecha)
        {
            dao.RegistrarLote(articulo, cantidad, legajo, fecha);
        }
    }
}
