using System.Collections.Generic;
using System.Text;

namespace Entidades_2018
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Changuito
    {
        #region Atributos

        private List<Producto> productos;
        private int espacioDisponible;

        public enum ETipo
        {
            Dulce, Leche, Snacks, Todos
        }

        #endregion Atributos

        #region "Constructores"

        /// <summary>
        /// Constructor privado , inicializa la lista.
        /// </summary>
        private Changuito()
        {
            this.productos = new List<Producto>();
        }

        /// <summary>
        ///  Constructor publico , para instanciar un objeto
        /// </summary>
        /// <param name="espacioDisponible">Cantidad maxima de objetos "Producto" que entraran en el changuito</param>
        public Changuito( int espacioDisponible ) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }

        #endregion "Constructores"

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="changuito">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Mostrar( Changuito changuito, ETipo tipo )
        {
            StringBuilder descripcion = new StringBuilder();

            descripcion.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", changuito.productos.Count, changuito.espacioDisponible);
            descripcion.AppendLine("");

            foreach (Producto producto in changuito.productos)
            {
                switch (tipo)
                {
                    case ETipo.Snacks:
                    if (producto is Snacks)
                    {
                        descripcion.AppendLine(producto.Mostrar());
                    }
                    break;

                    case ETipo.Dulce:
                    if (producto is Dulce)
                    {
                        descripcion.AppendLine(producto.Mostrar());
                    }
                    break;

                    case ETipo.Leche:
                    if (producto is Leche)
                    {
                        descripcion.AppendLine(producto.Mostrar());
                    }

                    break;

                    default:
                    descripcion.AppendLine(producto.Mostrar());
                    break;
                }
            }

            return descripcion.ToString();
        }

        /// <summary>
        /// Muestro el Changuito y TODOS los Productos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Mostrar(this, ETipo.Todos);
        }

        #endregion "Métodos"

        #region "Operadores"

        /// <summary>
        /// Agregará un elemento a la lista,  en caso de que no exista dentro de la misma.
        /// </summary>
        /// <param name="changuito">Objeto donde se agregará el elemento</param>
        /// <param name="producto">Objeto a agregar</param>
        /// <returns></returns>
        public static Changuito operator +( Changuito changuito, Producto producto )
        {
            foreach (Producto productoAuxiliar in changuito.productos)
            {
                if (productoAuxiliar == producto)
                    return changuito;
            }

            if (changuito.espacioDisponible > changuito.productos.Count)
            {
                changuito.productos.Add(producto);
            }

            return changuito;
        }

        /// <summary>
        /// Quitará un elemento de la lista , en caso de que exista dentro de la misma.
        /// </summary>
        /// <param name="changuito">Objeto donde se quitará el elemento</param>
        /// <param name="producto">Objeto a quitar</param>
        /// <returns></returns>
        public static Changuito operator -( Changuito changuito, Producto producto )
        {
            foreach (Producto productoAuxiliar in changuito.productos)
            {
                if (productoAuxiliar == producto)
                {
                    changuito.productos.Remove(producto);
                    break;
                }
            }

            return changuito;
        }

        #endregion "Operadores"
    }
}