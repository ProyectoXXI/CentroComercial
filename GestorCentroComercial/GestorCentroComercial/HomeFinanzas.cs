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
    public partial class HomeFinanzas : Form
    {
        public HomeFinanzas()
        {
            InitializeComponent();
        }

        private void bEmpleados_Click_1(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
            empleados.Visible = true;
        }

        private void btnmostrarArtiucloscentro_Click_1(object sender, EventArgs e)
        {
            ArticuloCentro art = new ArticuloCentro();
            art.Visible = true;
        }

        private void btnmostrarNominas_Click_1(object sender, EventArgs e)
        {
            Nominas nominas = new Nominas();
            nominas.Visible = true;
        }

        private void btnmostrarVentas_Click_1(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Visible = true;
        }

        private void btnmostrarProveedores_Click_1(object sender, EventArgs e)
        {
            Proveedores pro = new Proveedores();
            pro.Visible = true;
        }

        private void btnMostrarPedidos_Click_1(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Visible = true;
        }



        private void HomeFinanzas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Visible = true;
            this.Visible = false;
        }
    }
}
