using Proyecto_PAVI2021.Negocio;
using Proyecto_PAVI2021.Presentacion.PresClientes;
using Proyecto_PAVI2021.Presentacion.PresPersonal;
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

namespace Proyecto_PAVI2021.Presentacion
{
    public partial class FormPersonal : Form
    {
        Perfil oPerfil = new Perfil();
        Personal oPersonal = new Personal();
        Usuario oUsuario = new Usuario();
        Cliente oCliente = new Cliente();
        Barrio oBarrio = new Barrio();
        Localidad oLocalidad = new Localidad();
        public FormPersonal()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            
            this.CargarGrilla(dgvPersonal, oPersonal.RecuperarTodos());
            this.CargarCombo(cmbBarrios, oBarrio.RecuperarTodos());
            this.CargarCombo(cmbLocalidades, oLocalidad.RecuperarTodos());

        }

        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["Legajo"],
                    tabla.Rows[i]["Nombre"],
                    tabla.Rows[i]["Apellido"],
                    tabla.Rows[i]["Usuario"],
                    tabla.Rows[i]["Rol"],
                    tabla.Rows[i]["Telefono"],
                    tabla.Rows[i]["Tipo_Doc"],
                    tabla.Rows[i]["Nro_Doc"],
                    tabla.Rows[i]["Calle"],
                    tabla.Rows[i]["Nro_Calle"],
                    tabla.Rows[i]["Barrio"],
                    tabla.Rows[i]["Localidad"]
                    );

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, telefono, nro_doc, tipo_doc, calle, altura, usuario, barrio, localidad;
            nombre = apellido = telefono = nro_doc = tipo_doc = calle = altura = usuario = barrio = localidad = string.Empty;
            if (txtNombre.Text != "")
                nombre = txtNombre.Text;
            if (txtApellido.Text != "")
                apellido = txtApellido.Text;
            if (txtUsuario.Text != "")
                usuario = txtUsuario.Text;
            if (txtTelefono.Text != "")
                telefono = txtTelefono.Text;
            //if (txtTipoDoc.Text != "")
            //    tipo_doc = txtTipoDoc.Text;
            if (txtNroDoc.Text != "")
                nro_doc = txtNroDoc.Text;
            if (txtCalle.Text != "")
                calle = txtCalle.Text;
            if (txtAltura.Text != "")
                altura = txtAltura.Text;
            if (cboTipoDoc.SelectedIndex != -1)
                tipo_doc = cboTipoDoc.Text;
            if (cmbBarrios.SelectedIndex != -1)
                barrio = cmbBarrios.SelectedValue.ToString();
            if (cmbLocalidades.SelectedIndex != -1)
                localidad = cmbLocalidades.SelectedValue.ToString();

            this.CargarGrilla(dgvPersonal, oPersonal.RecuperarFiltrados(nombre, apellido, telefono, tipo_doc, nro_doc, calle, altura, usuario, barrio, localidad));



            //string rol;
            //string desde = dtpFechaDesde.Value.ToString("dd/MM/yyyy");
            //string hasta = dtpFechaHasta.Value.ToString("dd/MM/yyyy");
            //rol = string.Empty;

            //if (cmbPerfil.SelectedIndex != -1)
                //rol = cmbPerfil.SelectedValue.ToString();
            //this.CargarGrilla(dgvClientes, oUsuario.RecuperarFiltrados(desde, hasta, rol));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este cliente?.", "Confirmación de baja de cliente", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                oPersonal.BorrarPersonal((int)dgvPersonal.CurrentRow.Cells[0].Value);
                MessageBox.Show("Empleado eliminado");
            }
            
            this.CargarGrilla(dgvPersonal, oPersonal.RecuperarTodos());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificarPersonal fmp = new FormModificarPersonal((int)dgvPersonal.CurrentRow.Cells[0].Value);

            fmp.ShowDialog();
            this.CargarGrilla(dgvPersonal, oPersonal.RecuperarTodos());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAltaPersonal fap = new FormAltaPersonal();
            fap.ShowDialog();
            this.CargarGrilla(dgvPersonal, oPersonal.RecuperarTodos());
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal ventana = new FormPrincipal();
        }
    }
}
