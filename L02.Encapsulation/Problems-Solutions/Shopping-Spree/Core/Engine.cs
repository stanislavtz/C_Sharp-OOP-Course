using System;
using System.Linq;
using Shopping_Spree.Models;
using Shopping_Spree.Contracts;
using System.Collections.Generic;

namespace Shopping_Spree.Core
{
    public class Engine : IEngine
    {
        private readonly List<Person> persons = new List<Person>();
        private readonly List<Product> products = new List<Product>();

        private Person person;
        private Product product;

        public void Run()
        {
            string[] inputPeopleInfo = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            string[] inputProductsInfo = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var input in inputPeopleInfo)
            {
                string[] args = input
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    person = new Person(args[0], decimal.Parse(args[1]));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                persons.Add(person);
            }

            foreach (var input in inputProductsInfo)
            {
                string[] args = input
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    product = new Product(args[0], decimal.Parse(args[1]));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                products.Add(product);
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string personName = command.Split()[0];
                string productName = command.Split()[1];

                var currentPerson = persons.FirstOrDefault(p => p.Name == personName);

                if (currentPerson != null)
                {
                    var currentProduct = products.FirstOrDefault(p => p.Name == productName);

                    if (currentProduct != null)
                    {
                        currentPerson.BuyProduct(currentProduct);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
