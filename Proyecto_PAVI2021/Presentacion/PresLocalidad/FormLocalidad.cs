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

namespace Proyecto_PAVI2021.Presentacion.PresLocalidad
{
    public partial class FormLocalidad : Form
    {
        Localidad oLocal = new Localidad();
        public FormLocalidad()
        {
            InitializeComponent(); 
        }

        private void FormLocalidad_Load(object sender, EventArgs e)
        {
            this.btnModificar.Enabled = false;
            this.CargarCombo(cmbLocalidad, oLocal.RecuperarTodos(), 1, 0);
            this.CargarGrilla(dgvLocalidad, oLocal.RecuperarTodos());
        }
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_Localidad"],
                    tabla.Rows[i]["Descripcion"],
                    tabla.Rows[i]["Borrado"]);
            }
        }
        private void CargarCombo(ComboBox combo, DataTable tabla, int display, int value)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[display].ColumnName;
            combo.ValueMember = tabla.Columns[value].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string descripcion = string.Empty;

            //if (cmbLocalidad.SelectedIndex != -1)
            //{
            //    //rol = cmbPerfil.SelectedValue.ToString();
            //    //id_Localidad = cmbLocalidad.SelectedValue.ToString();
            //    //id_Localidad = txtBuscar.Text;
            //}     
            if (txtBuscar.Text != string.Empty)
            {
                descripcion = txtBuscar.Text;
            }
            else
            {
                MessageBox.Show("Ingrese alguna Localidad");
            }

            this.CargarGrilla(dgvLocalidad, oLocal.RecuperarPorDescripcion(descripcion));
        }

        private void CargarGrilla(DataGridView dgvLocalidad, object p)
        {
            throw new NotImplementedException();
        }

        private void dgvLocalidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int indice = e.RowIndex;
            if (indice >= 0)
            {
                try
                {
                    btnModificar.Enabled = true;
                    DataGridViewRow filaSeleccionada = dgvLocalidad.Rows[indice];
                    string id_localidad = filaSeleccionada.Cells[0].Value.ToString();
                    string nombre_Localidad = filaSeleccionada.Cells[1].Value.ToString();
                    DataTable tabla = oLocal.RecuperarFiltrados(id_localidad);
                    CargarCampos(oLocal, id_localidad, nombre_Localidad);
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Comuniquese con el administrador del sistema");
                    Application.Exit();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string nuevo_nombre = txtLocalidadNueva.Text;
                string id = txtId.Text;
                oLocal.ModificarLocalidadPorId(id, nuevo_nombre);

                this.CargarGrilla(dgvLocalidad, oLocal.RecuperarTodos());

                MessageBox.Show("Localidad modificada");
                btnModificar.Enabled = false;
                LimpiarCampos();
            }
            catch (Exception)
            {
                throw;
            }
            //txtLocalidadActual.Text = dgvLocalidad.CurrentRow.Cells[0].ToString();            
        }
        private void CargarCampos(Localidad oLocal,string id, string nombre)
        {
            txtLocalidadActual.Text = nombre.ToString();
            txtId.Text = id.ToString();
        }

        private void LimpiarCampos()
        {
            txtId.Text = string.Empty;
            txtBuscar.Text = string.Empty;
            txtLocalidadActual.Text = string.Empty;
            txtLocalidadNueva.Text = string.Empty;
            txtNuevaLocalidad.Text = string.Empty;
            btnModificar.Enabled = false;
            this.CargarGrilla(dgvLocalidad, oLocal.RecuperarTodos());

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNuevaLocalidad.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe completar el nombre de la localidad");
            }
            else
            {
                Localidad oLocal = new Localidad();
                string nuevaLoc = txtNuevaLocalidad.Text;
                try
                {
                    oLocal.RegistrarLocalidad(nuevaLoc);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
                MessageBox.Show("Localidad registrada");
                LimpiarCampos();
            }           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
