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
    public partial class ArticuloCentro : Form
    {
        public ArticuloCentro()
        {
            InitializeComponent();
        }

        private void articulosCentroComercialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.articulosCentroComercialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultas);

        }

        private void ArticuloCentro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultas.ArticulosCentroComercial' table. You can move, or remove it, as needed.
            this.articulosCentroComercialTableAdapter.Fill(this.consultas.ArticulosCentroComercial);

        }
    }
}
