using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Comercial_APP
{
    class Empleado
    {
        #region DECLARACION DE VARIABLES
        private String codgioEmpleado;
        private String rol;
        private String dni;
        private String nombre;
        private String apellidos;
        private String direccion;
        private String telefono;
        private String email;
        private DateTime ingreso;
        private DateTime nacimiento;
        private String departamento;
        private String centro;
        private Curriculum curriculum;
        private String tipo_contrato;
        private int precio_hora;
        #endregion
        #region DECLARACION DE CONSTRUCTORES
        public Empleado(string codgioEmpleado,string rol, string dni, string nombre, string apellidos, string direccion, String telefono, string email, DateTime ingreso, DateTime nacimiento, string departamento, string centro, Curriculum curriculum, string tipo_contrato, int precio_hora)
        {
            this.codgioEmpleado = codgioEmpleado;
            this.rol = rol;
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.ingreso = ingreso;
            this.nacimiento = nacimiento;
            this.departamento = departamento;
            this.centro = centro;
            this.curriculum = curriculum;
            this.tipo_contrato = tipo_contrato;
            this.precio_hora = precio_hora;
        }
        #endregion
        #region DECLARACION GETTERS
        public string getcodgioEmpleado
        {
            get
            {
                return codgioEmpleado;
            }
        }
        public string getRol {
            get {
                return rol;
            }
        }
        public string getDni {
            get {
                return dni;
            }
        }
        public string getNombre {
            get {
                return nombre;
            }
        }
        public string getApellidos{
            get {
                return apellidos;
            }
        }
        public string getDireccion {
            get {
                return direccion;
            }
        }
        public String getTelefono
        {
            get {
                return telefono;
            }
        }
        public string getEmail {
            get {
                return email;
            }
        }
        public DateTime getIngreso {
            get {
                return ingreso;
            }
        }
        public DateTime getNacimiento {
            get {
                return nacimiento;
            }
        }
        public string getDepartamento{
            get {
                return departamento;
            }
        }
        public string getCentro {
            get {
                return centro;
            }
        }
        public string getTipo_contrato {
            get {
                return tipo_contrato;
            }
        }
        public int getPrecio_hora
        {
            get {
                return precio_hora;
            }
        }
        public Curriculum getCurriculum {
            get {
                return curriculum;
            }
        }
        #endregion
    }
}
