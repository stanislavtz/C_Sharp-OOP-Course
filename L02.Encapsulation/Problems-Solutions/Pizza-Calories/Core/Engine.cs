using Pizza_Calories.Core.Contracts;
using Pizza_Calories.Models;
using System;
using System.Collections.Generic;

namespace Pizza_Calories.Core
{
    public class Engine : IEngine
    {
        private readonly IList<Topping> toppings;
        private double callories;
        private Pizza pizza;
        private bool IsExceptionAvailable;

        public Engine()
        {
            this.toppings = new List<Topping>();
        }
        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                IsExceptionAvailable = false;

                string[] args = input
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (args[0] == "Pizza")
                {
                    var name = args[1];

                    try
                    {
                        pizza = new Pizza(name);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        IsExceptionAvailable = true;
                        break;
                    }
                }
                else if (args[0] == "Dough")
                {
                    var mainType = args[1];
                    var additionalType = args[2];
                    var weight = double.Parse(args[3]);

                    try
                    {
                        var dought = new Dough(mainType, additionalType, weight);
                        callories += dought.ClculateCalories();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        IsExceptionAvailable = true;
                        break;
                    }

                }
                else if (args[0] == "Topping")
                {
                    var type = args[1];
                    var weight = double.Parse(args[2]);

                    try
                    {
                        var topping = new Topping(type, weight);

                        if (toppings.Count > 10)
                        {
                            IsExceptionAvailable = true;
                            throw new ArgumentException("Number of toppings should be in range [0..10].");
                        }

                        toppings.Add(topping);
                        callories += topping.CalculateCalories();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        IsExceptionAvailable = true;
                        break;
                    }
                }

                input = Console.ReadLine();
            }

            if (!IsExceptionAvailable)
            {
                Console.WriteLine($"{this.pizza.Name} - {this.callories:f2} Calories.");
            }
        }
    }
}
