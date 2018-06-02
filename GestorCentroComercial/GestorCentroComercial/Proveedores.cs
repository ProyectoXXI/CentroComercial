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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultas);

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultas.Proveedores' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.Fill(this.consultas.Proveedores);

        }
    }
}
