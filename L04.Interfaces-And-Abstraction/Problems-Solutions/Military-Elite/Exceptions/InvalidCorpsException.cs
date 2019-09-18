using System;

namespace Military_Elite.Exceptions
{
    public class InvalidCorpsException : Exception
    {
        public override string Message => "Invalid Corps!";
    }
}
