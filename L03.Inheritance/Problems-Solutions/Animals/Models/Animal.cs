using Animals.Models.Contracts;
using System;
using System.Text;

namespace Animals.Models
{
    public abstract class Animal : ISoundProducable
    {
        private string name;
        private int age;
        private string gender;

        protected Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }

        public string Gender
        {
            get => this.gender;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            throw null;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.AppendLine(this.ProduceSound());

            return sb.ToString().TrimEnd();
        }
    }
}
