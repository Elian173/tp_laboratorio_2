using System;

namespace Excepciones
{
    public class SinProfesorException: Exception
    {
        public SinProfesorException( string mensaje ) : base(mensaje)
        {
        }
    }
}