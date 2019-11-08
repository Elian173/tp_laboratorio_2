using System;

namespace Excepciones
{
    public class AlumnoRepetidoException: Exception
    {
        public AlumnoRepetidoException( string mensaje ) : base(mensaje)
        {
        }
    }
}