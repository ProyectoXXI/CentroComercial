using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorCentroComercial
{
    public partial class HomeDependientes : Form
    {
        public HomeDependientes()
        {
            InitializeComponent();
        }

        private void bAddVenta_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            venta.Visible = true;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
