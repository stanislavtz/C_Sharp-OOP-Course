using System;

namespace Telephony.Exceptions
{
    public class InvalidURL : Exception
    {
        public override string Message => "Invalid URL!";
    }
}
