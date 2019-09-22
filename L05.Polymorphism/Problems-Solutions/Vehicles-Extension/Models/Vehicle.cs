﻿using System;
using System.Text;
using Vehicles_Extention.Contracts;
using Vehicles_Extention.Exceptions;

namespace Vehicles_Extention.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQtty;
        private double consumtion;
        private double tankCapacity;

        private double distance;

        public Vehicle(double fuelQtty, double consumtion, double tankCapacity)
        {
            if (fuelQtty > tankCapacity)
            {
                fuelQtty = 0;
            }

            this.TankCapacity = tankCapacity;
            this.FuelQtty = fuelQtty;
            this.Consumption = consumtion;
        }

        public double TankCapacity
        {
            get => this.tankCapacity;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Tank capacity must be positive value!");
                }

                this.tankCapacity = value;
            }
        }

        public double FuelQtty
        {
            get => this.fuelQtty;
            internal set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel quantity must be null or posotive value!");
                }

                this.fuelQtty = value;
            }
        }

        public double Consumption
        {
            get => this.consumtion;
            internal set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Consumption must be positive value");
                }

                this.consumtion = value;
            }
        }

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
            if (fuelAmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            bool canRefuel = this.FuelQtty + fuelAmount <= this.TankCapacity;

            if (!canRefuel)
            {
                throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
            }

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