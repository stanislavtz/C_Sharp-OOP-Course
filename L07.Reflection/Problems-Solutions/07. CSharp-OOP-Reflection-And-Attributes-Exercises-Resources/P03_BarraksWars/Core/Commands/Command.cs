using _03BarracksFactory.Contracts;

namespace P03_BarraksWars.Core.Commands
{
    public abstract class Command : IExecutable
    {
        private readonly string[] data;
        private readonly IUnitFactory unitFactory;
        private readonly IRepository unitRepository;

        protected Command(string[] data, IUnitFactory unitFactory, IRepository unitRepository)
        {
            this.data = data;
            this.unitFactory = unitFactory;
            this.unitRepository = unitRepository;
        }

        protected string[] Data => this.data;

        protected IUnitFactory UnitFactory => this.unitFactory;

        protected IRepository UnitRepository => this.unitRepository;

        public abstract string Execute();
    }
}
