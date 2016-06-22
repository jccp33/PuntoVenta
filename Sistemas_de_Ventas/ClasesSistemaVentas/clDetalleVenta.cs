using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesSistemaVentas
{
    public class clDetalleVenta
    {
        int idDetalle;
        string codigoProd;
        string descripcion;
        float cantidad;
        float subtotal;
        float iva;
        float total;

        public int IdDetalle
        {
            get
            {
                return idDetalle;
            }

            set
            {
                idDetalle = value;
            }
        }

        public string CodigoProd
        {
            get
            {
                return codigoProd;
            }

            set
            {
                codigoProd = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public float Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public float Subtotal
        {
            get
            {
                return subtotal;
            }

            set
            {
                subtotal = value;
            }
        }

        public float Iva
        {
            get
            {
                return iva;
            }

            set
            {
                iva = value;
            }
        }

        public float Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }
    }
}
