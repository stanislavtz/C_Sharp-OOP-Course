namespace Wild_Farm.Models.Animals.Mammall
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, double weight, int foodEaten, string livingRegion) 
            : base(name, weight, foodEaten)
        {
            this.LivingRegion = livingRegion;
        }

        public string  LivingRegion { get; private set; }
    }
}
