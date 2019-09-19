using Military_Elite.Exceptions;
using Military_Elite.Contracts.SpecialForces;
using System.Collections.Generic;

namespace Military_Elite
{
    public class Mission : IMission
    {
        private string state;
        private readonly List<string> statments;

        public Mission(string codeName, string state)
        {
            statments = new List<string>();
            ParseStatments();

            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; private set; }

        public string State
        {
            get => this.state;
            internal set
            {
                if (!statments.Contains(value))
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

        private void ParseStatments()
        {
            statments.Add("inProgress");
            statments.Add("Finished");
        }
    }
}