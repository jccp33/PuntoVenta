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
    public partial class PRINCIPAL : Form
    {
        private clUsuario usuario;

        public PRINCIPAL(clUsuario user)
        {
            InitializeComponent();
            usuario = user;
            if(usuario.Tipo == "cajero")
            {
                msOpciones.Items[0].Enabled = false;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admUsuarios_Click(object sender, EventArgs e)
        {
            USUARIOS usuarios = new USUARIOS();
            usuarios.Visible = true;
        }

        private void admProductos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Visible = true;
        }

        private void Caja_Click(object sender, EventArgs e)
        {
            ABRIRTURNO caja = new ABRIRTURNO(usuario);
            caja.Visible = true;
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REPORTE_VENTAS reporte = new REPORTE_VENTAS();
            reporte.Visible = true;
        }

        private void porTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REPORTEPORTURNO reporte = new REPORTEPORTURNO();
            reporte.Visible = true;
        }

        private void porCajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REPORTE_CAJERO reporte = new REPORTE_CAJERO();
            reporte.Visible = true;
        }
    }
}
