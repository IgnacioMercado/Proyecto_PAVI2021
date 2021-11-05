using Proyecto_PAVI2021.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Interfaces
{
    interface ILote
    {
        IList<Lote> GetConfirmed();
        IList<Lote> GetConfirmedFilteredByMaterial(int id_material);
    }
}
