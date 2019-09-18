using Military_Elite.Exceptions;
using Military_Elite.Contracts.SpecialForces;

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
            internal set
            {
                if (value != "inProgress" || value != "Finished")
                {
                    throw new InvalidMissionStatment();
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