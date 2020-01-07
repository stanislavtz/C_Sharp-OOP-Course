using System;

namespace Telephony.Exceptions
{
    public class InvalidURLException : Exception
    {
        public override string Message => "Invalid URL!";
    }
}
