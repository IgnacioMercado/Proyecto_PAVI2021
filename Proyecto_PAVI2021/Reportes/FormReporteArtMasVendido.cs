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
    public partial class FormReporteArtMasVendido : Form

    {
        FacturaService oFactura = new FacturaService();
        MarcaService oMarca = new MarcaService();
        public FormReporteArtMasVendido()
        {
            InitializeComponent();
        }

        private void FormReporteArtMasVendido_Load(object sender, EventArgs e)
        {
            
            this.dtpFechaDesde.Value = DateTime.Today.AddYears(-2);
            this.dtpFechaHasta.Value = DateTime.Today.AddDays(1);
            LlenarComboConLista(cmbMarca, oMarca.RecuperarTodos(), "Descripcion", "Id_Marca");
        }

        private void LlenarComboConLista(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string desde, hasta, nombre, marca;
            desde = hasta = nombre = marca = string.Empty;

            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Fechas inválidas");
                dtpFechaDesde.Focus();
                return;
            }
            desde = dtpFechaDesde.Value.ToString("dd/MM/yyyy");
            hasta = dtpFechaHasta.Value.ToString("dd/MM/yyyy");
            if (cmbMarca.SelectedIndex != -1)
                marca = cmbMarca.Text.ToString();
            if (txtNombre.Text != "")
                nombre = txtNombre.Text;

            this.dtArtMasVendidoBindingSource.DataSource = oFactura.RecuperarArtMasVendido(desde, hasta, nombre, marca);
            this.reportViewer1.RefreshReport();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
