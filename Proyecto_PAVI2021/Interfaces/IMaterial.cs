using Proyecto_PAVI2021.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Interfaces
{
    interface IMaterial
    {
        IList<Material> GetAll();
        DataTable RecuperarMaterialYMarcaPorId(int id_material);
        IList<Material> GetAllByMarcaId(int id_marca);
    }
}
