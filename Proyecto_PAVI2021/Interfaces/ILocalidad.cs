using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Interfaces
{
    interface ILocalidad
    {
        void RegistrarLocalidad(string nombre);


        DataTable RecuperarTodos();


        DataTable RecuperarFiltrados(string id);


        DataTable RecuperarPorDescripcion(string nombre);


        void ModificarLocalidadPorId(string id, string descripcion);

    }
}
