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

        public Alumno( int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma )
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
            this.estadoCuenta = EEstadoCuenta.AlDia;
        }

        public Alumno( int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta )
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        #endregion Constructores

        #region Metodos

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

        protected override string ParticiparEnClase()
        {
            StringBuilder descripcion = new StringBuilder();
            descripcion.AppendFormat("TOMA CLASE DE {0}", this.claseQueToma);

            return descripcion.ToString();
        }

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