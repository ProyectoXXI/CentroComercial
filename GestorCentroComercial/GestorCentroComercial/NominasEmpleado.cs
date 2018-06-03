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
    public partial class NominasEmpleado : Form
    {
        public NominasEmpleado()
        {
            InitializeComponent();
        }

        private void nominasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nominasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultas);

        }

        private void NominasEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultas.Nominas' table. You can move, or remove it, as needed.
            this.nominasTableAdapter.FillBy(this.consultas.Nominas,login.password);

        }
    }
}
