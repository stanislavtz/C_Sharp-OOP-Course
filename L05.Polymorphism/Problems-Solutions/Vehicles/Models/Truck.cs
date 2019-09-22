﻿namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double FUEL_LOSSING_COEFFICIENT = 0.95;
        private const double ADDITIONAL_CONSUMTION = 1.6;

        public Truck(double fuelQtty, double consumtion) 
            : base(fuelQtty, consumtion)
        {
            
        }

        public override double Refuel(double fuelAmount)
        {
            return base.Refuel(fuelAmount * FUEL_LOSSING_COEFFICIENT);
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
