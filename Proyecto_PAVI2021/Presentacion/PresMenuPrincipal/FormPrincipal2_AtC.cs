using Proyecto_PAVI2021.Presentacion.PresBarrios;
using Proyecto_PAVI2021.Presentacion.PresFactura;
using Proyecto_PAVI2021.Presentacion.PresLocalidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PAVI2021.Presentacion.PresPrincipal
{
    public partial class FormPrincipal2_AtC : Form
    {
        public FormPrincipal2_AtC(string usuario_para_label)
        {
            InitializeComponent();
            PersonalizarDiseño();
            RellenarLabel(usuario_para_label);
        }
        private void RellenarLabel(string usuario_para_label)
        {
            labelNombreUsuario.Text = "Usuario:" + usuario_para_label;
        }
        private void PersonalizarDiseño()
        {
            //oculto los paneles
            //panelAdministracion.Visible = false;
            panelCompraVenta.Visible = false;
            //panelReportes.Visible = false;
            //panelSubMenuVentas.Visible = false;
            //panelProduccion.Visible = false;
            panelGestion.Visible = false;
        }

        private void HideSubMenu()
        {
            //if(panelAdministracion.Visible == true)
            //{
            //    //panel1
            //    panelAdministracion.Visible = false;
            //}
            if (panelCompraVenta.Visible == true)
            {//panel2
                panelCompraVenta.Visible = false;
            }
            //if (panelReportes.Visible == true)
            //{//panel3
            //    panelReportes.Visible = false;
            //}
            //if (panelSubMenuVentas.Visible == true)
            //{//panel4
            //    panelSubMenuVentas.Visible = false;
            //}
            //if (panelProduccion.Visible == true)
            //{//panel5
            //    panelProduccion.Visible = false;
            //}
            if (panelGestion.Visible == true)
            {//panel6
                panelGestion.Visible = false;
            }



        }
        private void ShowSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        
        

        private void FormPrincipal2_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //ShowSubmenu(panelSubMenuVentas);
            //panelCompraVenta.Visible = true;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //ShowSubmenu(panelAdministracion);
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            //ShowSubmenu(panelProduccion);
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelGestion);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            //ShowSubmenu(panelReportes);
        }

        private void btnCyV_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelCompraVenta);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //code
            HideSubMenu();
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            //code
            HideSubMenu();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            //code
            HideSubMenu();
        }

        private void btnFacturaciondePago_Click(object sender, EventArgs e)
        {
            //code
            HideSubMenu();
        }

        private void btnComposicion_Click(object sender, EventArgs e)
        {
            //code
            HideSubMenu();
        }

        private void btnLotes_Click(object sender, EventArgs e)
        {
            //code
            HideSubMenu();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            //code
            HideSubMenu();
        }

        private void btnTiposdeMateriales_Click(object sender, EventArgs e)
        {
            //code
            HideSubMenu();
        }

        private void btnUnidadesdeMedida_Click(object sender, EventArgs e)
        {
            //code
            HideSubMenu();
        }

        private void btnBarrios_Click(object sender, EventArgs e)
        {
            FormBarrios fb = new FormBarrios();
            fb.ShowDialog();
            HideSubMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes fc = new FormClientes("consultar");
            fc.ShowDialog();
            HideSubMenu();
        }

        private void btnLocalidades_Click(object sender, EventArgs e)
        {
            FormLocalidad fl = new FormLocalidad();
            fl.ShowDialog();
            HideSubMenu();
        }

        private void btnReporteVentasporClientesRe_Click(object sender, EventArgs e)
        {
            //code
            HideSubMenu();
        }

        private void btnReporteVentasporEmpleado_Click(object sender, EventArgs e)
        {
            //code
            HideSubMenu();
        }

        private void btnComprasporProveedor_Click(object sender, EventArgs e)
        {
            //code
            HideSubMenu();
        }

        private void btnPerfiles_Click(object sender, EventArgs e)
        {
            //code
            HideSubMenu();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            //code
            HideSubMenu();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormAltaFactura faf = new FormAltaFactura();
            faf.ShowDialog();
            HideSubMenu();
        }
    }
}
