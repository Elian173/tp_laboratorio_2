using EntidadesAbstractas;
using System.Text;

/*Clase Alumno:
 Atributos ClaseQueToma del tipo EClase y EstadoCuenta del tipo EEstadoCuenta.
 Sobreescribirá el método MostrarDatos con todos los datos del alumno.
 ParticiparEnClase retornará la cadena "TOMA CLASE DE " junto al nombre de la clase que toma.
 ToString hará públicos los datos del Alumno.
 Un Alumno será igual a un EClase si toma esa clase y su estado de cuenta no es Deudor.
 Un Alumno será distinto a un EClase sólo si no toma esa clase*/

namespace Clases_Instanciables
{
    public sealed class Alumno: Universitario
    {
        public enum EEstadoCuenta
        {
            AlDia, Deudor, Becado
        }

        #region Atributos

        private EEstadoCuenta estadoCuenta;
        private Universidad.EClases claseQueToma;

        #endregion Atributos

        #region Constructores

        public Alumno() : base()
        {
        }

        /// <summary>
        /// Constructor de alumno sin estado de cuenta, asigna por defecto Cuota al dia
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno( int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma )
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
            this.estadoCuenta = EEstadoCuenta.AlDia;
        }

        /// <summary>
        /// Constructor completo de alumno
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno( int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta )
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        #endregion Constructores

        #region Metodos

        /// <summary>
        /// Devuelve un string con todos los datos del alumno
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder descripcion = new StringBuilder();
            string estado;
            if (this.estadoCuenta == EEstadoCuenta.AlDia)
            {
                estado = "Cuota al dia";
            }
            else
            {
                estado = this.estadoCuenta.ToString();
            }

            descripcion.Append(base.MostrarDatos());
            descripcion.AppendFormat("Estado de cuenta : {0}\n", estado);
            descripcion.AppendFormat("{0}\n", ParticiparEnClase());

            return descripcion.ToString();
        }

        /// <summary>
        /// Devuelve un string que informa que clase toma el alumno
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder descripcion = new StringBuilder();
            descripcion.AppendFormat("TOMA CLASE DE {0}", this.claseQueToma);

            return descripcion.ToString();
        }

        /// <summary>
        /// Hace publicos los datos del alumno
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #region GHC/EQ

        //Esto esta solo para que no tire warnings
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals( object obj )
        {
            return base.Equals(obj);
        }

        #endregion GHC/EQ

        #endregion Metodos

        #region Sobrecarga operadores

        /// <summary>
        /// Comprueba si un alumno toma determinada clase , validando que no sea deudor
        /// </summary>
        /// <param name="a">el alumno</param>
        /// <param name="clase"></param>
        /// <returns>True si participa en la clase, false si no</returns>
        public static bool operator ==( Alumno a, Universidad.EClases clase )
        {
            if (a.claseQueToma == clase)
            {
                if (a.estadoCuenta != EEstadoCuenta.Deudor)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Comprueba si un alumno no participa en una clase
        /// </summary>
        /// <param name="a">el alumno</param>
        /// <param name="clase"></param>
        /// <returns>True si participa en la clase, false si no</returns>
        public static bool operator !=( Alumno a, Universidad.EClases clase )
        {
            if (a.claseQueToma != clase)
            {
                return true;
            }

            return false;
        }

        #endregion Sobrecarga operadores
    }
}