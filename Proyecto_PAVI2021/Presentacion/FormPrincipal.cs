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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.ShowDialog();
            if (fl.MiUsuario.Id_usuario == 0)
                this.Close();
            else
                this.Text += " - Usuario: " + fl.MiUsuario.Nombre;
            fl.Dispose();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void composicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios fus = new FormUsuarios();
            fus.ShowDialog();
        }
    }
}
