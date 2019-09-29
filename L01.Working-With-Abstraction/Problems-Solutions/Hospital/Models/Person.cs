using System;

namespace P04_Hospital.Models
{
    public abstract class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
       
    }
}
