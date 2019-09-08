namespace NeedForSpeed.Models.Motors
{
    public abstract class Motorcycle : Vehicle
    {
        public Motorcycle(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
        }
    }
}
