﻿using Mankind.Exceptions;
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
                ValidateFirstLetter(value, nameof(this.firstName));
                ValidateNameLength(value, MIN_FIRST_NAME_LENGTH, nameof(this.firstName));

                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            private set
            {
                ValidateFirstLetter(value, nameof(this.lastName));
                ValidateNameLength(value, MIN_LAST_NAME_LENGTH, nameof(this.lastName));

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

        private static void ValidateNameLength(string name, int length, string parameter)
        {
            if (name.Length < length)
            {
                throw new ArgumentException
                    (string.Format(ExceptionsData.InvalidNameLength, parameter, length));
            }
        }

        private static void ValidateFirstLetter(string name, string parameter)
        {
            if (!char.IsUpper(name[0]))
            {
                throw new ArgumentException
                    (string.Format(ExceptionsData.InvalidFirstLetter, parameter));
            }
        }
    }
}
