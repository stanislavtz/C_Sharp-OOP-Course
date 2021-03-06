﻿using Birthday_Celebrations.Contracts;

namespace Birthday_Celebrations.Models
{
    public class Robot : IRegisterable, INameable
    {
        private readonly string model;
        private readonly string id;

        public Robot(string model, string id)
        {
            this.model = model;
            this.id = id;
        }

        public string Name => this.model;

        public string Id => this.id;
    }
}
