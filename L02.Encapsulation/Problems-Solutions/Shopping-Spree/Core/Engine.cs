using System;
using System.Linq;
using Shopping_Spree.Models;
using Shopping_Spree.Contracts;
using System.Collections.Generic;

namespace Shopping_Spree.Core
{
    public class Engine : IEngine
    {
        private readonly List<Person> people = new List<Person>();
        private readonly List<Product> products = new List<Product>();

        private Person person;
        private Product product;

        public void Run()
        {
            try
            {
                InitializePeopleInfo();
                InitializeProductsInfo();
            }
            catch (ArgumentException ea)
            {
                Console.WriteLine(ea.Message);
                return;
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    string[] args = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string personName = args[0];
                    string productName = args[1];

                    var currentPerson = this.people
                        .FirstOrDefault(p => p.Name == personName);

                    var currentProduct = this.products
                        .FirstOrDefault(p => p.Name == productName);

                    if (currentPerson != null && currentProduct != null)
                    {
                        currentPerson.BuyProduct(currentProduct);

                        Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }

        private void InitializePeopleInfo()
        {
            string[] peopleArgs = Console.ReadLine()
                .Split(";");

            foreach (var person in peopleArgs)
            {
                string[] personArgs = person.Split("=");

                string name = personArgs[0];
                decimal money = decimal.Parse(personArgs[1]);

                this.person = new Person(name, money);

                this.people.Add(this.person);
            }
        }

        private void InitializeProductsInfo()
        {
            string[] productsArgs = Console.ReadLine()
                                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var product in productsArgs)
            {
                string[] productArgs = product.Split("=");

                string name = productArgs[0];
                decimal cost = decimal.Parse(productArgs[1]);

                this.product = new Product(name, cost);

                this.products.Add(this.product);
            }
        }
    }
}