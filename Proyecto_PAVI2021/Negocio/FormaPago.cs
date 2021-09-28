using Proyecto_PAVI2021.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI2021.Negocio
{
    class FormaPago
    {
        private int id_forma_pago;
        private string descripcion;
        private bool borrado;

        public int Id_forma_pago { get => id_forma_pago; set => id_forma_pago = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM FORMAS_PAGO WHERE Borrado = 0 ORDER BY Id_Forma_Pago";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }

        public void RegistrarFormaPago(string descripcion)
        {
            string consulta = "INSERT INTO FORMAS_PAGO (Descripcion) " +
                              "VALUES ('" + descripcion + "')";
            BDHelper oDatos = new BDHelper();
            oDatos.EjecutarConsulta(consulta);
        }

        public void ModificarFormaPago(string descripcion, int id)
        {
            string consulta = "UPDATE FORMAS_PAGO SET Descripcion = '" + descripcion + "' WHERE Id_Forma_Pago = " + id;
            BDHelper oDatos = new BDHelper();
            oDatos.EjecutarConsulta(consulta);
        }
        public void EliminarFormaPago(int id)
        {
            string consulta = "UPDATE FORMAS_PAGO SET Borrado = 1 WHERE Id_Forma_Pago = " + id;
            BDHelper oDatos = new BDHelper();
            oDatos.EjecutarConsulta(consulta);
        }
    }
}

