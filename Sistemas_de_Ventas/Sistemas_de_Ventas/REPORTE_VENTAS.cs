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

//Para el manejo de Archivos
using System.IO;

//Clases necesarias de iTextSharp
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

/*
 *Antes de poder usar las librerias de arriba debes agregar el archivo itextsharp.dll a tu proyecto
 * y hacer una referencia a el en las referencias del proyecto 
 */

namespace Sistemas_de_Ventas
{
    public partial class REPORTE_VENTAS : Form
    {
        public REPORTE_VENTAS()
        {
            InitializeComponent();
        }

        private void btHReporte_Click(object sender, EventArgs e)
        {
            try
            {
                //con este comando limpias el datagrid
                dgCortes.Rows.Clear();
                //despues haces una consulta a la base de datos para jalar los datos de la tabla
                string fecha = dTInicial.Value.Year + "-" + dTInicial.Value.Month + "-" + dTInicial.Value.Day;
                MySqlDataReader result = clConsultasCorte.ObtenerPorFecha(fecha);

                //con este while llenas el datagrid con los datos que jalaste de la base de datos
                while (result.Read())
                {
                    dgCortes.Rows.Add(result.GetValue(0), result.GetValue(1), result.GetValue(2), result.GetValue(3), result.GetValue(4));
                }
            }
            catch { }   
        }

        //este es el boton del pdf, el que tiene el icono de pdf...
        private void btPDF_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreFile = "Ventas(" + dTInicial.Value.Day + "-" + dTInicial.Value.Month + "-" + dTInicial.Value.Year + ")";
                clReportes.PorFecha(nombreFile, dgCortes);
            }catch { }
        }
    }
}
