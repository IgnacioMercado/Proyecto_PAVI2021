using ProyectoAutopartes.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAutopartes.Reportes
{
    public partial class FormReporteVentasXCliente : Form
    {
        FacturaService oFactura = new FacturaService();
        public FormReporteVentasXCliente()
        {
            InitializeComponent();
        }

        private void FormReporteVentasXCliente_Load(object sender, EventArgs e)
        {
            this.dtpFechaDesde.Value = DateTime.Today.AddYears(-2);
            this.dtpFechaHasta.Value = DateTime.Today.AddDays(1);
            this.dtpFechaAltaDesde.Value = DateTime.Today.AddYears(-2);
            this.dtpFechaAltaHasta.Value = DateTime.Today.AddDays(1);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string desde, hasta, nombre, apellido, alta_desde, alta_hasta;
            desde = hasta = nombre = apellido = alta_desde = alta_hasta = string.Empty;

            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Fechas inválidas");
                dtpFechaDesde.Focus();
                return;
            }
            desde = dtpFechaDesde.Value.ToString("dd/MM/yyyy");
            hasta = dtpFechaHasta.Value.ToString("dd/MM/yyyy");
            if (dtpFechaAltaDesde.Value > dtpFechaAltaHasta.Value)
            {
                MessageBox.Show("Fechas inválidas");
                dtpFechaAltaDesde.Focus();
                return;
            }
            alta_desde = dtpFechaAltaDesde.Value.ToString("dd/MM/yyyy");
            alta_hasta = dtpFechaAltaHasta.Value.ToString("dd/MM/yyyy");

            if (txtNombre.Text != "")
                nombre = txtNombre.Text;
            if (txtApellido.Text != "")
                apellido = txtApellido.Text;

            this.dtVentasXClienteBindingSource.DataSource = oFactura.RecuperarVentasXCliente(desde, hasta, nombre, apellido, alta_desde, alta_hasta);
            this.reportViewer1.RefreshReport();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.dtpFechaDesde.Value = DateTime.Today.AddYears(-2);
            this.dtpFechaHasta.Value = DateTime.Today;
            this.dtpFechaAltaDesde.Value = DateTime.Today.AddYears(-2);
            this.dtpFechaAltaHasta.Value = DateTime.Today;
            this.txtNombre.Clear();
            this.txtApellido.Clear();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
