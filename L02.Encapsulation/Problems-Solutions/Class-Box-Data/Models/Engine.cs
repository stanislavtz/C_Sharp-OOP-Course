using System;
using Class_Box_Data.Contracts;

namespace Class_Box_Data.Models
{
    public class Engine : IEngine
    {
        private Box box;

        public void Run()
        {
            _ = double.TryParse(Console.ReadLine(), out double length);
            _ = double.TryParse(Console.ReadLine(), out double width);
            _ = double.TryParse(Console.ReadLine(), out double height);

            try
            {
                box = new Box(length, width, height);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (box != null)
            {
                Console.WriteLine(box);
            }
        }
    }
}
