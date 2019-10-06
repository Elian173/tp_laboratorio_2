using System;
using System.Text;

namespace Entidades_2018
{
    public class Dulce: Producto
    {
        #region Constructor

        /// <summary>
        /// Constructor publico para instanciar un objeto
        /// </summary>
        /// <param name="marca">Marca del dulce</param>
        /// <param name="codigoDeBarras">Codigo de barras del dulce</param>
        /// <param name="color">Color de empaque del dulce</param>
        public Dulce( EMarca marca, string codigoDeBarras, ConsoleColor color ) : base(marca, codigoDeBarras, color)
        {
        }

        #endregion Constructor

        #region Propiedades

        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
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
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion Metodos
    }
}