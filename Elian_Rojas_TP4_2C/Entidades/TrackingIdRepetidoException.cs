using System;

namespace Entidades
{
    public class TrackingIdRepetidoException: Exception
    {
        public TrackingIdRepetidoException()
        {
        }

        public TrackingIdRepetidoException( string message ) : base(message)
        {
        }

        public TrackingIdRepetidoException( string message, Exception inner ) : base(message, inner)
        {
        }
    }
}