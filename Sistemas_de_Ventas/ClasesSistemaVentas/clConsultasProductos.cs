using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ClasesSistemaVentas
{
    public class clConsultasProductos
    {
        //actualizar stock de producto
        public static void ActualizaStock(string codigo, string cantidad)
        {
            try
            {
                clProducto prod = BuscarPorCodigo(int.Parse(codigo));
                prod.Stock1 = prod.Stock1 + float.Parse(cantidad);
                clConexion conexion = new clConexion();
                string consulta = "update puntoventa.productos set Stock = "+prod.Stock1+" where codigo = "+prod.Codigo1+";";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error en la conexion!!!");
            }
        }

        //buscar producto por codigo interno
        public static clProducto BuscarPorCodigo(int codigo)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "SELECT * FROM puntoventa.productos where Codigo=" + codigo;
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                //obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                clProducto producto = new clProducto(lector);
                return producto;
            }
            catch
            {
                MessageBox.Show("Error en la conexion a la base de datos!");
                return null;
            }
        }

        //buscar producto por codigo externo...
        public static clProducto BuscarPorCodigoExterno(string externo)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "SELECT * FROM puntoventa.productos where CodigoExterno='" + externo +"'";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                //obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                clProducto producto = new clProducto(lector);
                return producto;
            }
            catch
            {
                MessageBox.Show("Error en la conexion a la base de datos!");
                return null;
            }
        }

        public static List<clProducto> BuscarDescripcion(string descripcion)
        {
            try
            {
                clProducto producto;
                List<clProducto> productos = new List<clProducto>();

                clConexion conexion = new clConexion();
                string consulta = "SELECT * FROM puntoventa.productos where Descripcion like '%" + descripcion +"%';";

                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                ////obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                //int cont = 0;
                while (lector.Read())
                {
                    producto = new clProducto(lector);
                    productos.Add(producto);
                    //cont++;
                }

                return productos;

                //clProducto producto = new clProducto(lector);
                //return producto;
            }
            catch
            {
                MessageBox.Show("Error en la conexion a la base de datos!");
                return null;
            }
        }

        //editar producto...
        public static void EditarProducto(clProducto producto)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "update puntoventa.productos set " +
                                  "Descripcion='" + producto.Descripcion1 + "'," +
                                  "Venta='" + producto.Venta1 + "',Precio=" + producto.Precio1 + ",Iva=" + producto.IVA1 +
                                  ",Stock= " + producto.Stock1 + " where Codigo=" + producto.Codigo1 + ";";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error en la conexion!");
            }
        }

        //agregar nuevo producto...
        public static void NuevoProducto(clProducto Producto)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "insert into productos(Codigo,CodigoExterno,Descripcion,Venta,Precio,Iva,Stock) " +
	                              "values(" + Producto.Codigo1 + ",'" + Producto.CodigoExt1 + "','" +
                                  Producto.Descripcion1 + "','" + Producto.Venta1 + "'," +
                                  Producto.Precio1 + "," + Producto.IVA1 + "," + Producto.Stock1 +")";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                MessageBox.Show("Producto agregado con éxito!");
            }
            catch
            {
                MessageBox.Show("ERROR: No se pudo insertar el registro!");
            }
        }

        //eliminar producto...
        public static void EliminarProducto(clProducto producto)
        {
            clConexion conexion = new clConexion();
            string consulta = "delete from productos where Codigo=" + producto.Codigo1 + ";";
            MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
            enviarSQL.ExecuteNonQuery();
        }

        //metodo para obtener el siguiente registro a insertar en la tabla productos
        public static string SiguienteRegistro()
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "SELECT MAX(Codigo) FROM Productos";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                return (int.Parse(lector.GetValue(0).ToString())+1).ToString();
            }
            catch
            {
                MessageBox.Show("Error en la conexion!");
                return null;
            }
        }

    }
}
