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

namespace Proyecto_PAVI2021.Presentacion
{
    public partial class FormAltaPersonal : Form

    {
        BarrioService oBarrio = new BarrioService();
        UsuarioService oUsuario = new UsuarioService();
        PersonalService oPersonal = new PersonalService();
        LocalidadService oLocalidad = new LocalidadService();

        public FormAltaPersonal()
        {
            InitializeComponent();
        }

        private void FormAltaPersonal_Load(object sender, EventArgs e)
        {
            CargarCombo(cmbBarrios, oBarrio.RecuperarTodos());
            CargarCombo(cmbUsuarios, oUsuario.RecuperarTodos());
            CargarCombo(cmbLocalidades, oLocalidad.RecuperarTodos());

        }

        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, nro_doc, tipo_doc, telefono, calle, altura, barrio, localidad, usuario;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            telefono = txtTelefono.Text;
            tipo_doc = cboTipoDoc.Text;
            nro_doc = txtNroDoc.Text;
            calle = txtCalle.Text;
            altura = txtAltura.Text;
            barrio = string.Empty;
            localidad = string.Empty;
            usuario = string.Empty;
            if (cmbBarrios.SelectedIndex != -1)
                barrio = cmbBarrios.SelectedValue.ToString();
            if (cmbLocalidades.SelectedIndex != -1)
                localidad = cmbLocalidades.SelectedValue.ToString();
            if (cmbUsuarios.SelectedIndex != -1)
                usuario = cmbUsuarios.SelectedValue.ToString();

            if (nombre == "" || apellido == "" || telefono == "" || nro_doc == "" || tipo_doc == "" || calle == "" || altura == "" || barrio == "" || usuario == "" || localidad == "")
            {
                MessageBox.Show("Por favor, complete todos los campos antes de intentar registrar al empleado");
            }
            else
            {
                oPersonal.RegistrarPersonal(nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura, barrio, localidad, usuario);
                MessageBox.Show("Empleado registrado");
                this.Close();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
