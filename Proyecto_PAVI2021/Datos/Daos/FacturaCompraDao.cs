using Proyecto_PAVI2021.Datos;
using ProyectoAutopartes.Interfaces;
using ProyectoAutopartes.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Datos.Daos
{
    class FacturaCompraDao : IFacturaCompra
    {
        public bool Create(FacturaCompra factura)
        {
            BDHelper bd = new BDHelper();
            try
            {
                bd.Open();
                bd.BeginTransaction();

                string sql = string.Concat("INSERT INTO [dbo].[FACTURA_COMPRA] ",
                                            "           ([Nro_Factura]   ",
                                            "           ,[Tipo_Factura]       ",
                                            "           ,[Id_Proveedor]         ",
                                            "           ,[Fecha_Factura]         ",
                                            "           ,[Legajo_Empleado]       ",
                                            "           ,[Borrado])              ",
                                            "     VALUES                 ",
                                            "           (@nro_factura    ",
                                            "           ,@tipoFactura    ",
                                            "           ,@id_proveedor   ",
                                            "           ,@fecha          ",
                                            "           ,@legajo_empleado ",
                                            "           ,@borrado)       ");


                var parametros = new Dictionary<string, object>();
                parametros.Add("nro_factura", factura.NroFactura);
                parametros.Add("fecha", factura.Fecha);
                parametros.Add("id_proveedor", factura.Id_Proveedor);
                parametros.Add("tipoFactura", factura.TipoFactura);
                parametros.Add("legajo_empleado", factura.Legajo_Empleado);
                parametros.Add("borrado", false);
                bd.EjecutarSQLCONPARAMETROS(sql, parametros);

                var newId = bd.ConsultaSQLScalar(" SELECT @@IDENTITY");
                factura.IdFactura = Convert.ToInt32(newId);


                foreach (var itemFactura in factura.DetalleFactura)
                {
                    string sqlDetalle = string.Concat(" INSERT INTO [dbo].[DETALLE_FACTURA_COMPRAS] ",
                                                        "           ([Id_Factura]           ",
                                                        "           ,[Id_Material]          ",
                                                        "           ,[Cantidad_Comprada]      ",
                                                        "           ,[Precio_Compra]             ",
                                                        "           ,[Borrado])             ",
                                                        "     VALUES                        ",
                                                        "           (@id_factura            ",
                                                        "           ,@id_material           ",
                                                        "           ,@cantidad       ",
                                                        "           ,@precio              ",
                                                        "           ,@borrado)               ");

                    var paramDetalle = new Dictionary<string, object>();
                    paramDetalle.Add("id_factura",  factura.IdFactura);
                    paramDetalle.Add("id_material", itemFactura.Material.Id_material);
                    paramDetalle.Add("cantidad",    itemFactura.Cantidad);
                    paramDetalle.Add("precio", itemFactura.Material.Precio);
                    paramDetalle.Add("borrado",     false);
                    //paramDetalle.Add("id_lote",     itemFactura.Id_lote);


                    bd.EjecutarSQLCONPARAMETROS(sqlDetalle, paramDetalle);

                    string sqlStock = "UPDATE MATERIALES SET Stock = Stock + " + itemFactura.Cantidad + " WHERE Id_Material = " + itemFactura.id_material;
                    bd.EjecutarSQL(sqlStock);

                    string sqlLoteStock = "UPDATE LOTE SET Stock_Lote = Stock_Lote + " + itemFactura.Cantidad + " WHERE Id_Lote = " + itemFactura.Id_lote;
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
    }
}
