using Proyecto_PAVI2021.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Negocio
{
    class Lote
    {
        int id_lote;
        DateTime fecha_lote;
        int cantidad_fabricada;
        int legajo_empleado;
        bool confirmacion_lote;
        int stock_lote;
        int id_material;
        


        public int Id_lote { get => id_lote; set => id_lote = value; }
        public DateTime Fecha_lote { get => fecha_lote; set => fecha_lote = value; }
        public int Cantidad_fabricada { get => cantidad_fabricada; set => cantidad_fabricada = value; }
        public int Legajo_empleado { get => legajo_empleado; set => legajo_empleado = value; }
        public bool Confirmacion_lote { get => confirmacion_lote; set => confirmacion_lote = value; }
        public int Stock_lote { get => stock_lote; set => stock_lote = value; }
        public int Id_material { get => id_material; set => id_material = value; }

        public void crearLote(string fecha, int cantidad, string legajo, bool confirmacion, string stock, int id_material)
        {
            string consulta = "INSERT INTO LOTE (Fecha_Lote, Cantidad_Fabricada, Legajo_Empleado, Confirmacion_Lote, Stock_Lote, Id_Material) " +
                              "VALUES (CONVERT(DateTime, '" + fecha + "', 103), " + cantidad + ", '" + legajo + "', '" + confirmacion + "', '" + stock + "', " + id_material + ")";

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }
        public DataTable ultimoId()
        {
            DataTable tabla = new DataTable();
            //string consulta = "IDENT_CURRENT('" + tabla + "')";
            string consulta = "SELECT top(1) * FROM LOTE ORDER BY Id_Lote DESC";
            tabla = BDHelper.obtenerInstancia().consultar(consulta);
            return tabla;
        }
    }
}
