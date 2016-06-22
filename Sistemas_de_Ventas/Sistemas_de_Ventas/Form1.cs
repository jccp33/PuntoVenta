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
    public partial class INGRESO_SISTEMA : Form
    {

        public INGRESO_SISTEMA()
        {
            InitializeComponent();
            try
            {
                MySqlDataReader nombres = clConsultasUsuarios.ObtenerNombresUsuarios();
                int c = 0;
                while (nombres.Read())
                {
                    cbUsuarios.Items.Add(nombres.GetValue(0).ToString());
                    c++;
                }
                cbUsuarios.Focus();
            }
            catch
            {
                MessageBox.Show("No se encontraron usuarios!");
            }
        }

        private byte intentos = 0;

        private void presionaAceptar()
        {
            intentos++;
            if (intentos > 3)
            {
                MessageBox.Show("Has superado los intentos de ingreso.");
                Close();
            }
            try
            {
                string nombre = cbUsuarios.SelectedItem.ToString();
                clUsuario usuario = new clUsuario(clConsultasUsuarios.ObtenerDatosUsuario(nombre));

                if (tbPassword.Text == usuario.Password)
                {
                    PRINCIPAL princip = new PRINCIPAL(usuario);
                    princip.Visible = true;
                    tbPassword.Text = null;
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos!");
                }

            }
            catch { }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            presionaAceptar();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbUsuarios_Validated(object sender, EventArgs e)
        {
            if(cbUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un nombre de usuario!");
                cbUsuarios.Focus();
            }
        }

        private void tbPassword_Validated(object sender, EventArgs e)
        {
            
        }

        private void btActualizarLista_Click(object sender, EventArgs e)
        {
            cbUsuarios.Items.Clear();
            try
            {
                MySqlDataReader nombres = clConsultasUsuarios.ObtenerNombresUsuarios();
                int c = 0;
                while (nombres.Read())
                {
                    cbUsuarios.Items.Add(nombres.GetValue(0).ToString());
                    c++;
                }
                cbUsuarios.Focus();
            }
            catch
            {
                MessageBox.Show("No se encontraron usuarios!");
            }
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

            if (e.KeyChar == 13)
            {
                //MessageBox.Show("Enter presionado");
                presionaAceptar();
            }
        }
    }
}
