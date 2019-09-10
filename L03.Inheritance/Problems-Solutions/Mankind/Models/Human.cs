using Mankind.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind.Models
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string fn, string ln)
        {

        }

        public string FirstName
        {
            get => this.firstName;
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException
                        (string.Format(ExcetionsData.InvalidFistNameStartingLetterException), value.Split()[0]);
                }

                this.firstName = value;
            }
        }
    }
}
