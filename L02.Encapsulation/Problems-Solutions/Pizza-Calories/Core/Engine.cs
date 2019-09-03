using System;
using Pizza_Calories.Models;
using Pizza_Calories.Core.Contracts;

namespace Pizza_Calories.Core
{
    public class Engine : IEngine
    {
        private Pizza pizza;
        private Dough dough;

        public void Run()
        {
            string[] pizzaArgs = Console.ReadLine().Split();
            string pizzaName = pizzaArgs[1];

            string[] doughArgs = Console.ReadLine().Split();
            string doughType = doughArgs[1];
            string backingTechnique = doughArgs[2];
            double doughWeight = double.Parse(doughArgs[3]);

            try
            {
                this.dough = new Dough(doughType, backingTechnique, doughWeight);

                this.pizza = new Pizza(pizzaName, dough);

                string input = Console.ReadLine();

                while (input != "END")
                {
                    string[] args = input
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    var type = args[1];
                    var weight = double.Parse(args[2]);

                    Topping topping = new Topping(type, weight);

                    pizza.AddTopping(topping);

                    input = Console.ReadLine();
                }

                Console.WriteLine($"{this.pizza.Name} - {this.pizza.GetTotalCalories():f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
