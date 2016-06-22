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
    public partial class BUSCARPRODUCTO : Form
    {
        public BUSCARPRODUCTO()
        {
            InitializeComponent();
        }

        private void tbDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    string palabra = tbDescripcion.Text;
                    float precio = 0;
                    List<clProducto> productos = clConsultasProductos.BuscarDescripcion(palabra);
                    foreach (clProducto prod in productos)
                    {
                        precio = prod.Precio1 + (prod.Precio1 * prod.IVA1 / 100);
                        string[] renglon = new string[] { prod.CodigoExt1, prod.Descripcion1, precio.ToString(), prod.Stock1.ToString() };
                        dataGridView1.Rows.Add(renglon);
                    }
                }
                catch { }
            }
        }

        private void tbDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
