using System;

namespace Class_Box_Data.Validators
{
    public class ValidateValue
    {
        public double Validator(string side, double valueToValidate)
        {
            if (valueToValidate <= 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");
            }

            return valueToValidate;
        }
    }
}
