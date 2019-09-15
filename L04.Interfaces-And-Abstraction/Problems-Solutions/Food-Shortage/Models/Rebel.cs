namespace Food_Shortage.Models
{
    class Rebel : Person
    {
        private const int FOOD_QUANTITY = 5;

        public Rebel(string name, int age, string group)
            : base(name, age)
        {
            this.Group = group;
        }

        public string Group { get; }

        public override int FoodQuantity => FOOD_QUANTITY;
    }
}
