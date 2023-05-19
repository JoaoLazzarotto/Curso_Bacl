using System.Runtime.Serialization;

namespace ConsoleApp1
{
    [Serializable]
    internal class ValorMuitoAltoException : Exception
    {
        public ValorMuitoAltoException()
        {
        }

        public ValorMuitoAltoException(string? message) : base(message)
        {
        }

        public ValorMuitoAltoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ValorMuitoAltoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}