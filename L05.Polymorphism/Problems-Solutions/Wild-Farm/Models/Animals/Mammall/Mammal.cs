﻿namespace Wild_Farm.Models.Animals.Mammall
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, double weight, string livingRegion) 
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string  LivingRegion { get; private set; }
    }
}
