using System;
using Vehicles_Extention.Exceptions;

namespace Vehicles_Extension.Validators
{
    public class RefuelValidator
    {
        private double fuelAmount;
        private readonly double fuelQtty;
        private readonly double tankCapacity;

        public RefuelValidator(double fuelAmount, double fuelQtty, double tankCapacity)
        {
            this.fuelQtty = fuelQtty;
            this.tankCapacity = tankCapacity;
            this.FuelAmount = fuelAmount;
        }

        public double FuelAmount
        {
            get => this.fuelAmount;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionsData.NegativeRefuelQuantity);
                }

                bool canRefuel = this.fuelQtty + value <= this.tankCapacity;

                if (!canRefuel)
                {
                    throw new ArgumentException(string.Format(ExceptionsData.HighRefuelAmount, value));
                }

                this.fuelAmount = value;
            }
        }
    }
}
