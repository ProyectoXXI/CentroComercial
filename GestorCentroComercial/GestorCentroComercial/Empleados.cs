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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void empleadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultas);

        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultas.Empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.consultas.Empleado);

        }
    }
}
