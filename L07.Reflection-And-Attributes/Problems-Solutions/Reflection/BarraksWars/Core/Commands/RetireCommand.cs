﻿using _03BarracksFactory.Contracts;

namespace P03_BarraksWars.Core.Commands
{
    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IUnitFactory unitFactory, IRepository unitRepository) 
            : base(data, unitFactory, unitRepository)
        {
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            this.UnitRepository.RemoveUnit(unitType);
            string output = $"{unitType} retired!";

            return output;
        }
    }
}
