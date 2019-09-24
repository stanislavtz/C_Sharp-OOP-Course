using System;

namespace Wild_Farm.Exceptions
{
    class InvalidWingSizeException : Exception
    {
        public override string Message => "Wing size must be a positive value;";
    }
}
