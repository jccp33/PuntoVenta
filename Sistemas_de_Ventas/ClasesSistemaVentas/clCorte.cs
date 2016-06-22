using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesSistemaVentas
{
    public class clCorte
    {
        int idCorte;
        DateTime fecha;
        string cajero;
        string turno;
        float total;

        public int IdCorte
        {
            get
            {
                return idCorte;
            }

            set
            {
                idCorte = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string Cajero
        {
            get
            {
                return cajero;
            }

            set
            {
                cajero = value;
            }
        }

        public string Turno
        {
            get
            {
                return turno;
            }

            set
            {
                turno = value;
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
