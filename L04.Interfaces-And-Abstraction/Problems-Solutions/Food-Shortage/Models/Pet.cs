using Food_Shortage.Contracts;

namespace Food_Shortage.Models
{
    public class Pet : INameable, IBirthable
    {
        private const int AGE = 1;

        private readonly string name;
        private readonly string birthDate;

        public Pet(string name, string birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }

        public string Name => this.name;

        public string BirthDate => this.birthDate;

        public int Age => AGE;
    }
}
