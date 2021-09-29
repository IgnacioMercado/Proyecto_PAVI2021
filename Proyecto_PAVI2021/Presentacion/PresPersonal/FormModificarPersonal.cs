using Proyecto_PAVI2021.Negocio;
using ProyectoAutopartes.Negocio;
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

        Cliente oCliente = new Cliente();
        Personal oPersonal = new Personal();
        Barrio oBarrio = new Barrio();
        Localidad oLocalidad = new Localidad();
        Usuario oUsuario = new Usuario();

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
            CargarCombo(cmbBarrios, oBarrio.RecuperarTodos());
            CargarCombo(cmbLocalidades, oLocalidad.RecuperarTodos());
            CargarCombo(cmbUsuarios, oUsuario.RecuperarTodos());


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
            Personal oPersonalSeleccionado = new Personal();
            tabla = oPersonalSeleccionado.RecuperarPersonalPorLegajo(legajo);
            txtNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            txtApellido.Text = tabla.Rows[0]["Apellido"].ToString();
            txtTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            cboTipoDoc.Text = tabla.Rows[0]["Tipo_Doc"].ToString();
            txtNroDoc.Text = tabla.Rows[0]["Nro_Doc"].ToString();
            txtCalle.Text = tabla.Rows[0]["Calle"].ToString();
            txtAltura.Text = tabla.Rows[0]["Nro_Calle"].ToString();




        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //string nombre, apellido, nro_doc, tipo_doc, telefono, calle, altura, barrio, localidad, usuario;
            //nombre = txtNombre.Text;
            //apellido = txtApellido.Text;
            //telefono = txtTelefono.Text;
            //tipo_doc = txtTipoDoc.Text;
            //nro_doc = txtNroDoc.Text;
            //calle = txtCalle.Text;
            //altura = txtAltura.Text;
            //barrio = cmbBarrios.SelectedValue.ToString();
            //localidad = cmbLocalidades.SelectedValue.ToString();
            //usuario = cmbUsuarios.SelectedValue.ToString();

            //if (nombre == "" || apellido == "" || telefono == "" || nro_doc == "" || tipo_doc == "" || calle == "" || altura == "" || cmbBarrios.SelectedIndex == -1 || cmbUsuarios.SelectedIndex == -1 || cmbLocalidades.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Por favor, complete todos los campos antes de intentar modificar al cliente");
            //}
            //else
            //{
            //    oPersonal.ModificarPersonalPorLegajo(legajo, nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura, barrio, localidad, usuario);
            //    MessageBox.Show("Cliente modificado con exito");
            //}

        }

        private void btnModificar1_Click(object sender, EventArgs e)
        {
            string nombre, apellido, nro_doc, tipo_doc, telefono, calle, altura, barrio, localidad, usuario;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            telefono = txtTelefono.Text;
            tipo_doc = cboTipoDoc.Text;
            nro_doc = txtNroDoc.Text;
            calle = txtCalle.Text;
            altura = txtAltura.Text;
            barrio = cmbBarrios.SelectedValue.ToString();
            localidad = cmbLocalidades.SelectedValue.ToString();
            usuario = cmbUsuarios.SelectedValue.ToString();

            if (nombre == "" || apellido == "" || telefono == "" || nro_doc == "" || tipo_doc == "" || calle == "" || altura == "" || cmbBarrios.SelectedIndex == -1 || cmbUsuarios.SelectedIndex == -1 || cmbLocalidades.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de intentar modificar al empleado");
            }
            else
            {
                oPersonal.ModificarPersonalPorLegajo(legajo, nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura, barrio, localidad, usuario);
                MessageBox.Show("Empleado modificado con exito");
            }

        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal ventana = new FormPrincipal();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
