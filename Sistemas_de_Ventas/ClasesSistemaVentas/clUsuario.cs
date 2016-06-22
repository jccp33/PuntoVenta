using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ClasesSistemaVentas
{
    public class clUsuario
    {
        int clave;

        public int Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        //constructores
        public clUsuario()
        {
            clave = 0;
            tipo = "";
            nombre = "";
            password = "";
        }

        //constructor que asigna los valores obtenidos de un dataReader
        public clUsuario(MySqlDataReader datos)
        {
            try
            {
                clave = int.Parse(datos.GetValue(0).ToString());
                tipo = datos.GetValue(1).ToString();
                nombre = datos.GetValue(2).ToString();
                password = datos.GetValue(3).ToString();
            }
            catch
            {
                MessageBox.Show("Error con los datos del usuario!");
            }
        }

    }
}
