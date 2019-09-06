using System;

namespace Person
{
    public class Engine
    {
        private Person human;

        public void Run()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            {
                human = new Person(name, age);
            }

            catch (ArgumentException ex)
            {
                try
                {
                    human = new Child(name, age);
                }
                catch (ArgumentException nex)
                {
                    if (nex.Message != ex.Message)
                    {
                        Console.WriteLine(nex.Message);
                    }
                }

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(human);
        }
    }
}
