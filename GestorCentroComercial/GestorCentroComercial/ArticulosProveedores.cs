using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Comercial_APP
{
    class ArticulosProveedores
    {

        #region DECLARACION DE VARIABLES
        #region INFORMACION GENERAL
        private DateTime fecha_pedido;
        private String codigo_proveedor;
        private float descuento;
        #endregion
        #region INFORMACION DETALLADA
        private int codigo_pedido;
        private int codigo_articulo;
        private int unidades; 
        private float precio_coste;
        #endregion
        #endregion
        #region DECLARACION CONSTRUCTORES
        public ArticulosProveedores(DateTime fecha_pedido, string codigo_proveedor, float descuento)
        {
            this.fecha_pedido = fecha_pedido;
            this.codigo_proveedor = codigo_proveedor;
            this.descuento = descuento;
        }

        public ArticulosProveedores(int codigo_pedido, int codigo_articulo, int unidades, float precio_coste)
        {
            this.codigo_pedido = codigo_pedido;
            this.codigo_articulo = codigo_articulo;
            this.unidades = unidades;
            this.precio_coste = precio_coste;
        }
        #endregion
        #region DECLARACION GETTERS
        public DateTime getFecha_pedido
        {
            get { return fecha_pedido; }
        }
        public String getCodigo_Proveedor
        {
            get { return codigo_proveedor; }
        }
        public float getDescuento
        {
            get { return descuento; }
        }
        public int getCodigo_pedido
        {
            get { return codigo_pedido; }
        }
        public int getCodigo_articulo
        {
            get { return codigo_articulo; }
        }
        public int getUnidades
        {
            get { return unidades; }
        }
        public float getPrecio_coste
        {
            get { return precio_coste; }
        }
        #endregion
    }
}
