using System;
using Wild_Farm.Contracts;
using Wild_Farm.Exceptions;

namespace Wild_Farm.Models.Foods
{
    public class Vegetable : Food
    {
        public Vegetable(int quantity) 
            : base(quantity)
        {
        }
    }
}
