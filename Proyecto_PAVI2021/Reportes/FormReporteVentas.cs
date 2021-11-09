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
    public partial class FormReporteVentas : Form
    {
        FacturaService oFacturaService = new FacturaService();
        public FormReporteVentas()
        {
            InitializeComponent();
        }

        private void FormReporteVentas_Load(object sender, EventArgs e)
        {
            this.dtpFechaDesde.Value = DateTime.Today.AddYears(-1);
            this.dtpFechaHasta.Value = DateTime.Today;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string desde, hasta, nombreC, apellidoC, nombreE, apellidoE;
            nombreC = apellidoC = nombreE = apellidoE = string.Empty;

            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Fechas inválidas");
                dtpFechaDesde.Focus();
                return;
            }
            desde = dtpFechaDesde.Value.ToString("dd/MM/yyyy");
            hasta = dtpFechaHasta.Value.ToString("dd/MM/yyyy");

            if (txtNombreC.Text != "")
                nombreC = txtNombreC.Text;
            if (txtApellidoC.Text != "")
                apellidoC = txtApellidoC.Text;
            if (txtNombreE.Text != "")
                nombreE = txtNombreE.Text;
            if (txtApellidoE.Text != "")
                apellidoE = txtApellidoE.Text;

            this.dtVentasBindingSource.DataSource = oFacturaService.RecuperarVentas(desde, hasta, nombreC, apellidoC, nombreE, apellidoE);
            this.reportViewer1.RefreshReport();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.dtpFechaDesde.Value = DateTime.Today.AddYears(-2);
            this.dtpFechaHasta.Value = DateTime.Today;
            this.txtNombreC.Clear();
            this.txtApellidoC.Clear();
            this.txtNombreE.Clear();
            this.txtApellidoE.Clear();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
