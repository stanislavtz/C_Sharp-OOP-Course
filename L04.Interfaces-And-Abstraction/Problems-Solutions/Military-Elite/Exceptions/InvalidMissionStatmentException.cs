using System;

namespace Military_Elite.Exceptions
{
    public class InvalidMissionStatmentException : Exception
    {
        public override string Message => "Invalid mission statment!";
    }
}
