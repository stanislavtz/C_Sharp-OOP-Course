using System;
using Vehicles_Extention.Exceptions;

namespace Vehicles_Extention.Models
{
    public class Truck : Vehicle
    {
        private const double FUEL_LOSSING_COEFFICIENT = 0.95;
        private const double ADDITIONAL_CONSUMTION = 1.6;

        public Truck(double fuelQtty, double consumtion, double tankCapacity) 
            : base(fuelQtty, consumtion, tankCapacity)
        {
        }

        public override double Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException(ExceptionsData.NegativeRefuelQuantity);
            }

            bool canRefuel = this.FuelQtty + fuelAmount * FUEL_LOSSING_COEFFICIENT <= this.TankCapacity;

            if (!canRefuel)
            {
                throw new ArgumentException(string.Format(ExceptionsData.HighRefuelAmount, fuelAmount));
            }

            this.FuelQtty += fuelAmount * FUEL_LOSSING_COEFFICIENT;

            return this.FuelQtty;
        }

        public override double AirConditionOn()
        {
            this.Consumption += ADDITIONAL_CONSUMTION;

            return this.Consumption;
        }

        public override double AirConditionOff()
        {
            this.Consumption -= ADDITIONAL_CONSUMTION;

            return this.Consumption;
        }
    }
}
