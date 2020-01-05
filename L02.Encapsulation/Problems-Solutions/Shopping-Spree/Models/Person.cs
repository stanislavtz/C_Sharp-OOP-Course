using System;
using System.Linq;
using System.Collections.Generic;

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
                    throw new ArgumentException("Name cannot be empty");
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
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public void BuyProduct(Product product)
        {
            bool canAfford = this.Money - product.Cost >= 0;

            if (canAfford)
            {
                this.Money -= product.Cost;

                this.shoppingBag.Add(product);

                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            if (this.shoppingBag.Count > 0)
            {
                return $"{this.Name} - " + string.Join(", ", this.shoppingBag.Select(x => x.Name));
            }

            return $"{this.Name} - Nothing bought";
        }
    }
}
