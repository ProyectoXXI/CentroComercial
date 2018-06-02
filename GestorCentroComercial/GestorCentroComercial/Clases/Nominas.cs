using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Comercial_APP
{
    class Nominas
    {
        #region DECLARACION DE VARIABLES
        private float periodoNominaMeses;
        private DateTime fechaNomina;
        private String dniEmpleado;
        private String nombre; 
        private String apellidos;
        private float sueldoBruto;
        private float descuentoSeguridad;
        private float totalDinero;
        private float descuentoIRPF;
        private float plustrienios;
        private float plusproductividad;
        private int horasTrabajadas;
        private int horasMes;
        #endregion
        #region DECLARACION DE CONSTRUCTOR
        #region GENERAL
        public Nominas(float periodoNominaMeses, DateTime fechaNomina, string dniEmpleado, string nombre, string apellidos, float sueldoBruto, float descuentoSeguridad, float totalDinero, float descuentoIRPF, float plustrienios, float plusproductividad)
        {
            this.periodoNominaMeses = periodoNominaMeses;
            this.fechaNomina = fechaNomina;
            this.dniEmpleado = dniEmpleado;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.sueldoBruto = sueldoBruto;
            this.descuentoSeguridad = descuentoSeguridad;
            this.totalDinero = totalDinero;
            this.descuentoIRPF = descuentoIRPF;
            this.plustrienios = plustrienios;
            this.plusproductividad = plusproductividad;
        }
        #endregion
        #region HORAS
        public Nominas(float periodoNominaMeses, DateTime fechaNomina, string dniEmpleado, string nombre, string apellidos, float sueldoBruto, float descuentoSeguridad, float totalDinero, float descuentoIRPF, float plustrienios, float plusproductividad, int horasTrabajadas, int horasMes)
        {
            this.periodoNominaMeses = periodoNominaMeses;
            this.fechaNomina = fechaNomina;
            this.dniEmpleado = dniEmpleado;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.sueldoBruto = sueldoBruto;
            this.descuentoSeguridad = descuentoSeguridad;
            this.totalDinero = totalDinero;
            this.descuentoIRPF = descuentoIRPF;
            this.plustrienios = plustrienios;
            this.plusproductividad = plusproductividad;
            this.horasTrabajadas = horasTrabajadas;
            this.horasMes = horasMes;
        }
        #endregion
        #endregion
        #region DECLARACION DE GETTERS
        public DateTime getfechaNomina
        {
            get { return fechaNomina; }
        }
        public String getdniEmpleado
        {
            get { return dniEmpleado; }
        }
        public String getnombre
        {
            get { return nombre; }
        }
        public String getapellidos
        {
            get { return apellidos; }
        }
        public float getperiodoNominaMeses
        {
            get { return periodoNominaMeses; }
        }
        public float getsueldoBruto
        {
            get { return sueldoBruto; }
        }
        public float getdescuentoSeguridad
        {
            get { return descuentoSeguridad; }
        }
        public float getdescuentoIRPF
        {
            get { return descuentoIRPF; }
        }
        public float gettotalDinero
        {
            get { return totalDinero; }
        }
        public float getplustrienios
        {
            get { return plustrienios; }
        }
        public float getplusproductividad
        {
            get { return plusproductividad; }
        }
        public int gethorasTrabajadas
        {
            get { return horasTrabajadas; }
        }
        public int gethorasMes
        {
            get { return horasMes; }
        }
        #endregion
    }
}
