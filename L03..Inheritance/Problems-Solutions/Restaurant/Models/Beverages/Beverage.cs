using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models.Beverages
{
    public class Beverage : Product
    {
        public Beverage(string name, decimal price) 
            : base(name, price)
        {
        }
    }
}
