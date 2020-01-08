using System;

using Military_Elite.Exceptions;
using Military_Elite.Enumerators;
using Military_Elite.Contracts.SpecialForces;

namespace Military_Elite
{
    public class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;

            ParseStatment(state);
        }

        public string CodeName { get; private set; }

        public State State { get; set; }

        //public void CompleateMission()
        //{
        //    this.State = State.Finished;
        //}

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }

        private void ParseStatment(string stateStr)
        {
            State state;

            bool parsed = Enum.TryParse<State>(stateStr, out state);

            if (!parsed)
            {
                throw new InvalidMissionStatmentException();
            }

            this.State = state;
        }
    }
}