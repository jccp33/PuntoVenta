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
    public partial class CAMBIO : Form
    {
        public CAMBIO(float cambio)
        {
            InitializeComponent();
            lbCambio.Text = lbCambio.Text + " " + cambio;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
