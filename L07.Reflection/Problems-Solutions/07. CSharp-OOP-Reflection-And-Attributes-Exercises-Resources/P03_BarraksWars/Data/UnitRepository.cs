namespace _03BarracksFactory.Data
{
    using System;
    using Contracts;
    using System.Text;
    using System.Collections.Generic;

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
            //TODO: implement for Problem 4
            throw new NotImplementedException();
        }

        private string CreateStatistics()
        {
            StringBuilder statBuilder = new StringBuilder();

            foreach (var entry in army)
            {
                string formatedEntry = $"{entry.Key} -> {entry.Value}";

                statBuilder.AppendLine(formatedEntry);
            }

            return statBuilder.ToString().Trim();
        }
    }
}
