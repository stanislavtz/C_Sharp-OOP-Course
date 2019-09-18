using System;

namespace Military_Elite.Exceptions
{
    public class InvalidMissionStatment : Exception
    {
        public override string Message => "Invalid mission statment!";
    }
}
