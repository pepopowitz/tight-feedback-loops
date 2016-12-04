using System;
using System.Runtime.Serialization;

namespace Calculator
{
    [Serializable]
    internal class MathException : Exception
    {
        public MathException()
        {
        }

        public MathException(string message) : base(message)
        {
        }

        public MathException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MathException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}