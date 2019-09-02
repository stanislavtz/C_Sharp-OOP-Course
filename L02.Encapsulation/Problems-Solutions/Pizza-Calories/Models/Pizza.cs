using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories.Models
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private IList<Topping> toppings;
    }
}
