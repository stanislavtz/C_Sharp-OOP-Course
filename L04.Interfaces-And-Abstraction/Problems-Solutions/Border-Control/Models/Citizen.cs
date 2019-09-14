using Border_Control.Contracts;

namespace Border_Control.Models
{
    public class Citizen : IRegisterable
    {
        private readonly string name;
        private readonly int age;
        private readonly string id;

        public Citizen(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }

        public string NameOrModel => this.name;

        public string Id => this.id;

        public int Age => this.age;
    }
}
