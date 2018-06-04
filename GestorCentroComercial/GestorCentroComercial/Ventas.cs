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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void ventasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
                this.Validate();
                this.ventasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.consultas);
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultas.Ventas' table. You can move, or remove it, as needed.
            this.ventasTableAdapter.Fill(this.consultas.Ventas);
            codigoDependienteTextBox.Text= empleadoTableAdapter1.obtenerCodigoDependiente(login.usuario).ToString();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
                codigoDependienteTextBox.Text = empleadoTableAdapter1.obtenerCodigoDependiente(login.usuario).ToString();
        }
    }
}
