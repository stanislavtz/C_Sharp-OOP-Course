using Vehicles_Extention.Models;

namespace Vehicles_Extension.Models
{
    public class Bus : Vehicle
    {
        private const double ADDITIONAL_CONSUMTION = 1.4;

        public Bus(double fuelQtty, double consumtion, double tankCapacity) 
            : base(fuelQtty, consumtion, tankCapacity)
        {
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
