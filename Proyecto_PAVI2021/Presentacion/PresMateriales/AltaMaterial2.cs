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
    public partial class AltaMaterial2 : Form
        
    {

        MaterialService oMaterial = new MaterialService();
        MarcaService oMarca = new MarcaService();
        public AltaMaterial2()
        {
            InitializeComponent();
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAltaMaterial2_Load(object sender, EventArgs e)
        {
            this.LlenarComboConLista(cboMarca, oMarca.RecuperarTodos(), "Descripcion", "Id_Marca");
        }

        private void LlenarComboConLista(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre, id_marca, precio;
            nombre = id_marca  = precio = string.Empty;

            if (cboMarca.SelectedIndex != -1)
                id_marca = cboMarca.SelectedValue.ToString();

            nombre = txtNombre.Text;
            precio = txtPrecioUnitario.Text;
            if (nombre == "" || id_marca == "" || precio == "")
            {
                MessageBox.Show("Ingrese todos los datos para continuar con el registro", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                oMaterial.RegistrarMaterial(nombre, id_marca, precio);
                MessageBox.Show("Material registrado");
                this.Close();
            }
        }
    }
}
