using System.Text;

/*Clase Universitario:
 Abstracta, con el atributo Legajo.
 Método protegido y virtual MostrarDatos retornará todos los datos del Universitario.
 Método protegido y abstracto ParticiparEnClase.
 Dos Universitario serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales.*/

namespace EntidadesAbstractas
{
    public abstract class Universitario: Persona
    {
        #region Atributos

        private int legajo;

        #endregion Atributos

        #region Constructores

        public Universitario() : base()
        {
        }

        /// <summary>
        /// Constructor completo de Universitario
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario( int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad )
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion Constructores

        #region Metodos

        /// <summary>
        /// Verifica si el parametro que se le pasa es del mismo tipo del objeto que llama al metodo,  siendo este el caso , compara si sus dni y legajos son iguales
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True si son iguales,  false si son diferentes</returns>
        public override bool Equals( object obj )
        {
            if (obj.GetType() == this.GetType())
            {
                if (((Universitario) obj).DNI == this.DNI)
                {
                    return true;
                }

                if (((Universitario) obj).legajo == this.legajo)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Devuelve un string con todos los datos del universitario
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder descripcion = new StringBuilder();
            descripcion.Append(base.ToString());
            descripcion.AppendFormat("LEGAJO NUMERO: {0}\n", this.legajo);

            return descripcion.ToString();
        }

        protected abstract string ParticiparEnClase();

        #region GHC

        //Esto esta solo para que no tire warnings
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion GHC

        #endregion Metodos

        #region Sobrecarga de operadores

        /// <summary>
        /// Compara si dos universitarios son iguales
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==( Universitario pg1, Universitario pg2 )
        {
            if (pg1.Equals(pg2))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Compara si dos universitarios son distintos
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator !=( Universitario pg1, Universitario pg2 )
        {
            if (!pg1.Equals(pg2))
            {
                return true;
            }
            return false;
        }

        #endregion Sobrecarga de operadores
    }
}