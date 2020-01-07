using Ferrari.Contracts;
using System;

namespace Ferrari.Models
{
    public class Driver : IDriver
    {
        private string name;

        public Driver(string name)
        {
            this.Name = name;
        }

        public string Name 
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Invalid driver name!");
                }

                this.name = value;
            }
        }
    }
}
