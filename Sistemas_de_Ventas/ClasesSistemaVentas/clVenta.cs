using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesSistemaVentas
{
    public class clVenta
    {
        int idVenta;
        DateTime hora;
        float subTotal;
        float iva;
        float total;
        int corte;

        public int IdVenta
        {
            get
            {
                return idVenta;
            }

            set
            {
                idVenta = value;
            }
        }

        public DateTime Hora
        {
            get
            {
                return hora;
            }

            set
            {
                hora = value;
            }
        }

        public float SubTotal
        {
            get
            {
                return subTotal;
            }

            set
            {
                subTotal = value;
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

        public int Corte
        {
            get
            {
                return corte;
            }

            set
            {
                corte = value;
            }
        }
    }
}
