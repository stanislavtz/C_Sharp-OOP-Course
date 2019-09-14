using System;

namespace Telephony.Exceptions
{
    public class InvalidNumber : Exception
    {
        public override string Message => "Invalid number!";
    }
}
