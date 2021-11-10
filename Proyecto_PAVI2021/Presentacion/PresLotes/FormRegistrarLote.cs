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
    public partial class FormRegistrarLote : Form
    {
        MaterialService oMaterial = new MaterialService();
        LoteService oLote = new LoteService();
        MarcaService oMarca = new MarcaService();
        PersonalService oPersonal = new PersonalService();

        public FormRegistrarLote()
        {
            InitializeComponent();
        }

        private void FormRegistrarLote_Load(object sender, EventArgs e)
        {
            this.LlenarComboConLista(cmbMarca, oMarca.RecuperarTodos(), "Descripcion", "Id_Marca");
            this.LlenarComboConLista(cmbEmpleado, oPersonal.RecuperarTodosConcat(), "NombreCompleto", "Legajo");
        }

        private void cmbMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbArticulo.SelectedIndex = -1;
            this.LlenarComboConLista(cmbArticulo, oMaterial.GetAllByMarcaId((int)cmbMarca.SelectedValue), "Nombre", "Id_Material");
        }

        private void LlenarComboConLista(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.SelectedIndex = -1;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string articulo, legajo, fecha, cantidad;
            fecha = DateTime.Now.ToString();
            articulo = legajo = cantidad = string.Empty;
            if (cmbEmpleado.SelectedIndex != -1)
                legajo = cmbEmpleado.SelectedValue.ToString();
            if (cmbArticulo.SelectedIndex != -1)
                articulo = cmbArticulo.SelectedValue.ToString();
            cantidad = nudCantidad.Value.ToString();
            if (nudCantidad.Value <= 0 || articulo == "" || legajo == "")
            {
                MessageBox.Show("Complete todos los datos para continuar con el registro", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                oLote.RegistrarLote(articulo, cantidad, legajo, fecha);
                MessageBox.Show("Lote registrado");
                this.Close();
            }
        }
    }
}
