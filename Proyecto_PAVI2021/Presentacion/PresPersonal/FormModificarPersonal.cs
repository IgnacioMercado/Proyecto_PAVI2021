using Proyecto_PAVI2021.Negocio;
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

namespace Proyecto_PAVI2021.Presentacion.PresPersonal
{
    public partial class FormModificarPersonal : Form
    {
        private int legajo;
        private string id_barrio;
        private string id_localidad;
        private string id_usuario;

        PersonalService oPersonal = new PersonalService();
        BarrioService oBarrio = new BarrioService();
        LocalidadService oLocalidad = new LocalidadService();
        UsuarioService oUsuario = new UsuarioService();

        public FormModificarPersonal()
        {
            InitializeComponent();
        }

        public FormModificarPersonal(int legajo)
        {
            InitializeComponent();
            this.legajo = legajo;

        }

        private void FormModificarPersonal_Load(object sender, EventArgs e)
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

        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LlenarCampos()
        {
            DataTable tabla = new DataTable();
            
            tabla = oPersonal.RecuperarPersonalPorLegajo(legajo);
            txtNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            txtApellido.Text = tabla.Rows[0]["Apellido"].ToString();
            txtTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            cboTipoDoc.Text = tabla.Rows[0]["Tipo_Doc"].ToString();
            txtNroDoc.Text = tabla.Rows[0]["Nro_Doc"].ToString();
            txtCalle.Text = tabla.Rows[0]["Calle"].ToString();
            txtAltura.Text = tabla.Rows[0]["Nro_Calle"].ToString();
            this.LlenarComboConLista(cmbLocalidades, oLocalidad.RecuperarTodos(), "Descripcion", "Id_Localidad");
            this.LlenarComboConLista(cmbBarrios, oBarrio.RecuperarPorLocalidad(Convert.ToInt32(tabla.Rows[0]["Id_Barrio"].ToString())), "Descripcion", "Id_Barrio");
            this.LlenarComboConLista(cmbUsuarios, oUsuario.RecuperarTodos(), "Nombre_Usuario", "Id_Usuario");
            this.cmbUsuarios.SelectedValue = tabla.Rows[0]["Id_Usuario"].ToString();
            this.cmbBarrios.SelectedValue = tabla.Rows[0]["Id_Barrio"].ToString();
            this.cmbLocalidades.SelectedValue = tabla.Rows[0]["Id_Localidad"].ToString();

        }        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, nro_doc, tipo_doc, telefono, calle, altura, barrio, localidad, usuario;
            nombre = apellido = nro_doc = tipo_doc = telefono = calle = altura = barrio = localidad = usuario = string.Empty;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            telefono = txtTelefono.Text;
            if(cboTipoDoc.SelectedIndex != -1)
                tipo_doc = cboTipoDoc.Text;
            nro_doc = txtNroDoc.Text;
            calle = txtCalle.Text;
            altura = txtAltura.Text;
            if(cmbBarrios.SelectedIndex != -1)
                barrio = cmbBarrios.SelectedValue.ToString(); ;
            if(cmbLocalidades.SelectedIndex != -1)    
                localidad = cmbLocalidades.SelectedValue.ToString();
            if(cmbUsuarios.SelectedIndex != -1)
                usuario = cmbUsuarios.SelectedValue.ToString();

            if (nombre == "" || apellido == "" || telefono == "" || nro_doc == "" || tipo_doc == "" || calle == "" || altura == "" || cmbBarrios.SelectedIndex == -1 || cmbUsuarios.SelectedIndex == -1 || cmbLocalidades.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de intentar modificar al empleado");
            }
            else
            {
                oPersonal.ModificarPersonalPorLegajo(legajo, nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura, barrio, localidad, usuario);
                MessageBox.Show("Empleado modificado");
                this.Close();
            }
        }
    
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbLocalidades_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbBarrios.SelectedIndex = -1;
            this.LlenarComboConLista(cmbBarrios, oBarrio.RecuperarPorLocalidad((int)cmbLocalidades.SelectedValue), "Descripcion", "Id_Barrio");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbBarrios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
