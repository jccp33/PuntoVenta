using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ClasesSistemaVentas
{
    public class clConsultasUsuarios
    {
        //metodo que regresa los nombres de los usuarios registrados en la base de datos
        public static MySqlDataReader ObtenerNombresUsuarios()
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "select nombre from Usuarios";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                //obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                return lector;
            }
            catch
            {
                MessageBox.Show("Error en la conexion a la base de datos!");
                return null;
            }
        }

        //metodo que regresa los datos de un usuario, consulta
        public static MySqlDataReader ObtenerDatosUsuario(string nombre)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "select * from Usuarios where Nombre = '" + nombre + "'";
                //enviar consulta
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                //obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                return lector;
            }
            catch
            {
                MessageBox.Show("Error en la conexion a la base de datos!");
                return null;
            }
        }

        //metodo para obtener el siguiente registro a insertar en la tabla usuarios
        public static string SiguienteRegistro()
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "SELECT MAX(Clave) FROM Usuarios";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                return lector.GetValue(0).ToString();
            }
            catch
            {
                MessageBox.Show("Error en la conexion!");
                return null;
            }
        }

        //metodo para insertar un nuevo registro en la tabla usuarios
        public static void InsertarRegistro(clUsuario usuario)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "insert into usuarios(Clave,TipoUsuario,Nombre,Password) values ('"
                                  + usuario.Clave + "','" + usuario.Tipo + "','" + usuario.Nombre + "','" + usuario.Password + "')";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("ERROR: No se pudo insertar el registro!");
            }
        }

        public static clUsuario ObtenerUsuarioPorClave(string clave)
        {
            try
            {
                string consulta = "select * from Usuarios where Clave = '" + clave + "'";
                clConexion conex1 = new clConexion();
                //enviar consulta
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conex1.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                //obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                clUsuario usuario = new clUsuario(lector);
                return usuario;
            }
            catch
            {
                MessageBox.Show("Error en la conexion!");
                return null;
            }
        }

        public static void ActualizarRegistro(clUsuario usuario)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "update usuarios set TipoUsuario='" + usuario.Tipo + "',Nombre='" + usuario.Nombre + "',Password='" + usuario.Password + "' where Clave='" + usuario.Clave + "'";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error en la conexion!");
            }
        }

        public static void EliminarRegistro(string clave)
        {
            clConexion conexion = new clConexion();
            string consulta = "delete from usuarios where Clave='" + clave + "'";
            MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
            enviarSQL.ExecuteNonQuery();
        }

    }
}
