using Military_Elite.Contracts.SpecialForces;
using System;

namespace Military_Elite
{
    public class Mission : IMission
    {
        private string state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; private set; }

        public string State
        {
            get => this.state;
            private set
            {
                if (value != "inProgress" || value != "Finished")
                {
                    throw new ArgumentException("Invalid mission statment!");
                }
                this.state = value;
            }
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}