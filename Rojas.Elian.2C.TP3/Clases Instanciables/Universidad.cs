using Archivos;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Text;

/*Clase Universidad:
 Atributos Alumnos (lista de inscriptos), Profesores (lista de quienes pueden dar clases) y Jornadas.
 Se accederá a una Jornada específica a través de un indexador.
 Un Universidad será igual a un Alumno si el mismo está inscripto en él.
 Un Universidad será igual a un Profesor si el mismo está dando clases en él.
 Al agregar una clase a un Universidad se deberá generar y agregar una nueva Jornada indicando la
clase, un Profesor que pueda darla (según su atributo ClasesDelDia) y la lista de alumnos que la
toman (todos los que coincidan en su campo ClaseQueToma).
 Se agregarán Alumnos y Profesores mediante el operador +, validando que no estén previamente
cargados.
 La igualación entre un Universidad y una Clase retornará el primer Profesor capaz de dar esa clase.
Sino, lanzará la Excepción SinProfesorException. El distinto retornará el primer Profesor que no
pueda dar la clase.
 Si al querer agregar alumnos este ya figura en la lista, lanzar la excepción AlumnoRepetidoException.
 MostrarDatos será privado y de clase. Los datos del Universidad se harán públicos mediante
ToString.
 Guardar de clase serializará los datos del Universidad en un XML, incluyendo todos los datos de sus
Profesores, Alumnos y Jornadas.
 Leer de clase retornará un Universidad con todos los datos previamente serializados.*/

namespace Clases_Instanciables
{
    public class Universidad
    {
        public enum EClases
        {
            Programacion, Laboratorio, Legislacion, SPD
        }

        #region Atributos

        private List<Alumno> alumnos;
        private List<Profesor> profesores;
        private List<Jornada> jornadas;

        #endregion Atributos

        #region Propiedades

        /// <summary>
        /// Accede a la lista de alumnos
        /// </summary>
        public List<Alumno> Alumnos
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

        /// <summary>
        /// Accede a la lista de profesores
        /// </summary>
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        /// <summary>
        /// Accede a la lista de jornadas
        /// </summary>
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornadas;
            }
            set
            {
                this.jornadas = value;
            }
        }

        #endregion Propiedades

        #region Indexador

        /// <summary>
        /// Indexador de la lista de jornadas
        /// </summary>
        /// <param name="i">indice buscado</param>
        /// <returns></returns>
        public Jornada this[int i]
        {
            get
            {
                return this.jornadas[i];
            }

            set
            {
                this.jornadas[i] = value;
            }
        }

        #endregion Indexador

        #region Constructores

        /// <summary>
        /// Constructor completo de Universidad
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.profesores = new List<Profesor>();
            this.jornadas = new List<Jornada>();
        }

        #endregion Constructores

        #region Metodos

        /// <summary>
        /// Guarda todos los datos de una universidad en un archivo xml en la carpeta bin del proyecto
        /// </summary>
        /// <param name="uni">La universidad a guardar</param>
        /// <returns></returns>
        public static bool Guardar( Universidad uni )
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "DatosUniversidad.xml";
            Xml<Universidad> archivador = new Xml<Universidad>();

            return archivador.Guardar(path, uni);
            ;
        }

        /// <summary>
        /// Lee todos los datos de una universidad desde un archivo xml previamente guardado
        /// </summary>
        /// <returns>Un objeto universidad con los datos cargados</returns>
        public static Universidad Leer()
        {
            Universidad uni = new Universidad();
            string path = AppDomain.CurrentDomain.BaseDirectory + "DatosUniversidad.xml";
            Xml<Universidad> archivador = new Xml<Universidad>();

            archivador.Leer(path, out uni);

            return uni;
        }

        /// <summary>
        /// Devuelve un string con los datos de una universidad
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        private static string MostrarDatos( Universidad uni )
        {
            StringBuilder descripcion = new StringBuilder();
            descripcion.AppendLine("JORNADA:");

            foreach (Jornada jornada in uni.jornadas)
            {
                descripcion.AppendFormat("{0} \n", jornada.ToString());
            }

            return descripcion.ToString();
        }

        /// <summary>
        /// Hace publicos los datos de una universidad
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
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

        /// <summary>
        /// Verifica si un alumno pertenece a una universidad
        /// </summary>
        /// <param name="g">la universidad</param>
        /// <param name="a">el alumno</param>
        /// <returns></returns>
        public static bool operator ==( Universidad g, Alumno a )
        {
            if (g.alumnos.Contains(a))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Verifica si un alumno no pertenece a una universidad
        /// </summary>
        /// <param name="g">la universidad</param>
        /// <param name="a">el alumno</param>
        /// <returns></returns>
        public static bool operator !=( Universidad g, Alumno a )
        {
            if (!(g == a))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Verifica si un profesor pertenece a una universidad
        /// </summary>
        /// <param name="g">la universidad</param>
        /// <param name="i">el profesor</param>
        /// <returns></returns>
        public static bool operator ==( Universidad g, Profesor i )
        {
            if (g.profesores.Contains(i))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Verifica si un profesor no pertence a una universidad
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator !=( Universidad g, Profesor i )
        {
            if (!(g == i))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Verifica si una universidad dispone de un profesor que pueda dictar una clase determinada , y devuelve el profesor
        /// </summary>
        /// <param name="u">la universidad</param>
        /// <param name="clase">la clase a dictar</param>
        /// <returns>El profesor que puede dictar esa clase</returns>
        public static Profesor operator ==( Universidad u, EClases clase )
        {
            foreach (Profesor profesor in u.profesores)
            {
                if (profesor == clase)
                {
                    return profesor;
                }
            }

            throw new SinProfesorException("No hay profesor para la clase");
        }

        /// <summary>
        /// Verifica si una universidad dispone de un profesor que no pueda dictar una clase determinada , y devuelve el profesor
        /// </summary>
        /// <param name="u">la universidad</param>
        /// <param name="clase">la clase a dictar</param>
        /// <returns>El profesor que no puede dictar esa clase</returns>
        public static Profesor operator !=( Universidad u, EClases clase )
        {
            foreach (Profesor profesor in u.profesores)
            {
                if (profesor != clase)
                {
                    return profesor;
                }
            }

            throw new SinProfesorException("No hay profesor para la clase");
        }

        /// <summary>
        /// Crea una jornada en la universidad de la clase indicada, con un profesor y los alumnos que tomen esa clase.
        /// </summary>
        /// <param name="u">la universidad</param>
        /// <param name="clase">la clase a dictar</param>
        /// <returns>la misma universidad con la jornada ya añadida</returns>
        public static Universidad operator +( Universidad u, EClases clase )
        {
            Profesor profesor = u == clase;
            Jornada jornada = new Jornada(clase, profesor);

            foreach (Alumno alumno in u.alumnos)
            {
                if (alumno == clase)
                {
                    jornada += alumno;
                }
            }

            u.jornadas.Add(jornada);

            return u;
        }

        /// <summary>
        /// Añade un alumno a una universidad verificando que no se repita
        /// </summary>
        /// <param name="u">la universidad</param>
        /// <param name="a">el alumno</param>
        /// <returns>la universidad con el alumno añadido</returns>
        public static Universidad operator +( Universidad u, Alumno a )
        {
            if (!(u.alumnos.Contains(a)))
            {
                u.alumnos.Add(a);
                return u;
            }

            throw new AlumnoRepetidoException("Alumno repetido");
        }

        /// <summary>
        /// Añade un profesor a una universidad verificando que no se repita
        /// </summary>
        /// <param name="u">la universidad</param>
        /// <param name="a">el profesor</param>
        /// <returns>la universidad con el profesor añadido</returns>
        public static Universidad operator +( Universidad u, Profesor i )
        {
            if (!(u.profesores.Contains(i)))
            {
                u.profesores.Add(i);
            }
            return u;
        }

        #endregion Sobrecarga Operadores
    }
}