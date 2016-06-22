using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using ClasesSistemaVentas;

namespace Sistemas_de_Ventas
{
    public partial class ABRIRTURNO : Form
    {
        private clUsuario usuario;
        private float fondo;
        private clCorte corte;

        public ABRIRTURNO(clUsuario user)
        {
            InitializeComponent();
            usuario = user;
            textBox1.Text = user.Nombre;
            cbTurnos.SelectedIndex = 0;
            tbFondo.Text = "0.0";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btAbrirTurno_Click(object sender, EventArgs e)
        {
            try
            {
                corte = new clCorte();
                corte.IdCorte = int.Parse(clConsultasCorte.SiguienteCorte());
                corte.Fecha = DateTime.Today;
                corte.Cajero = usuario.Nombre;
                corte.Turno = cbTurnos.SelectedItem.ToString();
                corte.Total = 0;
                fondo = float.Parse(tbFondo.Text);
                //MessageBox.Show(corte.IdCorte+"  "+corte.Fecha+"  "+corte.Cajero+"  "+corte.Turno+"  "+corte.Total);
                clConsultasCorte.NuevoCorte(corte);
                btAbrirTurno.Enabled = false;
                btCerrarTurno.Enabled = true;
                btEntrarCaja.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error al Generar Corte!!!");
            }
        }

        private void btCerrarTurno_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Fondo: $ " + fondo);
            FINCORTE fin = new FINCORTE(corte,fondo);
            fin.Visible = true;
            this.Close();
        }

        private void btEntrarCaja_Click(object sender, EventArgs e)
        {
            CAJA caja1 = new CAJA(corte);
            caja1.Visible = true;
        }

        private void tbFondo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbFondo.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
                if (e.KeyChar == '\b')
                    e.Handled = false;
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
                if (e.KeyChar == '.' || e.KeyChar == '\b')
                    e.Handled = false;
            }
        }
    }
}
