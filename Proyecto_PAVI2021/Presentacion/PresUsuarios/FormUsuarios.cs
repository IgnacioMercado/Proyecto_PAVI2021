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

namespace Proyecto_PAVI2021.Presentacion
{
    public partial class FormUsuarios : Form
    {
        Perfil oPerfil = new Perfil();
        Usuario oUsuario = new Usuario();
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            this.dtpFechaDesde.Value = DateTime.Today.AddDays(-7);
            this.dtpFechaHasta.Value = DateTime.Today;
            this.CargarCombo(cmbPerfil, oPerfil.RecuperarTodos(),2,0);
            this.CargarGrilla(dgvUsuarios, oUsuario.RecuperarTodos());

        }

        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarCombo(ComboBox combo, DataTable tabla, int display, int value)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[display].ColumnName;
            combo.ValueMember = tabla.Columns[value].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["Id_Usuario"],
                    tabla.Rows[i]["Nombre_Usuario"],
                    tabla.Rows[i]["Fecha_Alta"],
                    tabla.Rows[i]["Perfil"]);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Fechas erroneas!!");
                dtpFechaHasta.Focus();
                return;
            }

            string rol;
            string desde = dtpFechaDesde.Value.ToString("dd/MM/yyyy");
            string hasta = dtpFechaHasta.Value.ToString("dd/MM/yyyy");
            rol = string.Empty;

            if (cmbPerfil.SelectedIndex != -1)
                rol = cmbPerfil.SelectedValue.ToString();
            this.CargarGrilla(dgvUsuarios, oUsuario.RecuperarFiltrados(desde, hasta, rol));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este usuario?.", "Confirmación de baja de usuario", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                oUsuario.BorrarUsuario((int)dgvUsuarios.CurrentRow.Cells[0].Value);
                MessageBox.Show("Usuario eliminado");
            }
            
            this.CargarGrilla(dgvUsuarios, oUsuario.RecuperarTodos());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificarUsuario fmu = new FormModificarUsuario((int)dgvUsuarios.CurrentRow.Cells[0].Value);

            fmu.ShowDialog();
            this.CargarGrilla(dgvUsuarios, oUsuario.RecuperarTodos());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAltaUsuarios fas = new FormAltaUsuarios();
            fas.ShowDialog();
            this.CargarGrilla(dgvUsuarios, oUsuario.RecuperarTodos());
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }        
    }
}
