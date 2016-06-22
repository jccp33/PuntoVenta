using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ClasesSistemaVentas
{
    public class clProducto
    {
        //propiedades...
        private int Codigo;
        public int Codigo1
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        private string CodigoExt;
        public string CodigoExt1
        {
            get { return CodigoExt; }
            set { CodigoExt = value; }
        }

        private string Descripcion;
        public string Descripcion1
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }

        private string Venta;
        public string Venta1
        {
            get { return Venta; }
            set { Venta = value; }
        }

        private float Precio;
        public float Precio1
        {
            get { return Precio; }
            set { Precio = value; }
        }

        private int IVA;
        public int IVA1
        {
            get { return IVA; }
            set { IVA = value; }
        }

        private float Stock;
        public float Stock1
        {
            get { return Stock; }
            set { Stock = value; }
        }

        //constructores...
        public clProducto(MySqlDataReader datos)
        {
            try
            {
                Codigo = int.Parse(datos.GetValue(0).ToString());
                CodigoExt = datos.GetValue(1).ToString();
                Descripcion = datos.GetValue(2).ToString();
                Venta = datos.GetValue(3).ToString();
                Precio = float.Parse(datos.GetValue(4).ToString());
                IVA = int.Parse(datos.GetValue(5).ToString());
                Stock = float.Parse(datos.GetValue(6).ToString());
            }
            catch
            {
                MessageBox.Show("Error en los datos del producto!");
            }
        }

        public clProducto()
        {
            Codigo = 0;
            CodigoExt = "";
            Descripcion = "";
            Venta = "";
            Precio = 0;
            IVA = 0;
            Stock = 0;
        }

    }
}
