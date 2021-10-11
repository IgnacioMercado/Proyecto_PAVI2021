using Proyecto_PAVI2021.Datos;
using ProyectoAutopartes.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Datos.Daos
{
    class FacturaVentaDao
    {
        internal bool Create(FacturaVenta factura)
        {
            BDHelper bd = new BDHelper();
            try
            {
                bd.Open();
                bd.BeginTransaction();

                string sql = string.Concat("INSERT INTO [dbo].[FACTURA_VENTA] ",
                                            "           ([Nro_factura]   ",
                                            "           ,[Tipo_Factura]   ",
                                            "           ,[Id_Cliente]       ",
                                            "           ,[Fecha_Factura]         ",
                                            "           ,[Legajo_Empleado]         ",
                                            "           ,[Borrado])      ",
                                            "     VALUES                 ",
                                            "           (@nro_factura   ",                                                      
                                            "           ,@tipoFactura    ",
                                            "           ,@cliente        ",
                                            "           ,@fecha          ",
                                            "           ,@legajo_empleado         ",
                                            "           ,@borrado)       ");


                var parametros = new Dictionary<string, object>();
                parametros.Add("nro_factura", factura.NroFactura);
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
                                                        "           ,[Borrado])             ",
                                                        "     VALUES                        ",
                                                        "           (@id_factura            ",
                                                        "           ,@id_material           ",
                                                        "           ,@cantidad       ",
                                                        "           ,@precio              ",
                                                        "           ,@borrado)               ");

                    var paramDetalle = new Dictionary<string, object>();
                    paramDetalle.Add("id_factura", factura.IdFactura);
                    paramDetalle.Add("id_producto", itemFactura.Material.Id_material);
                    paramDetalle.Add("precio", itemFactura.Material.Precio);
                    paramDetalle.Add("cantidad", itemFactura.Cantidad);
                    paramDetalle.Add("borrado", false);

                    bd.EjecutarSQLCONPARAMETROS(sqlDetalle, paramDetalle);
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
    }
}
