using System;

namespace NeedForSpeed.Models
{
    public abstract class Vehicle
    {
        private const double DFAULT_FUEL_CONSUMPTION = 1.25;
        public const double DISTANCE = 100;

        private int horsePower;
        private double fuel;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public int HorsePower
        {
            get => this.horsePower;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The horse power must be a positive value!");
                }

                this.horsePower = value;
            }
        }

        public double Fuel
        {
            get => this.fuel;
            internal set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The fuel must not be a negative value");
                }
                this.fuel = value;
            }
        }

        // public virtual double FuelConsumption => DefaultFuelConsumption;

        public virtual void Drive()
        {
            bool canDrive = this.Fuel - DFAULT_FUEL_CONSUMPTION * DISTANCE / 100  >= 0;

            if (!canDrive)
            {
                throw new ArgumentException("Not enought fuel in tank!");
            }

            this.Fuel -=  DISTANCE * DFAULT_FUEL_CONSUMPTION / 100;
        }
    }
}
