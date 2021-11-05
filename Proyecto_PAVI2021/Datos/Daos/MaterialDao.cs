using Proyecto_PAVI2021.Datos;
using Proyecto_PAVI2021.Interfaces;
using Proyecto_PAVI2021.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Datos.Daos
{
    class MaterialDao : IMaterial
    {
        public IList<Material> GetAll()
        {
            List<Material> listadoMateriales = new List<Material>();

            var strSql = "SELECT Id_Material, Nombre, Precio, Stock FROM MATERIALES WHERE Borrado = 0";

            var resultadoConsulta = BDHelper.obtenerInstancia().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoMateriales.Add(MappingMaterial(row));
            }

            return listadoMateriales;
        }

        private Material MappingMaterial(DataRow row)
        {
            Material oMaterial = new Material
            {
                Id_material = Convert.ToInt32(row["Id_Material"].ToString()),
                Nombre = row["Nombre"].ToString(),
                Precio = Convert.ToDouble(row["Precio"].ToString()),
                Stock = Convert.ToInt32(row["Stock"].ToString())
            };

            return oMaterial;
        }
    }
}
