namespace Vehicles_Extention.Models
{
    public class Car : Vehicle
    {
        private const double ADDITIONAL_CONSUMTION = 0.9;

        public Car(double fuelQtty, double consumtion, double tankCapacity) 
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
