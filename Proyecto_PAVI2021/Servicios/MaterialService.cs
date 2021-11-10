using Proyecto_PAVI2021.Datos.Daos;
using Proyecto_PAVI2021.Interfaces;
using Proyecto_PAVI2021.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Servicios
{
    class MaterialService
    {
        private IMaterial dao;

        public MaterialService()
        {
            dao = new MaterialDao();
        }

        public IList<Material> GetAll()
        {
            return dao.GetAll();
        }

        public DataTable RecuperarMaterialYMarcaPorId(int id_material)
        {
            return dao.RecuperarMaterialYMarcaPorId(id_material);
        }
        public IList<Material> GetAllByMarcaId(int id_marca)
        {
            return dao.GetAllByMarcaId(id_marca);
        }

        public DataTable ObtenerFiltrados(string nombre, string id_marca)
        {
            return dao.ObtenerFiltrados(nombre, id_marca);

        }

        public void RegistrarMaterial(string nombre, string id_marca, string precio)
        {
            dao.RegistrarMaterial(nombre, id_marca, precio);
        }

    }
}
