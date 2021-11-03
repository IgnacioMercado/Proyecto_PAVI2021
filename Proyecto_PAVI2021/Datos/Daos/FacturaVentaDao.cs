using Proyecto_PAVI2021.Datos;
using ProyectoAutopartes.Interfaces;
using ProyectoAutopartes.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Datos.Daos
{
    class FacturaVentaDao : IFacturaVenta
    {
        public bool Create(FacturaVenta factura)
        {
            BDHelper bd = new BDHelper();
            try
            {
                bd.Open();
                bd.BeginTransaction();

                string sql = string.Concat("INSERT INTO [dbo].[FACTURA_VENTA] ",
                                            "           ([Tipo_Factura]   ",
                                            "           ,[Id_Cliente]       ",
                                            "           ,[Fecha_Factura]         ",
                                            "           ,[Legajo_Empleado]         ",
                                            "           ,[Borrado])      ",
                                            "     VALUES                 ",
                                            "           (@tipoFactura    ",
                                            "           ,@cliente        ",
                                            "           ,@fecha          ",
                                            "           ,@legajo_empleado         ",
                                            "           ,@borrado)       ");


                var parametros = new Dictionary<string, object>();

                parametros.Add("fecha", factura.Fecha);
                parametros.Add("cliente", factura.Id_Cliente);
                parametros.Add("tipoFactura", factura.TipoFactura);
                parametros.Add("legajo_empleado", factura.Legajo_Empleado);
                parametros.Add("borrado", false);
                bd.EjecutarSQLCONPARAMETROS(sql, parametros);

                var newId = bd.ConsultaSQLScalar(" SELECT @@IDENTITY");
                factura.IdFactura = Convert.ToInt32(newId);


                foreach (var itemFactura in factura.DetalleFactura)
                {
                    string sqlDetalle = string.Concat(" INSERT INTO [dbo].[DETALLE_FACTURA_VENTAS] ",
                                                        "           ([Id_Factura]           ",
                                                        "           ,[Id_Material]          ",
                                                        "           ,[Cantidad_Vendida]      ",
                                                        "           ,[Precio_Venta]             ",
                                                        "           ,[Id_Lote]             ",
                                                        "           ,[Borrado])             ",
                                                        "     VALUES                        ",
                                                        "           (@id_factura            ",
                                                        "           ,@id_material           ",
                                                        "           ,@cantidad       ",
                                                        "           ,@precio              ",
                                                        "           ,@id_lote              ",
                                                        "           ,@borrado)               ");

                    var paramDetalle = new Dictionary<string, object>();
                    paramDetalle.Add("id_factura", factura.IdFactura);
                    paramDetalle.Add("id_material", itemFactura.Material.Id_material);
                    paramDetalle.Add("precio", itemFactura.Material.Precio);
                    paramDetalle.Add("cantidad", itemFactura.Cantidad);
                    paramDetalle.Add("id_lote", itemFactura.Id_lote);
                    paramDetalle.Add("borrado", false);


                    bd.EjecutarSQLCONPARAMETROS(sqlDetalle, paramDetalle);

                    string sqlStock = "UPDATE MATERIALES SET Stock = Stock - " + itemFactura.Cantidad + " WHERE Id_Material = " + itemFactura.id_material;
                    bd.EjecutarSQL(sqlStock);

                    string sqlLoteStock = "UPDATE LOTE SET Stock_Lote = Stock_Lote - " + itemFactura.Cantidad + " WHERE Id_Lote = " + itemFactura.Id_lote;
                    bd.EjecutarSQL(sqlLoteStock);

                }



                bd.Commit();

            }
            catch (Exception ex)
            {
                bd.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                bd.Close();
            }
            return true;
        }

        public DataTable RecuperarVentasXCliente(string desde, string hasta, string nombre, string apellido, string alta_desde, string alta_hasta)
        {
            string consulta = "SELECT C.Id_Cliente, C.Apellido, C.Nombre, C.Fecha_Alta, COUNT(DISTINCT FV.Id_Factura) as Total_Ventas, SUM(DFV.Cantidad_Vendida*DFV.Precio_Venta) as Total_Vendido " +
                              "FROM CLIENTES C " +
                              "JOIN FACTURA_VENTA FV ON(C.Id_Cliente = FV.Id_Cliente) " +
                              "JOIN DETALLE_FACTURA_VENTAS DFV ON(FV.Id_Factura= DFV.Id_Factura) " +
                              "WHERE C.Borrado = 0 AND FV.Borrado = 0 AND DFV.Borrado = 0 " +
                              "AND C.Fecha_Alta BETWEEN CONVERT(DateTime, '" + alta_desde + "', 103)  AND CONVERT(DateTime, '" + alta_hasta + "', 103) " +
                              "AND FV.Fecha_Factura BETWEEN CONVERT(DateTime, '" + desde + "', 103)  AND CONVERT(DateTime, '" + hasta + "', 103)";

            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND C.Nombre LIKE '%" + nombre + "%'";
            if (!string.IsNullOrEmpty(apellido))
                consulta += " AND C.Apellido LIKE '%" + apellido + "%'";

            consulta += " GROUP BY C.Id_Cliente, C.Apellido, C.Nombre, C.Fecha_Alta";
            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
