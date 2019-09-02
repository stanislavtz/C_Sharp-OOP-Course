using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories.Models.Doughs.Types
{
    public class Wholegrain : Dough
    {
        private const double MODIFIRE = 1.0;
        public Wholegrain(string mainType, string additionalType, double weight)
            : base(mainType, additionalType, weight)
        {
        }
    }
}
