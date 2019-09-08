using System;

namespace Zoo
{
    public class Animal
    {
        private string name;

        public Animal(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name lengh, must be at least 3 symbols!");
                }

                this.name = value;
            }
        }
    }
}
