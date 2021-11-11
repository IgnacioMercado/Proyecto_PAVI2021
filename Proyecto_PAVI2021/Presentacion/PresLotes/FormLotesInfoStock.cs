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

namespace Proyecto_PAVI2021.Presentacion.PresLotes
{
    public partial class FormLotesInfoStock : Form
        
    {
        private int id_material;
        MaterialService oMaterial = new MaterialService();
        LoteService oLote = new LoteService();
        public FormLotesInfoStock()
        {
            InitializeComponent();
        }

        public FormLotesInfoStock(int id_material)
        {
            InitializeComponent();
            this.id_material = id_material;
        }

        private void FormLotesInfoStock_Load(object sender, EventArgs e)
        {
            LlenarCampos();
            IList<Lote> listaLotes =  oLote.GetConfirmedFilteredByMaterial(id_material);
            BindingList<Lote> blistaLotes = new BindingList<Lote>(listaLotes);
            dgvInfoStock.AutoGenerateColumns = false;
            dgvInfoStock.DataSource = blistaLotes;
        }

        private void LlenarCampos()
        {
            DataTable tabla = oMaterial.RecuperarMaterialYMarcaPorId(id_material);
            this.txtMarca.Text = tabla.Rows[0]["Descripcion"].ToString();
            this.txtMaterial.Text = tabla.Rows[0]["Nombre"].ToString();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
