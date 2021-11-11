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

namespace Proyecto_PAVI2021.Presentacion.PresLotes
{
    public partial class FormLotes : Form
    {
        MaterialService oMaterial = new MaterialService();
        MarcaService oMarca = new MarcaService();
        PersonalService oPersonal = new PersonalService();
        LoteService oLote = new LoteService();
        private List<string> listaConfirmacion = new List<string> { "Sin Confirmar", "Confirmado" };
        
        public FormLotes()
        {
            InitializeComponent();
        }

        private void FormLotes_Load(object sender, EventArgs e)
        {
            this.LlenarComboConLista(cmbMarca, oMarca.RecuperarTodos(), "Descripcion", "Id_Marca");
            this.LlenarComboConLista(cmbEmpleado, oPersonal.RecuperarTodosConcat(), "NombreCompleto", "Legajo");
            this.dtpDesde.Value = DateTime.Today.AddYears(-1);
            this.dtpHasta.Value = DateTime.Today.AddDays(1);
            this.cmbConfirmado.DataSource = listaConfirmacion;
            this.cmbConfirmado.SelectedIndex = -1;
            this.btnConfirmar.Enabled = false;
            
            this.CargarGrilla(dgvLotes, oLote.ObtenerTodos());
        }

        private void LlenarComboConLista(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.SelectedIndex = -1;
        }

        private void cmbMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbArticulo.SelectedIndex = -1;
            this.LlenarComboConLista(cmbArticulo, oMaterial.GetAllByMarcaId((int)cmbMarca.SelectedValue), "Nombre", "Id_Material");
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                string confirmacion;
                if (tabla.Rows[i]["Confirmacion_Lote"].ToString() == "True")
                {
                    confirmacion = "Confirmado";
                }
                else
                {
                    confirmacion = "Sin Confirmar";
                }

                if(confirmacion == "Sin Confirmar")
                {
                    grilla.Rows.Add(tabla.Rows[i]["Id_Lote"],
                                tabla.Rows[i]["NombreCompleto"],
                                tabla.Rows[i]["Nombre"],
                                tabla.Rows[i]["Descripcion"],
                                tabla.Rows[i]["Cantidad_Fabricada"],
                                Convert.ToDateTime(tabla.Rows[i]["Fecha_Lote"]).ToShortDateString(),
                                confirmacion);
                }
                else
                {
                    grilla.Rows.Add(tabla.Rows[i]["Id_Lote"],
                                tabla.Rows[i]["NombreCompleto"],
                                tabla.Rows[i]["Nombre"],
                                tabla.Rows[i]["Descripcion"],
                                tabla.Rows[i]["Stock_Lote"],
                                Convert.ToDateTime(tabla.Rows[i]["Fecha_Lote"]).ToShortDateString(),
                                confirmacion);

                }
                
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string desde, hasta, legajo, articulo, confirmacion;
            legajo = articulo = confirmacion = string.Empty;

            desde = dtpDesde.Value.ToString("dd/MM/yyyy");
            hasta = dtpHasta.Value.ToString("dd/MM/yyyy");

            if (cmbEmpleado.SelectedIndex != -1)
                legajo = cmbEmpleado.SelectedValue.ToString();
            if (cmbArticulo.SelectedIndex != -1)
                articulo = cmbArticulo.SelectedValue.ToString();
            if (cmbConfirmado.SelectedIndex != -1)
                confirmacion = cmbConfirmado.SelectedIndex.ToString();

            this.CargarGrilla(dgvLotes, oLote.ObtenerFiltrados(articulo, legajo, confirmacion, desde, hasta));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormRegistrarLote frl = new FormRegistrarLote();
            frl.ShowDialog();

            this.CargarGrilla(dgvLotes, oLote.ObtenerTodos());
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLotes.CurrentRow.Cells[colConfirmacion.Index].Value.ToString() == "Sin Confirmar")
            {
                this.btnConfirmar.Enabled = true;
            }
            else
            {
                this.btnConfirmar.Enabled = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string id, cantidad;
            id = dgvLotes.CurrentRow.Cells[colId.Index].Value.ToString();
            cantidad = dgvLotes.CurrentRow.Cells[colCantidad.Index].Value.ToString();
            oLote.confirmarLote(id, cantidad);

            MessageBox.Show("Lote confirmado");
            this.CargarGrilla(dgvLotes, oLote.ObtenerTodos());
        }
    }
}
