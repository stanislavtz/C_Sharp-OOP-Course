﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories.Models.Toppings.Types
{
    public class Meat : Topping
    {
        public Meat(string type, double weight) 
            : base(type, weight)
        {
        }
    }
}
