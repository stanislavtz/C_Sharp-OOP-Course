using System;
using System.Linq;
using System.Collections.Generic;
using Shopping_Spree.Exceptions;

namespace Shopping_Spree.Models
{
    public class Person
    {
        private string name;
        private decimal money;
        private readonly List<Product> shoppingBag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.shoppingBag = new List<Product>();
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

        public decimal Money
        {
            get => this.money;
            private set
            {
                if (value < 0)
                {
                    var message = ExceptionsMessages.NullOrNegativeValuException;

                    throw new ArgumentException(message);
                }

                this.money = value;
            }
        }

        public void BuyProduct(Product product)
        {
            bool canAfford = this.Money >=  product.Cost;

            if (!canAfford)
            {
                throw new InvalidOperationException(
                      string.Format(ExceptionsMessages.CanNotAffordProductException, this.Name, product.Name));
            }
           
            this.Money -= product.Cost;

            this.shoppingBag.Add(product);
        }

        public override string ToString()
        {
            if (this.shoppingBag.Count > 0)
            {
                return $"{this.Name} - " + string.Join(", ", this.shoppingBag);
            }

            return $"{this.Name} - Nothing bought";
        }
    }
}
