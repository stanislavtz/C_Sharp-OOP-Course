using System;

namespace Wild_Farm.Exceptions
{
    public class InvalidWeightException : Exception
    {
        public override string Message => "Animal weight must be a positive value!";
    }
}
