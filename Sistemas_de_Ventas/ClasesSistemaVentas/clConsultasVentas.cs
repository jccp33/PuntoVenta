using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ClasesSistemaVentas
{
    public class clConsultasVentas
    {
        public static string SiguienteVenta()
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "SELECT MAX(idVentas) FROM Ventas";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                return (int.Parse(lector.GetValue(0).ToString()) + 1).ToString();
            }
            catch
            {
                MessageBox.Show("Error en la conexion!");
                return null;
            }
        }

        public static void ActualizaVenta(int idVenta, float subtotal, float iva, float total)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "UPDATE `puntoventa`.`ventas` SET `Subtotal`='"+subtotal+"', `Iva`='"+iva+"', `Total`='"+total+"' WHERE `idVentas`='"+idVenta+"';";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch
            {
            }
        }

        public static void RegistrarVenta(clVenta venta)
        {
            try
            {
                clConexion conexion = new clConexion();
                string fecha = "'" + venta.Hora.Year + "-" + venta.Hora.Month + "-" + venta.Hora.Day + " " + venta.Hora.Hour + ":" + venta.Hora.Minute + ":" + venta.Hora.Second + "'";
                string consulta = "insert into puntoventa.ventas(Hora, SubTotal, Iva, Total, Corte) values(" + fecha + "," + venta.SubTotal + "," + venta.Iva + "," + venta.Total + "," + venta.Corte + ");";
                MySqlCommand ejecutar = new MySqlCommand(consulta, conexion.ObtenerConexion());
                ejecutar.ExecuteNonQuery();
            }catch { }
        }

        public static void ActualizarCorte(int idCorte, float total)
        {
            try
            {
                clCorte corte = clConsultasCorte.ObtenerCorte(idCorte);
                corte.Total = corte.Total + total;

                clConexion conexion = new clConexion();
                string consulta = "update puntoventa.corte set Total = " + corte.Total +" where idCorte = " + idCorte + ";";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch { }
        }

        public static void RegistrarDetalle(string codigoP, string descrP, float cant, float subT, float iva, float Tot)
        {
            string consulta = "insert into puntoventa.detalleventa (CodigoProducto,Descripcion,Cantidad,SubTotal,Iva,Total)" +
                "values('" + codigoP +"', '" + descrP + "'," + cant + "," + subT + "," + iva + "," + Tot + ");";
            clConexion conexion1 = new clConexion();
            MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion1.ObtenerConexion());
            enviarSQL.ExecuteNonQuery();

            //update puntoventa.productos set Stock = 10 where Codigo = 1
            clProducto prod = clConsultasProductos.BuscarPorCodigoExterno(codigoP);
            prod.Stock1 = prod.Stock1 - cant;
            string consulta2 = "update puntoventa.productos set Stock = " + prod.Stock1 + " where Codigo = " + prod.Codigo1;

            clConexion conexion2 = new clConexion();
            MySqlCommand enviarSQL2 = new MySqlCommand(consulta2, conexion2.ObtenerConexion());
            enviarSQL2.ExecuteNonQuery();
        }

        public static void Registra_Venta_Detalle(int venta)
        {
            clConexion conexion = new clConexion();
            string consulta = "select max(idDetalleVenta) from puntoventa.detalleventa;";
            MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
            enviarSQL.ExecuteNonQuery();
            MySqlDataReader lector = enviarSQL.ExecuteReader();
            lector.Read();
            int detalle = int.Parse(lector.GetValue(0).ToString());
            conexion.CerrarConexion();

            clConexion conexion2 = new clConexion();
            string consulta2 = "insert into puntoventa.ventadetalle (Venta,Detalle) values (" + venta + "," + detalle + ");";
            MySqlCommand enviarSQL2 = new MySqlCommand(consulta2, conexion2.ObtenerConexion());
            enviarSQL2.ExecuteNonQuery();
            conexion2.CerrarConexion();
        }

    }
}
