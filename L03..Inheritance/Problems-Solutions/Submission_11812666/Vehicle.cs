namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DEFAULT_FUEL_CONSUPTION = 1.25d;

        public Vehicle(double fuel, int horsePower)
        {
            this.Fuel = fuel;
            this.HorsePower = horsePower;
        }

        public double Fuel { get; set; }

        public int HorsePower { get; set; }

        public virtual double FuelConsumption => DEFAULT_FUEL_CONSUPTION;

        public virtual void Drive(double kilometers)
        {
            var neededFuel = this.FuelConsumption * kilometers;

            bool isEnoughFuel = this.Fuel - neededFuel >= 0;

            if (isEnoughFuel)
            {
                this.Fuel -= neededFuel;
            }
        }
    }
}
