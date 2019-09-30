using System;
using System.Runtime.Serialization;

namespace DatingApp.API.Exceptions
{
    public class DatingAppException : Exception
    {
        public DatingAppException()
        {
        }

        public DatingAppException(string message) : base(message)
        {
        }

        public DatingAppException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DatingAppException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}