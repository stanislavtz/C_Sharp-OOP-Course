namespace _03BarracksFactory.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;
    using Models.Units;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type currentUniteType = assembly.GetTypes().FirstOrDefault(x => x.Name == unitType);

            if (currentUniteType == null)
            {
                throw new ArgumentException("Invalid unit!");
            }

            IUnit unit = (Unit)Activator.CreateInstance(currentUniteType);

            return unit; 
        }
    }
}
