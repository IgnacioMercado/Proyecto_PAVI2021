using ProyectoAutopartes.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Interfaces
{
    interface ILote
    {
        IList<Lote> GetConfirmed();
        IList<Lote> GetConfirmedFilteredByMaterial(int id_material);
    }
}
