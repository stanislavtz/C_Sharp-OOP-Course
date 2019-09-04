using Football_Team_Generator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Team_Generator.Core
{
    public class Engine
    {
        public void Run()
        {
            string input = Console.ReadLine();

            try
            {
                Stat stat = new Stat("asd", int.Parse(input));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
