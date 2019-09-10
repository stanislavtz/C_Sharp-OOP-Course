using System;
using System.Text;

namespace Mankind.Models
{
    public class Worker : Human
    {
        private const decimal WORKING_DAYS = 5;

        private decimal weekSalary;
        private double workingHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workingHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHoursPerDay = workingHoursPerDay;
        }

        public decimal WeekSalary
        {
            get => this.weekSalary;
            private set
            {
                if (value <= 10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {this.weekSalary}");
                }

                this.weekSalary = value;
            }
        }

        public double WorkingHoursPerDay
        {
            get => this.workingHoursPerDay;
            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {this.workingHoursPerDay}");
                }
                this.workingHoursPerDay = value;
            }
        }

        private decimal SalaryPerHour()
        {
            return this.WeekSalary / (WORKING_DAYS * (decimal)this.WorkingHoursPerDay);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
            sb.AppendLine($"Hours per day: {this.WorkingHoursPerDay:f2}");
            sb.AppendLine($"Salary per hour: {this.SalaryPerHour():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
