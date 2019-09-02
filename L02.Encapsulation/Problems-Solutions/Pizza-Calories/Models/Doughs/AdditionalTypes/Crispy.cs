using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories.Models.Doughs.AdditionalTypes
{
    public class Crispy : Dough
    {
        private const double MODIFIRE = 0.9;
        public Crispy(string mainType, string additionalType, double weight)
            : base(mainType, additionalType, weight)
        {
        }
    }
}
