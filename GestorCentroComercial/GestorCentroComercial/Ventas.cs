using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Comercial_APP
{
    class Ventas
    {
        #region DECLARACION DE VARIABLES
        private DateTime fecha_venta;
        private String codigo_centro;
        private String codigo_dependiente;
        private String dni_cliente;
        private float descuento;
        private String codigo_venta;
        private String codigo_articulo;
        private int unidades;
        private float precio_final;
        #endregion
        #region DECLARACION DE CONSTRUCTORES
        #region GENERAL
        public Ventas(DateTime fecha_venta, string codigo_centro, string codigo_dependiente, string dni_cliente, float descuento)
        {
            this.fecha_venta = fecha_venta;
            this.codigo_centro = codigo_centro;
            this.codigo_dependiente = codigo_dependiente;
            this.dni_cliente = dni_cliente;
            this.descuento = descuento;
        }
        #endregion
        #region DETALLADA
        public Ventas(string codigo_venta, string codigo_articulo, int unidades, float precio_final)
        {
            this.codigo_venta = codigo_venta;
            this.codigo_articulo = codigo_articulo;
            this.unidades = unidades;
            this.precio_final = precio_final;
        }
        #endregion
        #endregion
        #region DECLARACION DE GETTERS
        public String getcodigo_centro
        {
            get { return codigo_centro; }
        }
        public String getcodigo_dependiente
        {
            get { return codigo_dependiente; }
        }
        public String getdni_cliente
        {
            get { return dni_cliente; }
        }
        public String getcodigo_venta
        {
            get { return codigo_venta; }
        }
        public String getcodigo_articulo
        {
            get { return codigo_articulo; }
        }
        public float getdescuento
        {
            get { return descuento; }
        }
        public float getprecio_final
        {
            get { return precio_final; }
        }
        public int getunidades
        {
            get { return unidades; }
        }
        public DateTime getfecha_venta
        {
            get { return fecha_venta; }
        }
        #endregion
    }
}
