using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories.Models.Doughs.AdditionalTypes
{
    public class Chewy : Dough
    {
        private const double MODIFIRE = 1.1;
        public Chewy(string mainType, string additionalType, double weight)
            : base(mainType, additionalType, weight)
        {
        }
    }
}
