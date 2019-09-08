using System;

namespace Person
{
    public class Child : Person
    {
        private const int MAX_AGES = 15;

        public Child(string name, int age)
            : base(name, age)
        {
        }

        public override int Age
        {
            get => base.Age;
            set
            {
                if (value > MAX_AGES)
                {
                    throw new ArgumentException($"Child's age must be less than {MAX_AGES}!");
                }

                base.Age = value;
            }
        }
    }
}
