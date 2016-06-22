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
    public partial class STOCK : Form
    {
        public STOCK()
        {
            InitializeComponent();
            
        }

        private void dgProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    string codigo = Convert.ToString(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells[0].Value);
                    clProducto producto = clConsultasProductos.BuscarPorCodigo(int.Parse(codigo));
                    dgProductos.Rows[e.RowIndex].Cells["codigoInt"].Value = producto.Codigo1;
                    dgProductos.Rows[e.RowIndex].Cells["codigoExt"].Value = producto.CodigoExt1;
                    dgProductos.Rows[e.RowIndex].Cells["descripcion"].Value = producto.Descripcion1;
                    
                }
                if (e.ColumnIndex == 1)
                {
                    string codigo = Convert.ToString(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells[1].Value);
                    clProducto producto = clConsultasProductos.BuscarPorCodigoExterno(codigo);
                    dgProductos.Rows[e.RowIndex].Cells["codigoInt"].Value = producto.Codigo1;
                    dgProductos.Rows[e.RowIndex].Cells["codigoExt"].Value = producto.CodigoExt1;
                    dgProductos.Rows[e.RowIndex].Cells["descripcion"].Value = producto.Descripcion1;
                    
                }
            }
            catch
            {
                //MessageBox.Show("Codigo Incorrecto");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo;
                string cantidad;
                int productos = dgProductos.RowCount;
                for (int c = 0; c < productos - 1; c++)
                {
                    DataGridViewRow fila = dgProductos.Rows[c];
                    codigo = fila.Cells[0].Value.ToString();
                    cantidad = fila.Cells[3].Value.ToString();
                    //MessageBox.Show(codigo +" " + cantidad);
                    clConsultasProductos.ActualizaStock(codigo, cantidad);
                }
                MessageBox.Show("Actualizacion Exitosa!");
                DataTable dt = new DataTable();
                dt.Rows.Add(dt.NewRow());
                dgProductos.DataSource = dt;
            }
            catch
            {

            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
