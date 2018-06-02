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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void articulosProveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.articulosProveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultas);

        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultas.ArticulosProveedores' table. You can move, or remove it, as needed.
            this.articulosProveedoresTableAdapter.Fill(this.consultas.ArticulosProveedores);

        }
    }
}
