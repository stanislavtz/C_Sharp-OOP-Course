namespace P01_RawData.Models
{
    public class CarEngine
    {
        public CarEngine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        public int Speed { get; private set; }
        
        public int Power { get; private set; }
    }
}
