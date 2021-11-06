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

namespace Proyecto_PAVI2021.Presentacion
{
    public partial class FormModificarUsuario : Form
    {
        private int id_usuario;
        PerfilService oPerfil = new PerfilService();
        UsuarioService oUsuario = new UsuarioService();
        public FormModificarUsuario()
        {
            InitializeComponent();
        }

        public FormModificarUsuario(int id_usuario)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
        }

        private void FormModificarUsuario_Load(object sender, EventArgs e)
        {
            CargarCombo(cmbPerfil, oPerfil.RecuperarTodos());
            LlenarCampos();
        }

        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void LlenarCampos()
        {
            DataTable tabla = new DataTable();
            
            tabla = oUsuario.RecuperarPorIdUsuario(id_usuario);
            txtUsuario.Text = tabla.Rows[0]["Nombre_Usuario"].ToString();
            txtContraseña.Text = tabla.Rows[0]["Contraseña_Usuario"].ToString();
            cmbPerfil.SelectedIndex = ((int) tabla.Rows[0]["Id_Perfil"] - 1);
        }

        private void bntGuardarCambios_Click(object sender, EventArgs e)
        {
            string nombre, contraseña, rol;
            nombre = txtUsuario.Text.ToString();
            contraseña = txtContraseña.Text.ToString();
            rol = cmbPerfil.SelectedValue.ToString();
            if (nombre == "" || contraseña == "" || rol == "")
            {
                MessageBox.Show("Por favor, complete todos los campos antes de intentar modificar el usuario");
            }
            else
            {
                oUsuario.ModificarUsuarioPorId(id_usuario, nombre, contraseña, rol);
                MessageBox.Show("Usuario modificado");
                this.Close();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
