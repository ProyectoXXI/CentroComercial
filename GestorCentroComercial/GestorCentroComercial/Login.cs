using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            DataTable consulta = empleadoTableAdapter1.ComprobarLogin(password, usuario);

            if (consulta != null) {

                DataRow empleado = consulta.Rows[0];

                switch (empleado["Rol"].ToString())
                {

                    case "dependiente":
                        HomeDependientes dependiente = new HomeDependientes();
                        dependiente.Visible = true;
                        this.Visible = false;

                        break;
                    case "director":
                        HomeDirectores director = new HomeDirectores();
                        director.Visible = true;
                        this.Visible = false;

                        break;
                    case "gerente":
                        HomeTecnicos tecnico = new HomeTecnicos();
                        tecnico.Visible = true;
                        this.Visible = false;

                        break;
                }


            }
            else
            {
                MessageBox.Show("Error en el login.");
            }
        

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
