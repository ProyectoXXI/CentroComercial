﻿using System;
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
    public partial class HomeDirectores : Form
    {
        public HomeDirectores()
        {
            InitializeComponent();
        }

        private void bEmpleados_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
            empleados.Visible = true;
        }

        private void btnmostrarArtiucloscentro_Click(object sender, EventArgs e)
        {
            ArticuloCentro art = new ArticuloCentro();
            art.Visible = true;
        }

        private void btnmostrarNominas_Click(object sender, EventArgs e)
        {
            Nominas nominas = new Nominas();
            nominas.Visible = true;
        }

        private void btnmostrarVentas_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Visible = true;
        }

        private void btnmostrarProveedores_Click(object sender, EventArgs e)
        {
            Proveedores pro = new Proveedores();
            pro.Visible = true;
        }

        private void btnMostrarPedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Visible = true;
            this.Visible = false;
        }

        private void HomeDirectores_Load(object sender, EventArgs e)
        {

        }
    }
}
