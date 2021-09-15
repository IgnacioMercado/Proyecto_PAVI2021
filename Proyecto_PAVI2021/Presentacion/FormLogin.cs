using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PAVI2021.Negocio;
using Proyecto_PAVI2021.Presentacion;

namespace Proyecto_PAVI2021.Presentacion
{
    public partial class FormLogin : Form
    {
        //private string user = "admin";
        //private string pass = "1234";

        private Usuario miUsuario = new Usuario();
        internal Usuario MiUsuario { get => miUsuario; set => miUsuario = value; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //this.Text = "Logeo!!!";
            //this.BackColor = Color.Green;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUsuario.Text)) 
            {
                MessageBox.Show("Debe ingresar un Usuario...");
                this.txtUsuario.Focus();
                return;
            }

            if (this.txtClave.Text==string.Empty)
            {
                MessageBox.Show("Debe ingresar una Contraseña...");
                this.txtClave.Focus();
                return;
            }

            this.miUsuario.Nombre = this.txtUsuario.Text;
            this.miUsuario.Contraseña = this.txtClave.Text;

            this.miUsuario.Id_usuario = this.miUsuario.validarUsuario(miUsuario.Nombre, miUsuario.Contraseña);

            //if (this.txtUsuario.Text==this.user && this.txtClave.Text==this.pass)
            if (miUsuario.Id_usuario!=0)
            {
                MessageBox.Show("Login OK", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
            }
        }
    }
}
