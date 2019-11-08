using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.Text;

/*Clase Profesor:
 Atributos ClasesDelDia del tipo Cola y random del tipo Random y estático.
 Sobrescribir el método MostrarDatos con todos los datos del profesor.
 ParticiparEnClase retornará la cadena "CLASES DEL DÍA" junto al nombre de la clases que da.
 ToString hará públicos los datos del Profesor.
 Se inicializará a Random sólo en un constructor.
 En el constructor de instancia se inicializará ClasesDelDia y se asignarán dos clases al azar al Profesor mediante el método randomClases. Las dos clases pueden o no ser la misma.
 Un Profesor será igual a un EClase si da esa clase.
*/

namespace Clases_Instanciables
{
    public sealed class Profesor: Universitario
    {
        #region Atributos

        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #endregion Atributos

        #region Constructores

        public Profesor() : base()
        {
        }

        static Profesor()//asumo que esto inicializa el parametro random
        {
            Profesor.random = new Random();
        }

        public Profesor( int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad ) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            RandomClases();
        }

        #endregion Constructores

        #region Metodos

        protected override string MostrarDatos()
        {
            StringBuilder descripcion = new StringBuilder();
            descripcion.AppendLine(base.MostrarDatos());
            descripcion.AppendFormat("{0}", ParticiparEnClase());

            return descripcion.ToString();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder descripcion = new StringBuilder();

            descripcion.AppendLine("CLASES DEL DIA:");

            foreach (Universidad.EClases clase in this.clasesDelDia)
            {
                descripcion.AppendFormat("{0}\n", clase);
            }

            return descripcion.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos();
        }

        private void RandomClases()
        {
            this.clasesDelDia.Enqueue((Universidad.EClases) Profesor.random.Next(0, 4));

            this.clasesDelDia.Enqueue((Universidad.EClases) Profesor.random.Next(0, 4));
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

        #region Sobrecarga Operadores

        public static bool operator ==( Profesor i, Universidad.EClases clase )
        {
            if (i.clasesDelDia.Contains(clase))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=( Profesor i, Universidad.EClases clase )
        {
            if (!(i == clase))
            {
                return true;
            }

            return false;
        }

        #endregion Sobrecarga Operadores
    }
}