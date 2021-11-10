using Proyecto_PAVI2021.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Datos.Daos
{
    class MarcaDao : IMarca
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM MARCAS WHERE Borrado = 0";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable RecuperarFiltrados(string descripcion)
        {
            string consulta = "SELECT m.Id_Marca, m.Descripcion FROM MARCAS m WHERE m.Borrado = 0";

            if (!string.IsNullOrEmpty(descripcion))
                consulta += " AND m.Descripcion LIKE '%" + descripcion + "%'";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public void RegistrarMarca(string descripcion)
        {
            string consulta = "INSERT INTO MARCAS (Descripcion, Borrado) " + "VALUES ('" + descripcion +  "', 0)";

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public void ModificarMarcaPorId(int id_marca, string descripcion)
        {
            string consulta = "UPDATE MARCAS SET Descripcion  = '" + descripcion + "' WHERE Id_Marca = " + id_marca;

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public void EliminarMarca(int id_marca)
        {
            string consulta = "UPDATE MARCAS SET Borrado = 1 WHERE Id_Marca = " + id_marca;

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public DataTable RecuperarMarcaPorId(int id_marca)
        {
            string consulta = "SELECT m.* FROM MARCAS m WHERE m.Borrado = 0 AND m.Id_Marca = " + id_marca;

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
