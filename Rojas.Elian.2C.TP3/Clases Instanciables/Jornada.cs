using Archivos;
using System;
using System.Collections.Generic;
using System.Text;

/*/*Clase Jornada:
 Atributos Profesor, Clase y Alumnos que toman dicha clase.
 Se inicializará la lista de alumnos en el constructor por defecto.
 Una Jornada será igual a un Alumno si el mismo participa de la clase.
 Agregar Alumnos a la clase por medio del operador +, validando que no estén previamente cargados.
 ToString mostrará todos los datos de la Jornada.
 Guardar de clase guardará los datos de la Jornada en un archivo de texto.
 Leer de clase retornará los datos de la Jornada como texto.*/

namespace Clases_Instanciables
{
    public class Jornada
    {
        #region Atributos

        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        #endregion Atributos

        #region Propiedades

        public List<Alumno> Alumno
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }

        #endregion Propiedades

        #region Constructores

        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada( Universidad.EClases clase, Profesor instructor ) : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        #endregion Constructores

        #region Metodos

        public static bool Guardar( Jornada jornada )
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "DatosJornada.txt";
            Texto archivador = new Texto();
            archivador.Guardar(path, jornada.ToString());

            return true;
        }

        public static string Leer()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "DatosJornada.txt";
            Texto archivador = new Texto();
            string textoLeido;
            archivador.Leer(path, out textoLeido);

            return textoLeido;
        }

        public override string ToString()
        {
            StringBuilder descripcion = new StringBuilder();
            descripcion.AppendFormat("CLASE DE {0}", this.clase);
            descripcion.AppendFormat(" POR {0} \n", this.instructor.ToString());
            descripcion.AppendLine("Alumnos: ");

            foreach (Alumno alumno in this.alumnos)
            {
                descripcion.AppendFormat("{0} \n", alumno.ToString());
            }
            descripcion.AppendLine("<--------------------------------------->");
            return descripcion.ToString();
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

        public static bool operator ==( Jornada j, Alumno a )
        {
            if (j.alumnos.Contains(a))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=( Jornada j, Alumno a )
        {
            if (!(j == a))
            {
                return true;
            }

            return false;
        }

        public static Jornada operator +( Jornada j, Alumno a )
        {
            if (j != a)
            {
                j.alumnos.Add(a);
            }

            return j;
        }

        #endregion Sobrecarga Operadores
    }
}