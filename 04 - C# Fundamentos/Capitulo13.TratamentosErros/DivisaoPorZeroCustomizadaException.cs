using System.Runtime.Serialization;

namespace Capitulo13.TratamentosErros
{
    [Serializable]
    internal class DivisaoPorZeroCustomizadaException : Exception
    {
        public DivisaoPorZeroCustomizadaException()
        {
        }

        public DivisaoPorZeroCustomizadaException(string? message) : base(message)
        {
        }

        public DivisaoPorZeroCustomizadaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DivisaoPorZeroCustomizadaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}