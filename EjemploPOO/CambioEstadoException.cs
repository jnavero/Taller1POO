using System;
using System.Runtime.Serialization;

namespace EjemploPOO
{
    [Serializable]
    internal class CambioEstadoException : Exception
    {
        public CambioEstadoException()
        {
        }

        public CambioEstadoException(string message) : base(message)
        {
        }

        public CambioEstadoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CambioEstadoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}