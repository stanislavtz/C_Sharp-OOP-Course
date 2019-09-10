using System;
using System.Text;

namespace Mankind.Models
{
    public class Human
    {
        private const int MIN_FIRST_NAME_LENGTH = 4;
        private const int MIN_LAST_NAME_LENGTH = 3;

        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get => this.firstName;
            private set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {this.firstName}");
                }

                if (value.Length < MIN_FIRST_NAME_LENGTH)
                {
                    throw new ArgumentException($"Expected length at least {MIN_FIRST_NAME_LENGTH} symbols! Argument: {this.firstName}");
                }
                //ValidateFirstLetter(value);
                //ValidateNameLength(value, MIN_FIRST_NAME_LENGTH);

                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            private set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {this.lastName}");
                }

                if (value.Length < MIN_LAST_NAME_LENGTH)
                {
                    throw new ArgumentException($"Expected length at least {MIN_LAST_NAME_LENGTH} symbols! Argument: {this.lastName} ");
                }
                //ValidateFirstLetter(value);
                //ValidateNameLength(value, MIN_LAST_NAME_LENGTH);

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");

            return sb.ToString().TrimEnd();
        }
    }
}
