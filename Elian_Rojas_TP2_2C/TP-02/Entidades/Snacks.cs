using System;
using System.Text;

namespace Entidades_2018
{
    public class Snacks: Producto
    {
        #region Constructor

        public Snacks( EMarca marca, string codigoDeBarras, ConsoleColor color ) : base(marca, codigoDeBarras, color)
        {
        }

        #endregion Constructor

        #region Propiedades

        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 104;
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

            descripcion.AppendLine("SNACKS");
            descripcion.AppendLine(base.Mostrar());
            descripcion.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            descripcion.AppendLine("");
            descripcion.AppendLine("---------------------");

            return descripcion.ToString();
        }

        #endregion Metodos
    }
}