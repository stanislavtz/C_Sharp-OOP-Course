using Food_Shortage.Contracts;

namespace Food_Shortage.Models
{
    public class Citizen : Person, IRegisterable
    {
        private const int FOOD_QUANTITY = 10;

        public Citizen(string name, int age, string id, string birthDate)
            : base(name, age)
        {
            this.Id = id;
            this.BirthDate = birthDate;
        }

        public string Id { get; }

        public override string BirthDate { get; }

        public override int FoodQuantity => FOOD_QUANTITY;
    }
}
