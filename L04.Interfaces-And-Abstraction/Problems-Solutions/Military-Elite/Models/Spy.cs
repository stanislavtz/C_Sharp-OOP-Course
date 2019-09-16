using Military_Elite.Contracts;
using System;

namespace Military_Elite.Models
{
    public class Spy : Soldier, ISpy
    {
        public int CodeNumber => throw new NotImplementedException();
    }
}
