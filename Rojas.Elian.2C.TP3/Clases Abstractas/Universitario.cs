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

        public Universitario( int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad )
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion Constructores

        #region Metodos

        /// <summary>
        /// Verifica si el objeto comparado es igual
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
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

        public static bool operator ==( Universitario pg1, Universitario pg2 )
        {
            if (pg1.Equals(pg2))
            {
                return true;
            }
            return false;
        }

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