using System;
using Ferrari.Contracts;
using Ferrari.Models;

namespace Ferrari.Core
{
    public class Engine : IEngine
    {
        private IDriver driver;

        public void Run()
        {
            string name = Console.ReadLine();

            try
            {
                this.driver = new Driver(name);
                
                IDriveable car = new Ferrari(this.driver);

                Console.WriteLine(car);
            }
            catch (NullReferenceException ne)
            {
                Console.WriteLine(ne.Message); 
            }
        }
    }
}
