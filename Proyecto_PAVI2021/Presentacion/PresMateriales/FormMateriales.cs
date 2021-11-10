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

namespace Proyecto_PAVI2021.Presentacion.PresMateriales
{
    public partial class FormMateriales : Form
        
    {
        
        MaterialService oMaterial = new MaterialService();
        MarcaService oMarca = new MarcaService();
        
        public FormMateriales()
        {
            InitializeComponent();
        }


        private void FormLotesInfoStock_Load(object sender, EventArgs e)
        {
            this.LlenarComboConLista(cmbMarca, oMarca.RecuperarTodos(), "Descripcion", "Id_Marca");
        }

        private void LlenarComboConLista(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id_marca, nombre;
            id_marca = nombre = string.Empty;

            if (cmbMarca.SelectedIndex != -1)
                id_marca = cmbMarca.SelectedValue.ToString();
            if (txtNombre.Text != "")
                nombre = txtNombre.Text;


            this.CargarGrilla(dgvMateriales, oMaterial.ObtenerFiltrados(nombre, id_marca));
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["Id_Material"],
                    tabla.Rows[i]["Nombre"],
                    tabla.Rows[i]["Stock"],
                    tabla.Rows[i]["Descripcion"],
                    tabla.Rows[i]["Precio"]
                    );
            }
        }
    }
}
