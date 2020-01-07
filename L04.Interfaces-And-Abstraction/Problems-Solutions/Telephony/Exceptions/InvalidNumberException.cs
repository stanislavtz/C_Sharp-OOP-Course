using System;

namespace Telephony.Exceptions
{
    public class InvalidNumberException : Exception
    {
        public const string EXCEPTION_MESSAGE = "Invalid number!";

        public InvalidNumberException() 
            : base(EXCEPTION_MESSAGE)
        {
        }
    }
}
