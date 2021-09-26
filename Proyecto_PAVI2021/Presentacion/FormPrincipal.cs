﻿using Proyecto_PAVI2021.Presentacion;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin fl;
            fl = new frmLogin();
            fl.ShowDialog();

            if (fl.MiUsuario.Id_usuario == 0)
                this.Close();
            else
                this.Text += " - Usuario: " + fl.MiUsuario.Nombre;

            fl.Dispose();
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
