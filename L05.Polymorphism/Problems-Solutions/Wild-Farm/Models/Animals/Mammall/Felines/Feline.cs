namespace Wild_Farm.Models.Animals.Mammall.Felines
{
    public abstract class Feline : Mammal
    {
        public Feline(string name, double weight, int foodEaten, string livingRegion, string breed) 
            : base(name, weight, foodEaten, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; private set; }

        public override string ToString()
        {
            return $"{base.ToString()} {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
