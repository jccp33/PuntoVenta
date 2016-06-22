using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ClasesSistemaVentas
{
    public class clConsultasCorte
    {
        public static string SiguienteCorte()
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "SELECT MAX(idCorte) FROM puntoVenta.Corte";
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

        public static void NuevoCorte(clCorte corte)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "insert into corte(idCorte,Fecha,Cajero,Turno,Total) " +
                                  "values(" + corte.IdCorte + ",'" + corte.Fecha.Year + "/" + corte.Fecha.Month + "/" + corte.Fecha.Day + "','" +
                                  corte.Cajero + "','" + corte.Turno + "'," +
                                  corte.Total + ")";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("ERROR: No se pudo generar el corte!");
            }
        }

        public static clCorte ObtenerCorte(int corte)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "select * from puntoventa.corte where idCorte = " + corte;
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                //enviarSQL.ExecuteNonQuery();
                //obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                clCorte nuevoCorte = new clCorte();

                nuevoCorte.IdCorte = int.Parse(lector.GetValue(0).ToString());
                nuevoCorte.Fecha   = DateTime.Parse(lector.GetValue(1).ToString());
                nuevoCorte.Cajero  = lector.GetValue(2).ToString();
                nuevoCorte.Turno   = lector.GetValue(3).ToString();
                nuevoCorte.Total = float.Parse(lector.GetValue(4).ToString());

                return nuevoCorte;
            }
            catch
            {
                MessageBox.Show("ERROR: No se pudo generar el corte!");
                return null;
            }
        }

        public static MySqlDataReader ObtenerPorFecha(string fecha)
        {
            // SELECT * FROM puntoventa.corte where Fecha = '2016-5-6'
            clConexion conexion = new clConexion();
            string consulta = "SELECT * FROM puntoventa.corte where Fecha = '" + fecha + "'";
            MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
            enviarSQL.ExecuteNonQuery();
            MySqlDataReader lector = enviarSQL.ExecuteReader();
            lector.Read();
            return lector;
        }

        public static MySqlDataReader ObtenerPorTurno(string turno)
        {
            clConexion conexion = new clConexion();
            string consulta = "SELECT * FROM puntoventa.corte where Turno = '" + turno + "'";
            MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
            enviarSQL.ExecuteNonQuery();
            MySqlDataReader lector = enviarSQL.ExecuteReader();
            lector.Read();

            return lector;
        }

        public static MySqlDataReader ObtenerPorCajero(string nombre)
        {
            clConexion conexion = new clConexion();
            string consulta = "SELECT * FROM puntoventa.corte where Cajero = '" + nombre + "'";
            MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
            enviarSQL.ExecuteNonQuery();
            MySqlDataReader lector = enviarSQL.ExecuteReader();
            lector.Read();

            return lector;
        }
    }
}
