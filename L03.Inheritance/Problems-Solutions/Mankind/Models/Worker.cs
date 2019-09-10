﻿using System;
using System.Text;
using Mankind.Exceptions;

namespace Mankind.Models
{
    public class Worker : Human
    {
        private const decimal WORKING_DAYS = 5;

        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workingHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workingHoursPerDay;
        }

        public decimal WeekSalary
        {
            get => this.weekSalary;
            private set
            {
                if (value <= 10)
                {
                    throw new ArgumentException(string.Format(ExceptionsData.ValueMisMash, nameof(this.weekSalary)));
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get => this.workHoursPerDay;
            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException(string.Format(ExceptionsData.ValueMisMash, nameof(this.workHoursPerDay)));
                }
                this.workHoursPerDay = value;
            }
        }

        private decimal SalaryPerHour()
        {
            return this.WeekSalary / (WORKING_DAYS * (decimal)this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
            sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}");
            sb.AppendLine($"Salary per hour: {this.SalaryPerHour():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
