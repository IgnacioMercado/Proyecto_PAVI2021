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
    class LoteDao : ILote
    {
        public IList<Lote> GetConfirmed()
        {
            List<Lote> listadoLotes = new List<Lote>();

            var strSql = "SELECT Id_Lote, Fecha_Lote, Cantidad_Fabricada, Legajo_Empleado, Stock_Lote, Id_Material FROM LOTE WHERE Borrado = 0 AND Confirmacion_Lote = 1";

            var resultadoConsulta = BDHelper.obtenerInstancia().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoLotes.Add(MappingLote(row));
            }

            return listadoLotes;
        }

        public IList<Lote> GetConfirmedFilteredByMaterial(int id_material)
        {
            List<Lote> listadoLotes = new List<Lote>();

            var strSql = "SELECT Id_Lote, Fecha_Lote, Cantidad_Fabricada, Legajo_Empleado, Stock_Lote, Id_Material, Confirmacion_Lote  FROM LOTE WHERE Borrado = 0 AND Confirmacion_Lote = 1 AND Id_Material = " + id_material ;

            var resultadoConsulta = BDHelper.obtenerInstancia().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoLotes.Add(MappingLote(row));
            }

            return listadoLotes;
        }

        public DataTable ObtenerFiltrados(string articulo, string legajo, string confirmacion, string fechaDesde, string fechaHasta)
        {
            string consulta = "SELECT l.Id_Lote, l.Fecha_Lote, l.Cantidad_Fabricada, l.Legajo_Empleado, CONCAT_WS(', ', p.Nombre, p.Apellido) NombreCompleto, l.Stock_Lote, m.Nombre, ms.Descripcion FROM LOTE l " +
                "JOIN PERSONAL p on p.Legajo = l.Legajo_Empleado JOIN MATERIALES m on l.Id_Material = m.Id_Material JOIN MARCAS ms on ms.Id_Marca = m.Id_Marca " +
                "WHERE l.Borrado = 0 " +
                "AND l.Fecha_Lote BETWEEN CONVERT(DateTime, '" + fechaDesde + "', 103)  AND CONVERT(DateTime, '" + fechaHasta + "', 103)";

            if (!string.IsNullOrEmpty(articulo))
                consulta += " AND m.Id_Material LIKE '" + articulo + "'";
            if (!string.IsNullOrEmpty(legajo))
                consulta += " AND l.Legajo_Empleado LIKE '" + legajo + "'";
            if (!string.IsNullOrEmpty(confirmacion))
                consulta += " AND l.Confirmacion_Lote = " + confirmacion;

            return BDHelper.obtenerInstancia().consultar(consulta);

        }

        public void RegistrarLote(string articulo, string cantidad, string legajo, string fecha)
        {
            string consulta = "INSERT INTO LOTE (Fecha_Lote, Cantidad_Fabricada, Legajo_Empleado, Id_Material, Confirmacion_Lote, Stock_Lote, Borrado) " +
                              "VALUES ('" + fecha + "', " + cantidad + ", " + legajo + ", " + articulo + ", 0, 0, 0)";

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }



        public void confirmarLote(Lote oLote)
        {
            string consultaLote = "UPDATE LOTES SET Confirmacion_Lote = 1 WHERE Id_Lote = " + oLote.Id_lote;
            string consultaMaterial = "UPDATE MATERIAL SET Stock = Stock + " + oLote.Cantidad_fabricada;

        }


        private Lote MappingLote(DataRow row)
        {
            Lote oLote = new Lote
            {
                Id_lote = Convert.ToInt32(row["Id_Lote"].ToString()),
                Fecha_lote = Convert.ToDateTime(row["Fecha_Lote"]),
                Id_material = Convert.ToInt32(row["Id_Material"].ToString()),
                Legajo_empleado = Convert.ToInt32(row["Legajo_Empleado"].ToString()),
                Cantidad_fabricada = Convert.ToInt32(row["Cantidad_Fabricada"].ToString()),
                Confirmacion_lote = Convert.ToBoolean(row["Confirmacion_Lote"].ToString()),
                Stock_lote = Convert.ToInt32(row["Stock_Lote"].ToString())
            };

            return oLote;
        }
    }
}
