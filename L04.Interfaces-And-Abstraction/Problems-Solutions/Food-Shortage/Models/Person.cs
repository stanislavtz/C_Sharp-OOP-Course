﻿using Food_Shortage.Contracts;

namespace Food_Shortage.Models
{
    public abstract class Person : IBirthable, INameable
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; }

        public int Age { get; }

        public virtual string BirthDate { get; }

        public virtual int FoodQuantity { get; }

        public int BoughtFood { get; private set; }

        public int FoodCounter()
        {
            this.BoughtFood += this.FoodQuantity;

            return this.BoughtFood;
        }
    }
}
