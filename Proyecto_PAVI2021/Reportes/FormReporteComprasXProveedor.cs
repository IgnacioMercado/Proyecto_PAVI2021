using Proyecto_PAVI2021.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PAVI2021.Reportes
{
    public partial class FormReporteComprasXProveedor : Form
    {
        FacturaService oFactura = new FacturaService();
        LocalidadService oLocalidad = new LocalidadService();
        public FormReporteComprasXProveedor()
        {
            InitializeComponent();
        }

        private void FormReporteComprasXProveedor_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.dtpFechaDesde.Value = DateTime.Today.AddYears(-2);
            this.dtpFechaHasta.Value = DateTime.Today.AddDays(1);
            LlenarComboConLista(cmbLocalidad, oLocalidad.RecuperarTodos(), "Descripcion", "Id_Localidad");
            
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string desde, hasta, nombre, localidad;
            desde = hasta = nombre = localidad = string.Empty;
            
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Fechas inválidas");
                dtpFechaDesde.Focus();
                return;
            }
            desde = dtpFechaDesde.Value.ToString("dd/MM/yyyy");
            hasta = dtpFechaHasta.Value.ToString("dd/MM/yyyy");
            if (cmbLocalidad.SelectedIndex != -1)
                localidad = cmbLocalidad.Text.ToString();
            if (txtNombre.Text != "")
                nombre = txtNombre.Text;

            this.dtComprasXProveedorBindingSource.DataSource = oFactura.RecuperarComprasXProveedor(desde, hasta, nombre, localidad);
            this.reportViewer1.RefreshReport();


        }
        private void LlenarComboConLista(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
