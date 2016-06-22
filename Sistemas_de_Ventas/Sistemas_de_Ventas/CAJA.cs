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
    public partial class CAJA : Form
    {
        private clCorte corteActual;
        private int ventaNumero;

        private float subtotalV = 0;
        private float ivaV = 0;
        private float totalV = 0;
        private int numProds = 0;

        private clProducto producto;
        private float cantProducto = 0;
        
        public CAJA(clCorte corte)
        {
            InitializeComponent();

            corteActual = corte;
            lbCajero.Text = lbCajero.Text + " " + corte.Cajero;
            lbTurno.Text = lbTurno.Text + " " + corte.Turno;
            ventaNumero = int.Parse(clConsultasVentas.SiguienteVenta());
            lbTicket.Text = lbTicket.Text + " " + ventaNumero;
            tbCodigoArt.Focus();

            lbFecha.Text = lbFecha.Text + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
            lbHora.Text = lbHora.Text + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
        }

        private void CAJA_Activated(object sender, EventArgs e)
        {
            tbCodigoArt.Focus();
        }

        private void tbCodigoArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if(e.KeyChar == '\r')
            {
                //MessageBox.Show("Enter");
                producto = clConsultasProductos.BuscarPorCodigoExterno(tbCodigoArt.Text);
                if (string.IsNullOrWhiteSpace(producto.CodigoExt1))
                {
                    MessageBox.Show("Producto no Encontrado!");
                    tbCodigoArt.Text = null;
                    //tbCodigoArt.Focus;
                }
                else
                {
                    tbCantidad.Focus();
                }
            }    
        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(producto.Venta1 == "unidad")
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
            }
            else
            {
                if (tbCantidad.Text.Contains('.'))
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

            if(e.KeyChar == '\r' && !string.IsNullOrWhiteSpace(tbCantidad.Text))
            {
                cantProducto = float.Parse(tbCantidad.Text);
                subtotalV = subtotalV + producto.Precio1 * cantProducto;
                ivaV = ivaV + (producto.Precio1 * cantProducto * producto.IVA1 / 100);
                totalV = subtotalV + ivaV;
                numProds++;

                float precio = producto.Precio1 + (producto.IVA1*producto.Precio1/100);
                float totalPr = cantProducto * precio;
                string[] renglon = new string[] {producto.CodigoExt1, producto.Descripcion1, precio.ToString(), cantProducto.ToString(), totalPr.ToString()};
                dataGridView1.Rows.Add(renglon);

                lbArticulos.Text = "ARTICULOS: " + numProds;
                lbSubTotal.Text = "SUB TOTAL: $ " + subtotalV;
                lbIva.Text = "IVA: $ " + ivaV;
                lbTotal.Text = "TOTAL: $ " + totalV;

                tbCantidad.Text = null;
                tbCodigoArt.Text = null;
                tbCodigoArt.Focus();
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            BUSCARPRODUCTO buscar = new BUSCARPRODUCTO();
            buscar.Visible = true;
        }

        private void tbCodigoArt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();

            if (e.KeyCode == Keys.F1)
            {
                BUSCARPRODUCTO buscar = new BUSCARPRODUCTO();
                buscar.Visible = true;
            }

            if(e.KeyCode == Keys.F2)
            {
                try
                {
                    string codigo = tbCodigoArt.Text;
                    foreach(DataGridViewRow linea in dataGridView1.Rows)
                    {
                        if (linea.Cells[0].Value.ToString() == codigo)
                        {
                            dataGridView1.Rows.Remove(linea);
                            numProds--;
                            clProducto prod = clConsultasProductos.BuscarPorCodigoExterno(linea.Cells[0].Value.ToString());
                            float subt = prod.Precio1 * float.Parse(linea.Cells[3].Value.ToString());
                            float iva2 = prod.Precio1 * float.Parse(linea.Cells[3].Value.ToString()) * prod.IVA1 / 100;
                            float tot = subt + iva2;

                            subtotalV = subtotalV - subt;
                            ivaV = ivaV - iva2;
                            totalV = totalV - tot;

                            if (numProds == 0)
                            {
                                subtotalV = 0;
                                ivaV = 0;
                                totalV = 0;
                            }

                            lbArticulos.Text = "ARTICULOS: " + numProds;
                            lbSubTotal.Text = "SUB TOTAL: $ " + subtotalV;
                            lbIva.Text = "IVA: $ " + ivaV;
                            lbTotal.Text = "TOTAL: $ " + totalV;

                            tbCodigoArt.Text = null;
                            tbCantidad.Text = null;
                        }
                    }
                }
                catch { }
            }

            if (e.KeyCode == Keys.F3)
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    subtotalV = 0;
                    ivaV = 0;
                    totalV = 0;
                    numProds = 0;
                    cantProducto = 0;

                    lbArticulos.Text = "ARTICULOS: " + numProds;
                    lbSubTotal.Text = "SUB TOTAL: $ " + subtotalV;
                    lbIva.Text = "IVA: $ " + ivaV;
                    lbTotal.Text = "TOTAL: $ " + totalV;
                }
                catch { }
            }

            if (e.KeyCode == Keys.F4)
            {
                try
                {
                    COBRAR cobrar = new COBRAR(totalV);
                    cobrar.Visible = true;
                    
                    registrarVenta();
                    InicializaVenta();
                }
                catch { }
            }
        }

        private void btCancelarArt_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = tbCodigoArt.Text;
                foreach (DataGridViewRow linea in dataGridView1.Rows)
                {
                    if (linea.Cells[0].Value.ToString() == codigo)
                    {
                        dataGridView1.Rows.Remove(linea);
                        numProds--;
                        clProducto prod = clConsultasProductos.BuscarPorCodigoExterno(linea.Cells[0].Value.ToString());
                        float subt = (prod.Precio1 + prod.Precio1 * prod.IVA1 / 100) * float.Parse(linea.Cells[3].Value.ToString());
                        float iva2 = prod.Precio1 * float.Parse(linea.Cells[3].Value.ToString()) * prod.IVA1 / 100;
                        float tot = subt + iva2;

                        subtotalV = subtotalV - subt;
                        ivaV = ivaV - iva2;
                        totalV = totalV - tot;

                        if(numProds == 0)
                        {
                            subtotalV = 0;
                            ivaV = 0;
                            totalV = 0;
                        }

                        lbArticulos.Text = "ARTICULOS: " + numProds;
                        lbSubTotal.Text = "SUB TOTAL: $ " + subtotalV;
                        lbIva.Text = "IVA: $ " + ivaV;
                        lbTotal.Text = "TOTAL: $ " + totalV;

                        tbCodigoArt.Text = null;
                        tbCantidad.Text = null;
                    }
                }
            }
            catch { }
        }

        private void btCancelarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                subtotalV = 0;
                ivaV = 0;
                totalV = 0;
                numProds = 0;
                cantProducto = 0;

                lbArticulos.Text = "ARTICULOS: " + numProds;
                lbSubTotal.Text = "SUB TOTAL: $ " + subtotalV;
                lbIva.Text = "IVA: $ " + ivaV;
                lbTotal.Text = "TOTAL: $ " + totalV;
            }
            catch { }
        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                COBRAR cobrar = new COBRAR(totalV);
                cobrar.Visible = true;
                registrarVenta();
                InicializaVenta();
            }
            catch { }
        }

        private void registrarVenta()
        {
            clVenta vent = new clVenta();
            vent.IdVenta = ventaNumero;
            vent.Hora = DateTime.Now;
            vent.SubTotal = subtotalV;
            vent.Iva = ivaV;
            vent.Total = totalV;
            vent.Corte = corteActual.IdCorte;
            clConsultasVentas.RegistrarVenta(vent);

            clConsultasVentas.ActualizarCorte(corteActual.IdCorte, totalV);

            foreach (DataGridViewRow linea in dataGridView1.Rows)
            {
                string codigo = linea.Cells[0].Value.ToString();
                string descrp = linea.Cells[1].Value.ToString();
                float cantid = float.Parse(linea.Cells[3].Value.ToString());
                float total = float.Parse(linea.Cells[4].Value.ToString());

                clConsultasVentas.RegistrarDetalle(codigo, descrp, cantid, 0, 0, total);
            }

            clConsultasVentas.Registra_Venta_Detalle(vent.IdVenta);
        }

        private void InicializaVenta()
        {
            tbCodigoArt.Text = null;
            tbCantidad.Text = null;
            dataGridView1.Rows.Clear();

            subtotalV = 0;
            ivaV = 0;
            totalV = 0;
            numProds = 0;

            lbArticulos.Text = "ARTICULOS: ";
            lbSubTotal.Text = "SUB TOTAL: ";
            lbIva.Text = "IVA: ";
            lbTotal.Text = "TOTAL: ";
        }
    }
}
