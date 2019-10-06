using System;
using System.Text;

namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
        #region Atributos

        private EMarca marca;
        private string codigoDeBarras;
        private ConsoleColor colorPrimarioEmpaque;

        public enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }

        #endregion Atributos

        #region Constructor

        /// <summary>
        /// Constructor de la clase Base "Producto" , solo utilizable desde clases derivadas
        /// </summary>
        /// <param name="marca">Nombre de la marca</param>
        /// <param name="codigoDeBarras">Codigo de barras</param>
        /// <param name="colorPrimarioEmpaque">Color del empaque</param>
        public Producto( EMarca marca, string codigoDeBarras, ConsoleColor colorPrimarioEmpaque )
        {
            this.marca = marca;
            this.codigoDeBarras = codigoDeBarras;
            this.colorPrimarioEmpaque = colorPrimarioEmpaque;
        }

        #endregion Constructor

        #region Propiedades

        /// <summary>
        /// ReadOnly: Retornará la cantidad de calorias del producto
        /// </summary>
        protected abstract short CantidadCalorias
        {
            get;
        }

        #endregion Propiedades

        #region Metodos

        /// <summary>
        /// Devuelve todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return ((string) this);
        }

        /// <summary>
        /// Devuelve todos los datos del producto
        /// </summary>
        /// <param name="producto"></param>
        public static explicit operator string( Producto producto )
        {
            StringBuilder descripcion = new StringBuilder();

            descripcion.AppendFormat("CODIGO DE BARRAS: {0}\r\n", producto.codigoDeBarras);
            descripcion.AppendFormat("MARCA          : {0}\r\n", producto.marca.ToString());
            descripcion.AppendFormat("COLOR EMPAQUE  : {0}\r\n", producto.colorPrimarioEmpaque.ToString());
            descripcion.AppendFormat("---------------------");

            return descripcion.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="producto1"></param>
        /// <param name="producto2"></param>
        /// <returns></returns>
        public static bool operator ==( Producto producto1, Producto producto2 )
        {
            if (producto1.codigoDeBarras == producto2.codigoDeBarras)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="producto1"></param>
        /// <param name="producto2"></param>
        /// <returns></returns>
        public static bool operator !=( Producto producto1, Producto producto2 )
        {
            if (!(producto1 == producto2))
            {
                return true;
            }

            return false;
        }

        #region Equals / GetHashCode

        //Esto lo pongo para que no tire warnings
        public override bool Equals( object obj )
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion Equals / GetHashCode

        #endregion Metodos
    }
}