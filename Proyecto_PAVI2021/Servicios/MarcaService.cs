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
    class MarcaService
    {
        private IMarca dao;

        public MarcaService()
        {
            dao = new MarcaDao();
        }

        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }

        public DataTable RecuperarFiltrados(string descripcion)
        {
            return dao.RecuperarFiltrados(descripcion);
        }
        public void RegistrarMarca(string descripcion)
        {
            dao.RegistrarMarca(descripcion);
        }
        public void ModificarMarcaPorId(int id_marca, string descripcion)
        {
            dao.ModificarMarcaPorId(id_marca, descripcion);
        }
        public void EliminarMarca(int id_marca)
        {
            dao.EliminarMarca(id_marca);
        }
        public DataTable RecuperarMarcaPorId(int id_marca)
        {
            return dao.RecuperarMarcaPorId(id_marca);
        }
    }
}
