using System;
using System.Text;
using System.Linq;
using Mankind.Exceptions;

namespace Mankind.Models
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get => this.facultyNumber;
            private set
            {
                if (value.Length < 5 
                    || value.Length > 10 
                    || value.Any(ch => !char.IsLetterOrDigit(ch)))
                {
                    throw new ArgumentException(ExceptionsData.InvalidFacultyNumber);
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Faculty number: {this.FacultyNumber}");

            return sb.ToString().TrimEnd();
        }
    }
}
