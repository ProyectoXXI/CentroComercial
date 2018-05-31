using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Comercial_APP
{
    class Curriculum
    {
        #region DECLARACION DE VARIABLES
        private String titulacion;
        private String centro;
        private DateTime fecha_titulo;
        #endregion
        #region DECLARACION DE CONSTRUCTORES
        public Curriculum(string titulacion, string centro, DateTime fecha_titulo)
        {
            this.titulacion = titulacion;
            this.centro = centro;
            this.fecha_titulo = fecha_titulo;
        }
        #endregion
        #region DECLARACION DE GETTERS
        public String getTitulacion{
            get { return titulacion; }
        }
        public String getCentro
        {
            get { return centro; }
        }
        public DateTime getFecha_titulo
        {
            get { return fecha_titulo; }
        }
        #endregion
    }
}
