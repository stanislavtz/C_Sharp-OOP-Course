using System;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException
                        ("Name should not be null, empthy or white space!");

                }

                if (value.Length < 3)
                {
                    throw new ArgumentException
                        ("Name length should not be less than 3 symbols!");
                }

                this.name = value;
            }
        }

        public virtual int Age
        {
            get => this.age;
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentException("Age must be positive!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
