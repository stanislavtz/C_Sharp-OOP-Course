using System;

namespace P04_Hospital.Models
{
    public abstract class Person
    {
        private string name;
        
        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => this.name; 
            private set
            {
                if (value.Length < 1 || value.Length > 19)
                {
                    throw new ArgumentException();
                }

                this.name = value;
            }
        }
    }
}
