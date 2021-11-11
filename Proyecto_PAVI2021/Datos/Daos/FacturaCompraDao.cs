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


                    bd.EjecutarSQLCONPARAMETROS(sqlDetalle, paramDetalle);

                    string sqlLote = "INSERT INTO LOTE ([Fecha_Lote], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado], [Cantidad_Fabricada]) " +
                        "VALUES (CONVERT(DateTime, '" + factura.Fecha + "', 103), " + factura.Legajo_Empleado + ", 1, " + itemFactura.Cantidad + ", " + itemFactura.Material.Id_material + ", 0, 0)";

                    bd.EjecutarSQL(sqlLote);

                    string sqlStock = "UPDATE MATERIALES SET Stock = Stock + " + itemFactura.Cantidad + " WHERE Id_Material = " + itemFactura.id_material;
                    bd.EjecutarSQL(sqlStock);

                    

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

        public DataTable RecuperarComprasXProveedor(string desde, string hasta, string nombre, string localidad)
        {
            string consulta = "SELECT p.Id_Proveedor, p.Nombre, l.Descripcion as Localidad, COUNT(DISTINCT FC.Id_Factura) as Cantidad, SUM(DFC.Cantidad_Comprada*DFC.Precio_Compra) as MontoTotal " +
                              "FROM PROVEEDORESS p JOIN BARRIOS b on b.Id_Barrio = p.Id_Barrio JOIN LOCALIDADES l on b.Id_Localidad = l.Id_Localidad " +
                              "JOIN FACTURA_COMPRA FC ON p.Id_Proveedor = FC.Id_Proveedor " +
                              "JOIN DETALLE_FACTURA_COMPRAS DFC ON FC.Id_Factura = DFC.Id_Factura " +
                              "WHERE p.Borrado = 0 AND FC.Borrado = 0 AND DFC.Borrado = 0 " +
                              "AND FC.Fecha_Factura BETWEEN CONVERT(DateTime, '" + desde + "', 103)  AND CONVERT(DateTime, '" + hasta + "', 103)";


            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND p.Nombre LIKE '%" + nombre + "%'";
            if (!string.IsNullOrEmpty(localidad))
                consulta += " AND l.Descripcion LIKE '%" + localidad + "%'";

            consulta += " GROUP BY p.Id_Proveedor, p.Nombre, l.Descripcion ";
            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        
    }
}
