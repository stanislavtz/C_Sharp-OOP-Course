using System;
using Military_Elite.Contracts;

namespace Military_Elite.Models
{
    public class Spy : Soldier, ISpy
    {
        public int CodeNumber => throw new NotImplementedException();

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Code Number: {this.CodeNumber}";
        }
    }
}
