namespace _03BarracksFactory
{
    using Data;
    using Core;
    using Contracts;
    using Core.Factories;
    using System.Collections.Generic;

    class AppStartUp
    {
        static void Main(string[] args)
        {
            IDictionary<string, int> army = new SortedDictionary<string, int>();
            IRepository unitRepository = new UnitRepository(army);
            IUnitFactory unitFactory = new UnitFactory();

            IRunnable engine = new Engine(unitRepository, unitFactory);
            engine.Run();
        }
    }
}
