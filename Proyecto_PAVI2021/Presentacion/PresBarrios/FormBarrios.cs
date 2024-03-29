﻿using Proyecto_PAVI2021;
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

namespace Proyecto_PAVI2021.Presentacion.PresBarrios
{
    public partial class FormBarrios : Form
    {
        BarrioService oBarrio = new BarrioService();
        LocalidadService oLocalidad = new LocalidadService();
        public FormBarrios()
        {
            InitializeComponent();
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["Id_Barrio"],
                    tabla.Rows[i]["Descripcion"],
                    tabla.Rows[i]["Localidad"]);
            }    
        }

        private void FormBarrios_Load(object sender, EventArgs e)
        {
            this.LlenarComboConLista(cmbLocalidad, oLocalidad.RecuperarTodos(), "Descripcion", "Id_Localidad");
            this.CargarGrilla(dgvBarrios, oBarrio.RecuperarTodos());
        }
        private void LlenarComboConLista(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este barrio?.", "Confirmación de baja de barrio", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                oBarrio.EliminarBarrio((int)dgvBarrios.CurrentRow.Cells[0].Value);
                MessageBox.Show("Barrio eliminado");
            }

            this.CargarGrilla(dgvBarrios, oBarrio.RecuperarTodos());
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string descripcion;
            descripcion = string.Empty;
            if (txtNombre.Text != "")
                descripcion = txtNombre.Text;

            this.CargarGrilla(dgvBarrios, oBarrio.RecuperarFiltrados(descripcion, cmbLocalidad.SelectedValue.ToString()));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAltaBarrio fab = new FormAltaBarrio();
            fab.ShowDialog();
            this.CargarGrilla(dgvBarrios, oBarrio.RecuperarTodos());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificarBarrio fmb = new FormModificarBarrio((int)dgvBarrios.CurrentRow.Cells[0].Value);

            fmb.ShowDialog();
            this.CargarGrilla(dgvBarrios, oBarrio.RecuperarTodos());
        }

        private void dgvBarrios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal ventana = new FormPrincipal();
        }

    }
}
