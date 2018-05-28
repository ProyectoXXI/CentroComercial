using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Comercial_APP
{
    class Proveedores
    {

        #region DECLARACION DE VARIABLES
        private String cif;
        private String nombre_proveedor;
        private String direccion;
        private int codigo_postal;
        private int telefono;
        private String email;
        private String web;
        private String nombre_representante;
        private String email_representante;
        private int telefono_representante;
        #endregion
        #region DECLARACION DE CONSTRUCTOR
        public Proveedores(string cif, string nombre_proveedor, string direccion, int codigo_postal, int telefono, string email, string web, string nombre_representante, string email_representante, int telefono_representante)
        {
            this.cif = cif;
            this.nombre_proveedor = nombre_proveedor;
            this.direccion = direccion;
            this.codigo_postal = codigo_postal;
            this.telefono = telefono;
            this.email = email;
            this.web = web;
            this.nombre_representante = nombre_representante;
            this.email_representante = email_representante;
            this.telefono_representante = telefono_representante;
        }
        #endregion
        #region DECLARACION DE GETTERS
        public String getcif
        {
            get { return cif; }
        }
        public String getnombre_proveedor
        {
            get { return nombre_proveedor; }
        }
        public String getdireccion
        {
            get { return direccion; }
        }
        public String getemail
        {
            get { return email; }
        }
        public String getweb
        {
            get { return web; }
        }
        public String getnombre_representante
        {
            get { return nombre_representante; }
        }
        public String getemail_representante
        {
            get { return email_representante; }
        }
        public int gettelefono
        {
            get { return telefono; }
        }
        public int getcodigo_postal
        {
            get { return codigo_postal; }
        }
        public int gettelefono_representante
        {
            get { return telefono_representante; }
        }
        #endregion
    }
}
