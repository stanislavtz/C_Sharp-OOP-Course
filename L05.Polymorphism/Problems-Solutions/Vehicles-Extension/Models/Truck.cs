using Vehicles_Extension.Validators;

namespace Vehicles_Extension.Models
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
            RefuelValidator fv = new RefuelValidator(fuelAmount, this.FuelQtty, this.TankCapacity);

            this.FuelQtty += fv.FuelAmount * FUEL_LOSSING_COEFFICIENT;

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
