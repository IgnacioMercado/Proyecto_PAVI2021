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
