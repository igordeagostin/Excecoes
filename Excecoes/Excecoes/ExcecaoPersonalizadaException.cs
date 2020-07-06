using System;

namespace Excecoes
{
    public class ExcecaoPersonalizadaException : Exception
    {
        public ExcecaoPersonalizadaException()
        { }

        public ExcecaoPersonalizadaException(string message)
            : base(message)
        { }

        public ExcecaoPersonalizadaException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
