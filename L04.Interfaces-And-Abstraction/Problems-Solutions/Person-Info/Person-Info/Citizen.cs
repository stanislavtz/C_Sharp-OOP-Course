namespace PersonInfo
{
    using System.Text;

    public class Citizen : IPerson
    {
        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; }

        public int Age { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(this.Name);
            sb.AppendLine($"{this.Age}");

            return sb.ToString().TrimEnd(); 
        }
    }
}