namespace NeedForSpeed.Motorcycles
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(double fuel, int horsePower) :
            base(fuel, horsePower)
        {
                
        }

        public double FuelConsumption => 8;
    }
}
