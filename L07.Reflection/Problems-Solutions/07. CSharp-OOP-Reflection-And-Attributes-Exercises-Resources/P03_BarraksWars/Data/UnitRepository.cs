namespace _03BarracksFactory.Data
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    using Contracts;

    class UnitRepository : IRepository
    {
        private IDictionary<string, int> army;

        public UnitRepository(IDictionary<string, int> army)
        {
            this.army = army;
        }

        public string Statistics => CreateStatistics();

        public void AddUnit(IUnit unit)
        {
            string unitType = unit.GetType().Name;

            if (!this.army.ContainsKey(unitType))
            {
                this.army.Add(unitType, 0);
            }

            this.army[unitType]++;
        }

        public void RemoveUnit(string unitType)
        {
            if (!this.army.ContainsKey(unitType) || this.army[unitType] == 0)
            {
                throw new ArgumentException("No such units in repository.");
            }
           
            this.army[unitType]--;
        }

        private string CreateStatistics()
        {
            StringBuilder statBuilder = new StringBuilder();

            foreach (var entry in army)
            {
                statBuilder.AppendLine($"{entry.Key} -> {entry.Value}");
            }

            return statBuilder.ToString().TrimEnd();
        }
    }
}
