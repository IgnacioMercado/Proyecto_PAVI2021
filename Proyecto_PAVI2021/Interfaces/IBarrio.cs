using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Interfaces
{
    interface IBarrio
    {
        DataTable RecuperarTodos();
        DataTable RecuperarFiltrados(string descripcion);
        void RegistrarBarrio(string descripcion);
        void ModificarBarrioPorId(int id_barrio, string descripcion);
        void EliminarBarrio(int id_barrio);
    }
}
