using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models.Food
{
    public class Food : Product
    {
        public Food(string name, decimal price) 
            : base(name, price)
        {
        }
    }
}
