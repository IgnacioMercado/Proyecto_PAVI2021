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


        public FormLotes()
        {
            InitializeComponent();
        }

        private void FormLotes_Load(object sender, EventArgs e)
        {
            this.LlenarComboConLista(cmbMarca, oMarca.RecuperarTodos(), "Descripcion", "Id_Marca");
            this.LlenarComboConLista(cmbEmpleado, oPersonal.RecuperarTodosConcat(), "NombreCompleto", "Legajo");
            this.dtpDesde.Value = DateTime.Today.AddYears(-1);
            this.dtpHasta.Value = DateTime.Today;
            cmbConfirmado.SelectedIndex = 0;


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
                grilla.Rows.Add(tabla.Rows[i]["Id_Lote"],
                    tabla.Rows[i]["NombreCompleto"],
                    tabla.Rows[i]["Nombre"],
                    tabla.Rows[i]["Descripcion"],
                    tabla.Rows[i]["Stock_Lote"],
                    Convert.ToDateTime(tabla.Rows[i]["Fecha_Lote"]).ToShortDateString()
                    ); 
            }
        }

        private void CargarGrillaNC(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["Id_Lote"],
                    tabla.Rows[i]["NombreCompleto"],
                    tabla.Rows[i]["Nombre"],
                    tabla.Rows[i]["Descripcion"],
                    tabla.Rows[i]["Cantidad_Fabricada"],
                    Convert.ToDateTime(tabla.Rows[i]["Fecha_Lote"]).ToShortDateString()
                    );
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
            if (cmbConfirmado.Text == "Confirmado")
            {
                confirmacion = "1";
            }
            else
            {
                confirmacion = "0";
            }

            if(confirmacion == "1")
            {
                this.CargarGrilla(dgvLotes, oLote.ObtenerFiltrados(articulo, legajo, confirmacion, desde, hasta));
            }
            else
            {
                this.CargarGrillaNC(dgvLotes, oLote.ObtenerFiltrados(articulo, legajo, confirmacion, desde, hasta));
            }
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormRegistrarLote frl = new FormRegistrarLote();
            frl.ShowDialog();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
