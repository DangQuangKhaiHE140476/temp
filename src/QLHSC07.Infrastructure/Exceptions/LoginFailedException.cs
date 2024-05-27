using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Infrastructure.Exceptions
{
    public class LoginFailedException : Exception
    {
        public string OverrideMessage { get; }
        public LoginFailedException(string message) : base(message)
        {
            OverrideMessage = message;
        }
        public string Code { get; }

        public LoginFailedException(string message, params object[] args)
            : this(string.Empty, message, args)
        {
        }
        public LoginFailedException(string code, string message, params object[] args)
            : this(null, code, message, args)
        {
        }
        public LoginFailedException(Exception innerException, string message, params object[] args)
            : this(innerException, string.Empty, message, args)
        {
        }
        public LoginFailedException(Exception innerException, string code, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            Code = code;
        }
    }
}