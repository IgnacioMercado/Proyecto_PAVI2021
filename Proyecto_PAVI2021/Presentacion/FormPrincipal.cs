using Proyecto_PAVI2021.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PAVI2021
{
    public partial class Form1 : Form
    {
        public Form1(string nombre)
        {
            InitializeComponent();
            this.Text =("Usuario: "+nombre);
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

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes fcs = new FormClientes();
            fcs.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
