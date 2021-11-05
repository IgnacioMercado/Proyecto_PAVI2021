using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Interfaces
{
    interface IFormaDePago
    {
        DataTable RecuperarTodos();


        void RegistrarFormaPago(string descripcion);


        void ModificarFormaPago(string descripcion, int id);


        void EliminarFormaPago(int id);

    }
}
