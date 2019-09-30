
using System;
using System.Runtime.Serialization;

namespace DatingApp.API.Exceptions
{
    public class LoginDatingAppException : DatingAppException
    {
        public LoginDatingAppException()
        {
        }

        public LoginDatingAppException(string message) : base(message)
        {
        }

        public LoginDatingAppException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LoginDatingAppException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}