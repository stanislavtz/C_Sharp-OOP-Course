using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories.Models.Doughs.Types
{
    public class White : Dough
    {
        private const double MODIFIRE = 1.5;

        public White(string mainType, string additionalType, double weight) 
            : base(mainType, additionalType, weight)
        {
        }
    }
}
