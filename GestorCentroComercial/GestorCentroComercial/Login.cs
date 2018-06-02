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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            String usuario = tbUser.Text.ToString();
            int password = int.Parse(tbPass.Text.ToString());
            if(empleadoTableAdapter1.ComprobarPassword(password) != null){
                MessageBox.Show("Entra");
            }
            else
            {
                MessageBox.Show("NO");
            }
        }
    }
}
