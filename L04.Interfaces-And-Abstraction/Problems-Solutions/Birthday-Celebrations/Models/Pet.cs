using Birthday_Celebrations.Contracts;

namespace Birthday_Celebrations.Models
{
    public class Pet : INameable, IBirthable
    {
        private readonly string name;
        private readonly string birthDate;

        public Pet(string name, string birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }

        public string Name => this.name;

        public string BirthDate => this.birthDate;
    }
}
