using Proyecto_PAVI2021.Datos.Daos;
using Proyecto_PAVI2021.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Servicios
{
    class FormaDePagoService
    {
        private IFormaDePago dao;
        public FormaDePagoService()
        {
            dao = new FormaDePagoDao();
        }
        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }

        public void RegistrarFormaPago(string descripcion)
        {
            dao.RegistrarFormaPago(descripcion);
        }

        public void ModificarFormaPago(string descripcion, int id)
        {
            dao.ModificarFormaPago(descripcion, id);
        }

        public void EliminarFormaPago(int id)
        {
            dao.EliminarFormaPago(id);
        }
    }
}
