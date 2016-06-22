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
    public partial class REPORTE_CAJERO : Form
    {
        public REPORTE_CAJERO()
        {
            InitializeComponent();
            try
            {
                MySqlDataReader nombres = clConsultasUsuarios.ObtenerNombresUsuarios();
                int c = 0;
                while (nombres.Read())
                {
                    cbCajeros.Items.Add(nombres.GetValue(0).ToString());
                    c++;
                }
                cbCajeros.Focus();
            }
            catch { }
        }

        private void btHReporte_Click(object sender, EventArgs e)
        {
            try
            {
                //con este comando limpias el datagrid
                dgCortes.Rows.Clear();
                //despues haces una consulta a la base de datos para jalar los datos de la tabla
                string nombre = cbCajeros.SelectedItem.ToString();
                MySqlDataReader result = clConsultasCorte.ObtenerPorCajero(nombre);

                //con este while llenas el datagrid con los datos que jalaste de la base de datos
                while (result.Read())
                {
                    dgCortes.Rows.Add(result.GetValue(0), result.GetValue(1), result.GetValue(2), result.GetValue(3), result.GetValue(4));
                }
            }catch { }
        }

        private void btPDF_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreFile = "ReportePorCajero(" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + " " + cbCajeros.SelectedItem.ToString() + ")";
                clReportes.PorCajero(nombreFile, dgCortes);
            }
            catch { }
        }
    }
}
