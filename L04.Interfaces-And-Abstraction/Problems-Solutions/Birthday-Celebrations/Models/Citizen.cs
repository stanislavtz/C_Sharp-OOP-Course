using Birthday_Celebrations.Contracts;

namespace Birthday_Celebrations.Models
{
    public class Citizen : IRegisterable, INameable, IBirthable
    {
        private readonly string name;
        private readonly string birthDate;
        private readonly int age;
        private readonly string id;

        public Citizen(string name, int age, string id, string birthDate)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.birthDate = birthDate;
        }

        public string Name => name;

        public string Id => this.id;

        public int Age => this.age;

        public string BirthDate => this.birthDate;
    }
}
