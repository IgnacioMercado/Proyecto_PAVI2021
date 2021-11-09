using Proyecto_PAVI2021.Presentacion;
using Proyecto_PAVI2021.Presentacion.PresFormasPago;
using Proyecto_PAVI2021.Presentacion.PresLocalidad;
using Proyecto_PAVI2021.Presentacion.PresBarrios;
using Proyecto_PAVI2021.Presentacion.PresCompras;
using Proyecto_PAVI2021.Presentacion.PresFactura;
using Proyecto_PAVI2021.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PAVI2021
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {            
            frmLogin fl;
            fl = new frmLogin();
            fl.ShowDialog();

            if (fl.MiUsuario.Id_usuario == 0)
                this.Close();
            else
                this.Text += " - Usuario: " + fl.MiUsuario.Nombre;

            fl.Dispose();            
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios fus = new FormUsuarios();
            fus.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes fcs = new FormClientes("consultar");
            fcs.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formasDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFormasPago ffp = new FormFormasPago();
            ffp.ShowDialog();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocalidad frm = new FormLocalidad();
            frm.ShowDialog();
        }

        private void barriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBarrios fb = new FormBarrios();
            fb.ShowDialog();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersonal fps = new FormPersonal();
            fps.ShowDialog();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaFactura faf = new FormAltaFactura();
            faf.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompras fcompras = new FormCompras();
            fcompras.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteVentas frv = new FormReporteVentas();
            frv.ShowDialog();
        }

        private void comprasPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteComprasXProveedor frcxp = new FormReporteComprasXProveedor();
            frcxp.ShowDialog();
        }

        private void ventasPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteVentasXCliente frvxc = new FormReporteVentasXCliente();
            frvxc.ShowDialog();
        }

        private void ventasPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteVentasXE frvxe = new FormReporteVentasXE();
            frvxe.ShowDialog();
        }        
    }
}
