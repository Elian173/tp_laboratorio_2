using Excepciones;
using System;
using System.Text;

/*Clase Persona:
 Abstracta, con los atributos Nombre, Apellido, Nacionalidad y DNI.
 Se deberá validar que el DNI sea correcto, teniendo en cuenta su nacionalidad. Argentino entre 1 y 89999999 y Extranjero entre 90000000 y 99999999. Caso contrario, se lanzará la excepción NacionalidadInvalidaException.
 Si el DNI presenta un error de formato (más caracteres de los permitidos, letras, etc.) se lanzará DniInvalidoException.
 Sólo se realizarán las validaciones dentro de las propiedades.
 Validará que los nombres sean cadenas con caracteres válidos para nombres. Caso contrario, no se cargará.
 ToString retornará los datos de la Persona.*/

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino, Extranjero
        }

        #region Atributos

        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;

        #endregion Atributos

        #region Constructores

        public Persona()
        {
        }

        /// <summary>
        /// Constructor basico clase persona , con validaciones mediante propiedades
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona( string nombre, string apellido, ENacionalidad nacionalidad )
        {
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Constructor completo clase persona con dni formato entero , validado mediante propiedades
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona( string nombre, string apellido, int dni, ENacionalidad nacionalidad ) : this(nombre, apellido, nacionalidad)
        {
            DNI = dni;
        }

        /// <summary>
        /// Constructor completo clase persona con dni formato String, validado mediante propiedades
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona( string nombre, string apellido, string dni, ENacionalidad nacionalidad ) : this(nombre, apellido, nacionalidad)
        {
            StringToDNI = dni;
        }

        #endregion Constructores

        #region Propiedades

        /// <summary>
        /// Accede al atributo apellido , al asignar verifica que sea un apellido valido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Accede al atributo dni (formato entero), al asignar verifica que sea un dni valido
        /// </summary>
        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }

        /// <summary>
        /// Accede al atributo nacionalidad
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        /// <summary>
        /// Accede al atributo nombre , al asignar verifica que sea un nombre valido
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Accede al atributo dni (formato string), al asignar verifica que sea un dni valido.
        /// </summary>
        public string StringToDNI
        {
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }

        #endregion Propiedades

        #region Metodos

        /// <summary>
        /// Hace publicos los datos de la persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder descripcion = new StringBuilder();

            descripcion.AppendFormat("NOMBRE COMPLETO: {0}, {1} \n", this.Apellido, this.Nombre);
            descripcion.AppendFormat("NACIONALIDAD: {0} \n", this.Nacionalidad); // $no pongo el dni porque en el ej del pdf no sale

            return descripcion.ToString();
        }

        /// <summary>
        /// Valida que un dni asignado concuerde con la nacionalidad de la persona , caso contrario arroja una excepcion
        /// </summary>
        /// <param name="nacionalidad">nacionalidad de la persona</param>
        /// <param name="dato">el dni</param>
        /// <returns></returns>
        private int ValidarDni( ENacionalidad nacionalidad, int dato )
        {
            bool esValido = false;

            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:

                if (dato >= 1 && dato <= 89999999)
                {
                    esValido = true;
                }
                break;

                case ENacionalidad.Extranjero:

                if (dato >= 90000000 && dato <= 99999999)
                {
                    esValido = true;
                }
                break;

                default:
                break;
            }

            if (!(esValido))
            {
                throw new NacionalidadInvalidaException("La nacionalidad no se condice con el numero de dni");
            }

            return dato;
        }

        /// <summary>
        /// Valida que un string tenga formato de un dni , y que este ademas coincida con la nacionalidad de la persona.
        /// </summary>
        /// <param name="nacionalidad">nacionalidad de la persona</param>
        /// <param name="dato">el dni</param>
        /// <returns></returns>
        private int ValidarDni( ENacionalidad nacionalidad, string dato )
        {
            if (string.IsNullOrEmpty(dato))
            {
                throw new DniInvalidoException();
            }

            if (dato.Length <= 8)
            {
                foreach (char c in dato)
                {
                    if (c < '0' || c > '9')
                    {
                        throw new DniInvalidoException();
                    }
                }
            }

            return ValidarDni(nacionalidad, Convert.ToInt32(dato));
            //Si bien dice que las validaciones son solo en las propiedades, asumo que puedo usar
            //esta aca , porque sino no sabria para que recibe el parametro "nacionalidad" , sino habria hecho en la propiedad StringToDNI -> DNI = ValidarDni(nac,value);
            //o reescrito el otro metodo dentro de este
        }

        /// <summary>
        /// Valida que un string sea del formato de un nombre, no sean caracteres vacios , null , o mayor a 25 caracteres , caso contrario arroja una excepcion
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido( string dato )
        {
            bool esValido = true;

            try
            {
                if (string.IsNullOrWhiteSpace(dato))
                {
                    esValido = false;
                }

                if (dato.Length <= 25 && esValido)
                {
                    foreach (char c in dato)
                    {
                        if (!Char.IsLetter(c) && c != ' ')
                        {
                            esValido = false;
                        }
                    }
                }
                else
                {
                    esValido = false;
                }
            }
            catch (NullReferenceException)
            {
                esValido = false;
            }

            if (!(esValido))
            {
                return string.Empty;
            }

            return dato;
        }

        #endregion Metodos
    }
}