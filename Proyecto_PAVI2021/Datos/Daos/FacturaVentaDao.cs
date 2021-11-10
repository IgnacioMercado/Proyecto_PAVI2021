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

                //insercion de los pagos por factura
                foreach (var pago in factura.PagosPorFactura)
                {
                    string sqlPagos = string.Concat(" INSERT INTO [dbo].[PAGOS_X_FACTURA] ",
                                                        "           ([Id_Factura]           ",
                                                        "           ,[Id_Forma_Pago]        ",
                                                        "           ,[Monto]                ",
                                                        "           ,[Borrado])             ",
                                                        "     VALUES                        ",
                                                        "           (@id_factura            ",
                                                        "           ,@id_forma_pago           ",
                                                        "           ,@monto               ",
                                                        "           ,@borrado)               ");

                    var paramPago = new Dictionary<string, object>();
                    paramPago.Add("id_factura", factura.IdFactura);
                    paramPago.Add("id_forma_pago", pago.Id_forma_pago);
                    paramPago.Add("monto", pago.Monto);
                    paramPago.Add("borrado", false);

                    bd.EjecutarSQLCONPARAMETROS(sqlPagos, paramPago);
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

        public DataTable RecuperarVentas(string desde, string hasta, string nombreC, string apellidoC, string nombreE, string apellidoE)
        {
            string consulta = "SELECT FV.Id_Factura, FV.Tipo_Factura, CONCAT(C.Nombre, ' ', C.Apellido) as Cliente, FV.Fecha_Factura, " +
                              "CONCAT(P.Nombre, ' ', P.Apellido) Empleado, SUM(DFV.Cantidad_Vendida*DFV.Precio_Venta) Monto " +
                              "FROM FACTURA_VENTA FV " +
                              "JOIN CLIENTES C ON(FV.Id_Cliente = C.Id_Cliente) " +
                              "JOIN PERSONAL P ON(FV.Legajo_Empleado= P.Legajo) " +
                              "JOIN DETALLE_FACTURA_VENTAS DFV ON(FV.Id_Factura= DFV.Id_Factura) " +
                              "WHERE C.Borrado = 0 AND FV.Borrado = 0 AND DFV.Borrado = 0 " +
                              "AND FV.Fecha_Factura BETWEEN CONVERT(DateTime, '" + desde + "', 103)  AND CONVERT(DateTime, '" + hasta + "', 103)";

            if (!string.IsNullOrEmpty(nombreC))
                consulta += " AND C.Nombre LIKE '%" + nombreC + "%'";
            if (!string.IsNullOrEmpty(apellidoC))
                consulta += " AND C.Apellido LIKE '%" + apellidoC + "%'";
            if (!string.IsNullOrEmpty(nombreE))
                consulta += " AND P.Nombre LIKE '%" + nombreE + "%'";
            if (!string.IsNullOrEmpty(apellidoE))
                consulta += " AND P.Apellido LIKE '%" + apellidoE + "%'";

            consulta += " GROUP BY FV.Id_Factura, FV.Tipo_Factura, C.Nombre, C.Apellido, FV.Fecha_Factura, P.Nombre, P.Apellido" +
                        " ORDER BY FV.Fecha_Factura DESC";
            return BDHelper.obtenerInstancia().consultar(consulta);
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

        public DataTable RecuperarVentasXEmpleado(string desde, string hasta, string nombre, string apellido, string alta_desde, string alta_hasta)
        {
            string consulta = "SELECT P.Legajo, P.Nombre, P.Apellido, COUNT(DISTINCT FV.Id_Factura) as Total_Ventas, SUM(DFV.Cantidad_Vendida*DFV.Precio_Venta) as Monto " +
                              "FROM PERSONAL P " +
                              "JOIN FACTURA_VENTA FV ON(P.Legajo = FV.Legajo_Empleado) " +
                              "JOIN DETALLE_FACTURA_VENTAS DFV ON(FV.Id_Factura= DFV.Id_Factura) " +
                              "WHERE P.Borrado = 0 AND FV.Borrado = 0 AND DFV.Borrado = 0 " +
                             // "AND C.Fecha_Alta BETWEEN CONVERT(DateTime, '" + alta_desde + "', 103)  AND CONVERT(DateTime, '" + alta_hasta + "', 103) " +
                              "AND FV.Fecha_Factura BETWEEN CONVERT(DateTime, '" + desde + "', 103)  AND CONVERT(DateTime, '" + hasta + "', 103)";

            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND P.Nombre LIKE '%" + nombre + "%'";
            if (!string.IsNullOrEmpty(apellido))
                consulta += " AND P.Apellido LIKE '%" + apellido + "%'";

            consulta += " GROUP BY P.Legajo, P.Apellido, P.Nombre";
            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable RecuperarArtMasVendido(string desde, string hasta, string nombre, string marca)
        {
            string consulta = "SELECT TOP 5 m.Id_Material, m.Nombre, ms.Descripcion as Marca, SUM(dfv.Cantidad_Vendida) as Cantidad, SUM(dfv.Precio_Venta * dfv.Cantidad_Vendida) as TotalVentas " +
                "FROM MATERIALES m JOIN MARCAS ms on m.Id_Marca = ms.Id_Marca JOIN DETALLE_FACTURA_VENTAS dfv on m.Id_Material = dfv.Id_Material " +
                "JOIN FACTURA_VENTA fv on fv.Id_Factura = dfv.Id_Factura " +
                "WHERE m.Borrado = 0 AND dfv.Borrado = 0 " +
                "AND fv.Fecha_Factura BETWEEN CONVERT(DateTime, '" + desde + "', 103)  AND CONVERT(DateTime, '" + hasta + "', 103)";

            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND m.Nombre LIKE '%" + nombre + "%'";
            if (!string.IsNullOrEmpty(marca))
                consulta += " AND ms.Descripcion LIKE '" + marca + "'";
            consulta += " GROUP BY m.Id_Material, m.Nombre, ms.Descripcion ORDER BY Cantidad DESC";
            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
