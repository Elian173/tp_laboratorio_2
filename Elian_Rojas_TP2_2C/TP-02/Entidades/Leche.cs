using System;
using System.Text;

namespace Entidades_2018
{
    public class Leche: Producto
    {
        #region Atributos

        public enum ETipo
        {
            Entera, Descremada
        }

        private ETipo tipo;

        #endregion Atributos

        #region Constructores

        /// <summary>
        /// Constructor publico Leche , con un tipo especifico (Por defecto, TIPO será ENTERA)
        /// </summary>
        /// <param name="marca">Nombre de la marca</param>
        /// <param name="codigoDeBarras">Codigo de barras</param>
        /// <param name="colorEmpaque">Color del empaque</param>
        /// <param name="tipoDeLeche">(Entera o Descremada)</param>
        public Leche( EMarca marca, string codigoDeBarras, ConsoleColor colorEmpaque, ETipo tipoDeLeche ) : base(marca, codigoDeBarras, colorEmpaque)
        {
            this.tipo = tipoDeLeche;
        }

        /// <summary>
        ///  Constructor publico Leche , (Por defecto, TIPO será ENTERA)
        /// </summary>
        /// <param name="marca">Nombre de la marca</param>
        /// <param name="codigoDeBarras">Codigo de barras</param>
        /// <param name="colorEmpaque">Color del empaque</param>
        public Leche( EMarca marca, string codigoDeBarras, ConsoleColor color ) : this(marca, codigoDeBarras, color, ETipo.Entera)
        {
        }

        #endregion Constructores

        #region Propiedades

        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        #endregion Propiedades

        #region Metodos

        /// <summary>
        /// Expone los datos del elemento , incluyendo los de su clase base ( Producto ).
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder descripcion = new StringBuilder();

            descripcion.AppendLine("LECHE");
            descripcion.AppendLine(base.Mostrar());
            descripcion.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            descripcion.AppendLine("");
            descripcion.AppendLine("TIPO : " + this.tipo);

            descripcion.AppendLine("---------------------");

            return descripcion.ToString();
        }

        #endregion Metodos
    }
}