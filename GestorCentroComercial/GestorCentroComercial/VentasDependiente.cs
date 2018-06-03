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
    public partial class VentasDependiente : Form
    {
        public VentasDependiente()
        {
            InitializeComponent();
        }

        private void ventasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultas);

        }

        private void VentasDependiente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultas.Ventas' table. You can move, or remove it, as needed.
            this.ventasTableAdapter.FillBy1(this.consultas.Ventas,login.password);

        }
    }
}
