using Proyecto_PAVI2021.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Interfaces
{
    interface ILote
    {
        IList<Lote> GetConfirmedFilteredByMaterial(int id_material);
        void RegistrarLote(string articulo, string cantidad, string legajo, string fecha);
        DataTable ObtenerFiltrados(string articulo, string legajo, string confirmacion, string fechaDesde, string fechaHasta);
        void confirmarLote(string id, string cantidad);
        DataTable ObtenerTodos();
    }
}
