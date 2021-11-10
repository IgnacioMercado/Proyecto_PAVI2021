using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Interfaces
{
    interface IMarca
    {
        DataTable RecuperarTodos();
        DataTable RecuperarFiltrados(string descripcion);
        void RegistrarMarca(string descripcion);
        void ModificarMarcaPorId(int id_marca, string descripcion);
        void EliminarMarca(int id_marca);
        DataTable RecuperarMarcaPorId(int id_marca);

    }
}
