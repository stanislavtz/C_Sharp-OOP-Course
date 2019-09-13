using System;

namespace Ferrari
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            var car = new Ferrari(name);

            Console.WriteLine(car);
        }
    }
}
