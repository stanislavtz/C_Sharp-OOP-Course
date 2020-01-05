using System;
using Shopping_Spree.Exceptions;

namespace Shopping_Spree.Models
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    var message = ExceptionsMessages.NullOrEmptyNameException;

                    throw new ArgumentException(message);
                }

                this.name = value;
            }
        }

        public decimal Cost
        {
            get => this.cost;
            private set
            {
                if (value < 0)
                {
                    var message = ExceptionsMessages.NullOrNegativeValuException;

                    throw new ArgumentException(message);
                }

                this.cost = value;
            }
        }
    }
}
