using Proyecto_PAVI2021.Presentacion.PresCompras;
using Proyecto_PAVI2021.Presentacion.PresLotes;
using Proyecto_PAVI2021.Presentacion.PresMarcas;
using Proyecto_PAVI2021.Presentacion.PresMateriales;
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
    public partial class FormPrincipal2_Emp : Form
    {
        public FormPrincipal2_Emp(string usuario_para_label)
        {
            InitializeComponent();
            PersonalizarDiseño();
            RellenarLabel(usuario_para_label);
        }
        private void RellenarLabel(string usuario_para_label)
        {
            labelNombreUsuario.Text = "Usuario: "+ usuario_para_label;
        }
        private void PersonalizarDiseño()
        {
            //oculto los paneles
            
            panelProduccion.Visible = false;
            
        }

        private void HideSubMenu()
        {
            
            if (panelProduccion.Visible == true)
            {//panel5
                panelProduccion.Visible = false;
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

        

        private void btnProd_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelProduccion);
        }



        private void btnCompras_Click(object sender, EventArgs e)
        {
            FormCompras fc = new FormCompras();
            fc.ShowDialog();
            HideSubMenu();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnLotes_Click(object sender, EventArgs e)
        {
            FormLotes fl = new FormLotes();
            fl.ShowDialog();
            HideSubMenu();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            FormMateriales fm = new FormMateriales();
            fm.ShowDialog();
            HideSubMenu();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            FormMarcas fm = new FormMarcas();
            fm.ShowDialog();
            HideSubMenu();
        }
    }
}
