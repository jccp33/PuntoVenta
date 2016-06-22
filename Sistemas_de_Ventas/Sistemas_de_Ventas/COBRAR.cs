using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_de_Ventas
{
    public partial class COBRAR : Form
    {
        private float Total = 0;

        public COBRAR(float total)
        {
            InitializeComponent();
            Total = total;
            label1.Text = label1.Text + " $ " + Total;
            tbEfectivo.Text = Total.ToString();
        }

        private void tbEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbEfectivo.Text.Contains('.'))
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

            if (e.KeyChar == '\r')
            {
                try
                {
                    float efectivo = float.Parse(tbEfectivo.Text);

                    if (efectivo == Total)
                    {
                        CAMBIO cambio = new CAMBIO(0);
                        cambio.Visible = true;
                        this.Close();
                    }
                    else if (efectivo < Total)
                    {
                        Total = Total - efectivo;
                        label1.Text = " $ " + Total;
                        tbEfectivo.Text = Total.ToString();
                    }
                    else
                    {
                        CAMBIO cambio = new CAMBIO(efectivo - Total);
                        cambio.Visible = true;
                        this.Close();
                    }
                }
                catch { }
            }
        }

       

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                float efectivo = float.Parse(tbEfectivo.Text);
                
                if (efectivo == Total)
                {
                    CAMBIO cambio = new CAMBIO(0);
                    cambio.Visible = true;
                    this.Close();
                }
                else if(efectivo < Total)
                {
                    Total = Total - efectivo;
                    label1.Text = " $ " + Total;
                    tbEfectivo.Text = Total.ToString();
                }
                else
                {
                    CAMBIO cambio = new CAMBIO(efectivo - Total);
                    cambio.Visible = true;
                    this.Close();
                }
            }
            catch { }
        }
    }
}
