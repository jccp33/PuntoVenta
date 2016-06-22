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
    public partial class FINCORTE : Form
    {
        public FINCORTE(clCorte corte, float fondo)
        {
            InitializeComponent();
            corte = clConsultasCorte.ObtenerCorte(corte.IdCorte);
            lbFondo.Text = lbFondo.Text + " $ " + fondo;
            lbVentas.Text = lbVentas.Text + " $ " + corte.Total;
            lbTotal.Text = lbTotal.Text + " $ " + (fondo + corte.Total);
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
