using Proyecto_PAVI2021.Negocio;
using Proyecto_PAVI2021.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAutopartes.Presentacion.PresFactura
{
    public partial class FormAltaFactura : Form
    {
        public int Id_Cliente_Seleccionado;
        private List<string> TiposFactura = new List<string> { "A", "B", "C" };
        Cliente oClienteSeleccionado = new Cliente();

        public FormAltaFactura()
        {
            InitializeComponent();
        }

        private void FormAltaFactura_Load(object sender, EventArgs e)
        {
            this.txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");            
            cboTipoFactura.DataSource = TiposFactura;            
            cboTipoFactura.SelectedIndex = -1;
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            FormClientes fcs = new FormClientes("seleccionar");
            fcs.ShowDialog();
            this.Id_Cliente_Seleccionado = fcs.Id_Cliente_Seleccionado;
            
            if (this.Id_Cliente_Seleccionado != -1)
                this.CargarCliente();
        }

        private void CargarCliente()
        {
            DataTable tabla = new DataTable();
            Cliente oClienteSeleccionado = new Cliente();
            tabla = oClienteSeleccionado.RecuperarClientePorId(Id_Cliente_Seleccionado);
            this.txtNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            this.txtApellido.Text = tabla.Rows[0]["Apellido"].ToString();
            this.txtTipoDoc.Text = tabla.Rows[0]["Tipo_Doc"].ToString();
            this.txtNroDoc.Text = tabla.Rows[0]["Nro_Doc"].ToString();
            this.txtCalle.Text = tabla.Rows[0]["Calle"].ToString();
            this.txtAltura.Text = tabla.Rows[0]["Nro_Calle"].ToString();
        }
    }
}
