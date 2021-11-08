using Proyecto_PAVI2021.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PAVI2021.Presentacion.PresProveedores;
using Proyecto_PAVI2021.Servicios;

namespace Proyecto_PAVI2021.Presentacion.PresProveedores
{
    public partial class FormModificarProveedor : Form
    {
        private int id;
        //Cliente oCliente = new Cliente();
        ProveedorService oProv = new ProveedorService();
        BarrioService oBarrio = new BarrioService();
        LocalidadService oLocalidad = new LocalidadService();

        public FormModificarProveedor()
        {
            InitializeComponent();
            //btnModificar1.Enabled=true;
        }
        public FormModificarProveedor(int id_prov)
        {
            InitializeComponent();
            this.id = id_prov;
            txtId_Proveedor.Text = id_prov.ToString();
            btnModificar1.Enabled = true;
        }

        private void FormModificarProveedor_Load(object sender, EventArgs e)
        {
            
            LlenarCampos();

            
        }

        private void LlenarComboConLista(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.SelectedIndex = -1;
        }

        private void LlenarCampos()
        {
            DataTable tabla = new DataTable();

            tabla = oProv.RecuperarProveedorPorId(id);

            this.txtNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            this.txtTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            this.txtCuit.Text = tabla.Rows[0]["CUIT"].ToString();
            this.txtCalle.Text = tabla.Rows[0]["Calle"].ToString();
            this.txtAltura.Text = tabla.Rows[0]["Nro_Calle"].ToString();
            this.LlenarComboConLista(cboLocalidad, oLocalidad.RecuperarTodos(), "Descripcion", "Id_Localidad");
            this.LlenarComboConLista(cboBarrio, oBarrio.RecuperarPorLocalidad(Convert.ToInt32(tabla.Rows[0]["Id_Barrio"].ToString())), "Descripcion", "Id_Barrio");
            this.cboBarrio.SelectedValue = tabla.Rows[0]["Id_Barrio"].ToString();
            this.cboLocalidad.SelectedValue = tabla.Rows[0]["Id_Localidad"].ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre, telefono, cuit, calle, altura;
            int id_barrio, id_localidad;
            //string fechaAlta = DateTime.Now.ToString("dd/MM/yyyy");
            int id_Proveedor = int.Parse(txtId_Proveedor.Text);
            nombre = txtNombre.Text;
            telefono = txtTelefono.Text;
            cuit = txtCuit.Text;
            calle = txtCalle.Text;
            altura = txtAltura.Text;
            id_barrio = (int)cboBarrio.SelectedValue;
            id_localidad = (int)cboLocalidad.SelectedValue;

            if (nombre == "" || telefono == "" || cuit == "" || calle == "" || altura == "" || id_barrio == -1 || id_localidad == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de intentar registrar al Proveedor");
            }
            else
            {
                
                this.Close();
                oProv.ModificarProveedorPorId(id_Proveedor, nombre, telefono, cuit, calle, altura, id_barrio, id_localidad);
                MessageBox.Show("Proveedor Modificado");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboLocalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboBarrio.SelectedIndex = -1;
            this.LlenarComboConLista(cboBarrio, oBarrio.RecuperarPorLocalidad((int)cboLocalidad.SelectedValue), "Descripcion", "Id_Barrio");

        }
    }
}
