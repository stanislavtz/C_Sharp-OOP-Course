using System;

namespace Wild_Farm.Exceptions
{
   public class InvalidFoodQuantityException : Exception
    {
        public override string Message => "Food quntity must be a positive value!";
    }
}
