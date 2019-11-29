using System;

namespace Excepciones
{
    public class ArchivosException: Exception
    {
        public ArchivosException( Exception inner ) : base("", inner)
        {
        }
    }
}