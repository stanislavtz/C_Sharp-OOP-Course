using System;

namespace NeedForSpeed.Models
{
    public abstract class Vehicle
    {
        private const double DFAULT_FUEL_CONSUMPTION = 1.25;

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
                    throw new ArgumentException("Horse power must be positive integer number value!");
                }

                this.horsePower = value;
            }
        }

        public double Fuel
        {
            get => this.fuel;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fueal can not be negative value!");
                }
                this.fuel = value;
            }
        }

        public virtual double FuelConsumption => DFAULT_FUEL_CONSUMPTION;

        public virtual void Drive(double distance)
        {
            var neededFuel = distance * this.FuelConsumption / 100;
            bool canDrive = this.Fuel - neededFuel >= 0;

            if (canDrive)
            {
                this.Fuel -= neededFuel / 100;
            }
        }

        public override string ToString()
        {
            return $"This vehicle is {this.GetType().Name} with fuel consuption: {this.FuelConsumption:f1} l/100 km";
        }
    }
}
