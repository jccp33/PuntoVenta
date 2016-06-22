using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using ClasesSistemaVentas;

namespace Sistemas_de_Ventas
{
    public partial class USUARIOS : Form
    {
        private string operacion = "";

        public USUARIOS()
        {
            InitializeComponent();

            cbTipo.Enabled = false;
            cbTipo.Visible = false;
            tbNombre.Enabled = false;
            tbTipoUsuario.Enabled = false;
            label4.Visible = false;
            tbPassword.Enabled = false;
            tbPassword.Visible = false;
            btAceptar.Visible = false;
            btAceptar.Enabled = false;
            btCancelar.Visible = false;
            btCancelar.Enabled = false;
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            operacion = "";
            tbClave.Enabled = true;
            cbTipo.Enabled = false;
            cbTipo.Visible = false;
            btBuscar.Enabled = true;
            btBuscar.Visible = true;
            tbNombre.Enabled = false;
            tbTipoUsuario.Enabled = false;
            label4.Visible = false;
            tbPassword.Enabled = false;
            tbPassword.Visible = false;
            tbTipoUsuario.Enabled = false;
            tbTipoUsuario.Visible = true;
            btAceptar.Visible = false;
            btAceptar.Enabled = false;
            btCancelar.Visible = false;
            btCancelar.Enabled = false;

            tbClave.Text = null;
            tbNombre.Text = null;
            tbPassword.Text = null;
            tbTipoUsuario.Text = null;
        }

        private void presionaBuscar()
        {
            try
            {
                string clave = tbClave.Text;
                clUsuario usuario = clConsultasUsuarios.ObtenerUsuarioPorClave(clave);

                tbClave.Text = usuario.Clave + "";
                tbClave.Enabled = true;
                tbNombre.Text = usuario.Nombre;
                tbTipoUsuario.Text = usuario.Tipo;
                tbPassword.Text = usuario.Password;
                cbTipo.Text = usuario.Tipo;
            }
            catch
            {
                MessageBox.Show("Error en la conexion!");
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            presionaBuscar();
        }

        private void tbClave_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbClave.Text))
            {
                MessageBox.Show("Debe ingresar la clave!");
                tbClave.Focus();
            }
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            operacion = "nuevo";
            cbTipo.Enabled = true;
            cbTipo.Visible = true;
            cbTipo.SelectedItem = null;
            btBuscar.Enabled = false;
            btBuscar.Visible = false;
            btAceptar.Enabled = true;
            btAceptar.Visible = true;
            btCancelar.Enabled = true;
            btCancelar.Visible = true;
            label4.Visible = true;
            tbPassword.Enabled = true;
            tbPassword.Visible = true;
            tbNombre.Enabled = true;
            tbTipoUsuario.Enabled = false;
            tbTipoUsuario.Visible = false;
            tbClave.Text = null;
            tbNombre.Text = null;
            tbPassword.Text = null;
            tbTipoUsuario.Text = null;
            tbClave.Enabled = false;

            tbClave.Text = (int.Parse(clConsultasUsuarios.SiguienteRegistro()) + 1).ToString();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if(operacion == "nuevo")
            {
                //codigo para insertar un nuevo registro
                clUsuario usuario = new clUsuario();
                usuario.Clave = int.Parse(tbClave.Text);
                usuario.Tipo = cbTipo.SelectedItem.ToString();
                usuario.Nombre = tbNombre.Text;
                usuario.Password = tbPassword.Text;
                clConsultasUsuarios.InsertarRegistro(usuario);
            }
            if(operacion == "editar")
            {
                clUsuario usuario = new clUsuario();
                usuario.Clave = int.Parse(tbClave.Text);
                usuario.Tipo = cbTipo.SelectedItem.ToString();
                usuario.Nombre = tbNombre.Text;
                usuario.Password = tbPassword.Text;

                clConsultasUsuarios.ActualizarRegistro(usuario);
            }
            if(operacion == "eliminar")
            {
                string clave = tbClave.Text;
                clConsultasUsuarios.EliminarRegistro(clave);
            }
        }

        private void tbNombre_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre!");
                tbNombre.Focus();
            }
        }

        private void tbPassword_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña!");
                tbPassword.Focus();
            }
            string exp = @"[a-zA-Z0-9]{8,20}";
            Regex automata = new Regex(exp);
            if (!automata.IsMatch(tbPassword.Text))
            {
                MessageBox.Show("Contraseña Incorrecta");
                tbPassword.Text = null;
                tbPassword.Focus();
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            operacion = "editar";
            label4.Visible = true;
            tbClave.Text = null;
            tbClave.Enabled = true;
            tbClave.Visible = true;
            //tbTipoUsuario.Text = null;
            tbTipoUsuario.Enabled = false;
            tbTipoUsuario.Visible = false;
            tbNombre.Text = null;
            tbNombre.Enabled = true;
            tbNombre.Visible = true;
            tbPassword.Text = null;
            tbPassword.Enabled = true;
            tbPassword.Visible = true;
            btBuscar.Enabled = true;
            btBuscar.Visible = true;
            cbTipo.Enabled = true;
            cbTipo.Visible = true;
            btAceptar.Enabled = true;
            btAceptar.Visible = true;
            btCancelar.Enabled = true;
            btCancelar.Visible = true;
            tbClave.Focus();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            operacion = "eliminar";
            tbClave.Text = null;
            tbNombre.Text = null;
            tbPassword.Text = null;
            tbTipoUsuario.Text = null;

            tbClave.Enabled = true;
            cbTipo.Enabled = false;
            cbTipo.Visible = false;
            btBuscar.Enabled = true;
            btBuscar.Visible = true;
            tbNombre.Enabled = false;
            tbTipoUsuario.Enabled = false;
            label4.Visible = false;
            tbPassword.Enabled = false;
            tbPassword.Visible = false;
            tbTipoUsuario.Enabled = false;
            tbTipoUsuario.Visible = true;
            btAceptar.Visible = true;
            btAceptar.Enabled = true;
            btCancelar.Visible = true;
            btCancelar.Enabled = true;
            tbClave.Focus();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void USUARIOS_Load(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                presionaBuscar();
            }

        }
    }
}
