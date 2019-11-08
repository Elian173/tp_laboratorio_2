using System;

namespace Excepciones
{
    public class DniInvalidoException: Exception
    {
        private string mensajeBase; // No entiendo muy bien el uso que se pretende de este atributo.

        public DniInvalidoException( string mensaje, Exception innerException ) : base(mensaje, innerException)
        {
            this.mensajeBase = mensaje;
        }

        public DniInvalidoException( string mensaje ) : this(mensaje, null)
        {
        }

        public DniInvalidoException( Exception inner ) : this("", inner)
        {
        }

        public DniInvalidoException() : this("", null)
        {
        }
    }
}