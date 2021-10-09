using Proyecto_PAVI2021.Datos;
using ProyectoAutopartes.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAutopartes.Datos.Daos
{
    class FormaDePagoDao : IFormaDePago
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM FORMAS_PAGO WHERE Borrado = 0 ORDER BY Id_Forma_Pago";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public void RegistrarFormaPago(string descripcion)
        {
            string consulta = "INSERT INTO FORMAS_PAGO (Descripcion) " +
                              "VALUES ('" + descripcion + "')";

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public void ModificarFormaPago(string descripcion, int id)
        {
            string consulta = "UPDATE FORMAS_PAGO SET Descripcion = '" + descripcion + "' WHERE Id_Forma_Pago = " + id;

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }

        public void EliminarFormaPago(int id)
        {
            string consulta = "UPDATE FORMAS_PAGO SET Borrado = 1 WHERE Id_Forma_Pago = " + id;

            BDHelper.obtenerInstancia().EjecutarConsulta(consulta);
        }
    }
}
