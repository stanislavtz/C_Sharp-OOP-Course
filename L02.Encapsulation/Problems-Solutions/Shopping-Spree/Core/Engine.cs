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
            string[] inputPeopleInfo = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            string[] inputProductsInfo = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var person in inputPeopleInfo)
            {
                string[] args = person
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = args[0];
                decimal money = decimal.Parse(args[1]);

                try
                {
                    this.person = new Person(name, money);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                this.people.Add(this.person);
            }

            foreach (var product in inputProductsInfo)
            {
                string[] args = product
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = args[0];
                decimal cost = decimal.Parse(args[1]);

                try
                {
                    this.product = new Product(name, cost);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                this.products.Add(this.product);
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string personName = command.Split()[0];
                string productName = command.Split()[1];

                var currentPerson = this.people.FirstOrDefault(p => p.Name == personName);

                if (currentPerson != null)
                {
                    var currentProduct = this.products.FirstOrDefault(p => p.Name == productName);

                    if (currentProduct != null)
                    {
                        currentPerson.BuyProduct(currentProduct);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
