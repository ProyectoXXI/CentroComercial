using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Comercial_APP
{
    class ArticulosCentroComercial
    {
        #region DECLARACION DE VARIABLES
        private String codigo_centro;
        private String codigo_articulo;
        private DateTime fecha_entrada;
        private String nombre_articulo;
        private String modelo;
        private String caracteristicas;
        private int unidades_stock;
        private int precio_coste;
        private int beneficios;
        #endregion
        #region DECLARACION DE CONSTRUCTOR
        public ArticulosCentroComercial(string codigo_centro, string codigo_articulo, DateTime fecha_entrada, string nombre_articulo, string modelo, string caracteristicas, int unidades_stock, int precio_coste, int beneficios)
        {
            this.codigo_centro = codigo_centro;
            this.codigo_articulo = codigo_articulo;
            this.fecha_entrada = fecha_entrada;
            this.nombre_articulo = nombre_articulo;
            this.modelo = modelo;
            this.caracteristicas = caracteristicas;
            this.unidades_stock = unidades_stock;
            this.precio_coste = precio_coste;
            this.beneficios = beneficios;
        }
        #endregion
        #region DECLARACION DE GETTERS
        public String getCodigo_centro
        {
            get { return codigo_centro; }
        }
        public String getcodigo_articulo
        {
            get { return codigo_articulo; }
        }
        public DateTime getfecha_entrada
        {
            get { return fecha_entrada; }
        }
        public String getnombre_articulo
        {
            get { return nombre_articulo; }
        }
        public String getmodelo
        {
            get { return modelo; }
        }
        public String getcaracteristicas
        {
            get { return caracteristicas; }
        }
        public int getunidades_stock
        {
            get { return unidades_stock; }
        }
        public int getprecio_coste
        {
            get { return precio_coste; }
        }
        public int getbeneficios
        {
            get { return beneficios; }
        }
        #endregion
    }
}
