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
            VentasDependiente venta = new VentasDependiente();
            venta.Visible = true;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Visible = true;
            this.Visible = false;
        }

        private void bMostrarNominas_Click(object sender, EventArgs e)
        {
            NominasEmpleado nm = new NominasEmpleado();
            nm.Visible = true;
        }


        private void HomeDependientes_Load(object sender, EventArgs e)
        {

        }


    }
}
