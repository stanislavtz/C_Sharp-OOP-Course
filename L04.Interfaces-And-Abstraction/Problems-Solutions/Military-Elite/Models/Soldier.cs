﻿using System;
using Military_Elite.Contracts;

namespace Military_Elite.Models
{
    public abstract class Soldier : ISoldier
    {
        public string Id => throw new NotImplementedException();

        public string FirstName => throw new NotImplementedException();

        public string LastName => throw new NotImplementedException();
    }
}