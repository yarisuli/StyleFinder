using System;
using System.Runtime.Serialization;

namespace App_Ropa___Intento_1
{
    [Serializable]
    internal class InvalidAppException : Exception
    {
        public InvalidAppException()
        {
        }

        public InvalidAppException(string message) : base(message)
        {
        }

        public InvalidAppException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidAppException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}