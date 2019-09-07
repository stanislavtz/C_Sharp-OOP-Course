using System;

namespace NeedForSpeed.Models.Motors
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double DFAULT_FUEL_CONSUMPTION = 8;

        public RaceMotorcycle(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
        }

        public override void Drive()
        {
            bool canDrive = this.Fuel - DISTANCE * DFAULT_FUEL_CONSUMPTION  / 100 >= 0;

            if (!canDrive)
            {
                throw new ArgumentException("Not enought fuel in tank!");
            }

            this.Fuel -= DISTANCE * DFAULT_FUEL_CONSUMPTION / 100;
        }
    }
}
