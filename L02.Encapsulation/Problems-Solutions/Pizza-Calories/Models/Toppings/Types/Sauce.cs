﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories.Models.Toppings.Types
{
    public class Sauce : Topping
    {
        public Sauce(string type, double weight) 
            : base(type, weight)
        {
        }
    }
}
