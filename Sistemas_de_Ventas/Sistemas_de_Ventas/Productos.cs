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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            InicializaConsulta();
        }

        private string operacion = "";

        private void InicializaConsulta()
        {
            operacion = "";

            tbCodigoInterno.Text = null;
            tbCodigoInterno.Enabled = true;
            tbCodigoExterno.Text = null;
            tbCodigoExterno.Enabled = false;
            tbDescripcion.Text = null;
            tbDescripcion.Enabled = false;
            rbUnidad.Checked = false;
            rbUnidad.Enabled = false;
            rbAgranel.Checked = false;
            rbAgranel.Enabled = false;
            tbPrecio.Text = null;
            tbPrecio.Enabled = false;
            tbIva.Text = null;
            tbIva.Enabled = false;
            tbStock.Text = null;
            tbStock.Enabled = false;

            btAceptar.Enabled = false;
            btAceptar.Visible = false;
            btCancelar.Enabled = false;
            btCancelar.Visible = false;

            btBuscar.Enabled = true;
            btBuscar.Visible = true;
        }

        private void InicializaNuevo()
        {
            operacion = "nuevo";

            tbCodigoInterno.Text = clConsultasProductos.SiguienteRegistro();
            tbCodigoInterno.Enabled = false;
            tbCodigoExterno.Text = null;
            tbCodigoExterno.Enabled = true;
            tbDescripcion.Text = null;
            tbDescripcion.Enabled = true;
            rbUnidad.Checked = true;
            rbUnidad.Enabled = true;
            rbAgranel.Checked = false;
            rbAgranel.Enabled = true;
            tbPrecio.Text = null;
            tbPrecio.Enabled = true;
            tbIva.Text = null;
            tbIva.Enabled = true;
            tbStock.Text = null;
            tbStock.Enabled = true;

            btAceptar.Enabled = true;
            btAceptar.Visible = true;
            btCancelar.Enabled = true;
            btCancelar.Visible = true;

            btBuscar.Enabled = false;
            btBuscar.Visible = false;
        }

        private void InicializaEdicion()
        {
            operacion = "editar";

            tbCodigoInterno.Text = null;
            tbCodigoInterno.Enabled = true;
            tbCodigoExterno.Text = null;
            tbCodigoExterno.Enabled = true;
            tbDescripcion.Text = null;
            tbDescripcion.Enabled = true;
            rbUnidad.Checked = true;
            rbUnidad.Enabled = true;
            rbAgranel.Checked = false;
            rbAgranel.Enabled = true;
            tbPrecio.Text = null;
            tbPrecio.Enabled = true;
            tbIva.Text = null;
            tbIva.Enabled = true;
            tbStock.Text = null;
            tbStock.Enabled = true;

            btBuscar.Enabled = true;
            btBuscar.Visible = true;

            btAceptar.Enabled = true;
            btAceptar.Visible = true;
            btCancelar.Enabled = true;
            btCancelar.Visible = true;
        }

        private void InicializaEliminar()
        {
            operacion = "eliminar";

            tbCodigoInterno.Text = null;
            tbCodigoInterno.Enabled = true;
            tbCodigoExterno.Text = null;
            tbCodigoExterno.Enabled = false;
            tbDescripcion.Text = null;
            tbDescripcion.Enabled = false;
            rbUnidad.Checked = false;
            rbUnidad.Enabled = false;
            rbAgranel.Checked = false;
            rbAgranel.Enabled = false;
            tbPrecio.Text = null;
            tbPrecio.Enabled = false;
            tbIva.Text = null;
            tbIva.Enabled = false;
            tbStock.Text = null;
            tbStock.Enabled = false;

            btAceptar.Enabled = true;
            btAceptar.Visible = true;
            btCancelar.Enabled = true;
            btCancelar.Visible = true;

            btBuscar.Enabled = true;
            btBuscar.Visible = true;
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicializaConsulta();
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicializaNuevo();
        }

        private void presionaBuscar()
        {
            try
            {
                clProducto producto = clConsultasProductos.BuscarPorCodigo(int.Parse(tbCodigoInterno.Text));
                tbCodigoExterno.Text = producto.CodigoExt1;
                tbDescripcion.Text = producto.Descripcion1;
                if (producto.Venta1 == "unidad")
                    rbUnidad.Checked = true;
                else
                    rbAgranel.Checked = true;
                tbPrecio.Text = producto.Precio1.ToString();
                tbIva.Text = producto.IVA1.ToString();
                tbStock.Text = producto.Stock1.ToString();

                if (operacion == "editar")
                {
                    tbCodigoInterno.Enabled = false;
                    tbCodigoExterno.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Debe ingresar el código interno!");
                tbCodigoInterno.Focus();
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            presionaBuscar();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if(operacion == "nuevo")
            {
                clProducto prod = new clProducto();
                prod.Codigo1 = int.Parse(tbCodigoInterno.Text);
                prod.CodigoExt1 = tbCodigoExterno.Text;
                prod.Descripcion1 = tbDescripcion.Text;
                if (rbUnidad.Checked)
                    prod.Venta1 = "unidad";
                else
                    prod.Venta1 = "agranel";
                prod.Precio1 = float.Parse(tbPrecio.Text);
                prod.IVA1 = int.Parse(tbIva.Text);
                prod.Stock1 = float.Parse(tbStock.Text);

                clConsultasProductos.NuevoProducto(prod);
            }
            if(operacion == "editar")
            {
                clProducto prod = new clProducto();
                prod.Codigo1 = int.Parse(tbCodigoInterno.Text);
                prod.CodigoExt1 = tbCodigoInterno.Text;
                prod.Descripcion1 = tbDescripcion.Text;
                if (rbUnidad.Checked)
                    prod.Venta1 = "unidad";
                else
                    prod.Venta1 = "agranel";
                prod.Precio1 = float.Parse(tbPrecio.Text);
                prod.IVA1 = int.Parse(tbIva.Text);
                prod.Stock1 = float.Parse(tbStock.Text);

                clConsultasProductos.EditarProducto(prod);
            }
            if(operacion == "eliminar")
            {
                clProducto prod = new clProducto();
                prod.Codigo1 = int.Parse(tbCodigoInterno.Text);
                prod.CodigoExt1 = tbCodigoInterno.Text;
                prod.Descripcion1 = tbDescripcion.Text;
                if (rbUnidad.Checked)
                    prod.Venta1 = "unidad";
                else
                    prod.Venta1 = "agranel";
                prod.Precio1 = float.Parse(tbPrecio.Text);
                prod.IVA1 = int.Parse(tbIva.Text);
                prod.Stock1 = float.Parse(tbStock.Text);

                clConsultasProductos.EliminarProducto(prod);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicializaEdicion();
            
        }

        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicializaEliminar();
        }

        private void tbCodigoInterno_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbCodigoInterno.Text))
            {
                MessageBox.Show("Debes inresar el Código Interno!");
                tbCodigoInterno.Focus();
            }
        }

        private void tbCodigoInterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                presionaBuscar();
            }
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbCodigoExterno_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbCodigoExterno.Text))
            {
                MessageBox.Show("Debe ingresar el código externo!");
                tbCodigoExterno.Focus();
            }
        }

        private void tbDescripcion_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar la descripción!");
                tbDescripcion.Focus();
            }
        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbPrecio.Text.Contains('.'))
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

        private void tbPrecio_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbPrecio.Text))
            {
                MessageBox.Show("Debe ingresar el precio!");
                tbPrecio.Focus();
            }
        }

        private void tbIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbIva_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbIva.Text))
            {
                MessageBox.Show("Debe ingresar el Iva!");
                tbIva.Focus();
            }
        }

        private void tbStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbStock.Text.Contains('.'))
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

        private void tbStock_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbStock.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad!");
                tbStock.Focus();
            }
        }

        private void aCTUALIZARSTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            STOCK ventStock = new STOCK();
            ventStock.Visible = true;
        }
    }
}
