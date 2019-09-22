using System;
using System.Text;
using Vehicles.Contracts;
using Vehicles.Exceptions;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double distance;

        public Vehicle(double fuelQtty, double consumtion)
        {
            this.FuelQtty = fuelQtty;
            this.Consumption = consumtion;
        }

        public double FuelQtty { get; internal set; }

        public double Consumption { get; internal set; }

        public double Drive(double distance)
        {
            this.distance = distance;
            bool isEnoughFuelQtty = this.FuelQtty - this.Consumption * this.distance >= 0;

            if (!isEnoughFuelQtty)
            {
                throw new ArgumentException(String.Format(ExceptionsData.NotEnoughFuel, this.GetType().Name));
            }

            this.FuelQtty -= this.Consumption * this.distance;

            return this.FuelQtty;
        }

        public virtual double Refuel(double fuelAmount)
        {
            this.FuelQtty += fuelAmount;

            return this.FuelQtty;
        }

        public abstract double AirConditionOn();

        public abstract double AirConditionOff();

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name} travelled {this.distance} km");

            return sb.ToString().TrimEnd();
        }
    }
}
