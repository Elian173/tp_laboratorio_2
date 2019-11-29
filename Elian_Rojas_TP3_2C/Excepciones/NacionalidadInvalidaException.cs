using System;

namespace Excepciones
{
    public class NacionalidadInvalidaException: Exception
    {
        public NacionalidadInvalidaException( string message ) : base(message)
        {
        }

        public NacionalidadInvalidaException() : this("")
        {
        }
    }
}