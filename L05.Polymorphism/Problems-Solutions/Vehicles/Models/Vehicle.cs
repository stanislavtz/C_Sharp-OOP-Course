using System;
using System.Text;
using Vehicles.Contracts;
using Vehicles.Exceptions;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        private readonly double tankSize;
        private double distance;

        public Vehicle(double fuelQty, double consumtion)
        {
            this.FuelQtty = fuelQty;
            this.Consumption = consumtion;
            this.tankSize = fuelQty;
        }

        public double FuelQtty { get; internal set; }

        public double Consumption { get; internal set; }

        public abstract double AirConditionOn();

        public abstract double AirConditionOff();

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
            //bool canRefuel = this.FuelQtty + fuelAmount <= tankSize;

            //if (!canRefuel)
            //{
            //    return this.FuelQtty;
            //    //throw new ArgumentException();
            //}

            this.FuelQtty += fuelAmount;

            return this.FuelQtty;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name} travelled {this.distance} km");

            return sb.ToString().TrimEnd();
        }
    }
}
