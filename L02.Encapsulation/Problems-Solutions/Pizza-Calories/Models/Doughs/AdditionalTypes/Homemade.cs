using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories.Models.Doughs.AdditionalTypes
{
    public class Homemade : Dough
    {
        private const double MODIFIRE = 1.0;
        public Homemade(string mainType, string additionalType, double weight) 
            : base(mainType, additionalType, weight)
        {

        }
    }
}
