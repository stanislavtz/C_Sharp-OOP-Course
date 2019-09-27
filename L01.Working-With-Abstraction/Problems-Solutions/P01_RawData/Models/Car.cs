namespace P01_RawData
{
    using System.Linq;
    using P01_RawData.Models;
    using System.Collections.Generic;

    public class Car
    {
        public Car(string model, CarEngine engine, Cargo cargo, IList<Tire> tires)
        {
            this.Model = model;
            this.EngineSpeed = engine.Speed;
            this.EnginePower = engine.Power;
            this.CargoWeight = cargo.Weight;
            this.CargoType = cargo.Type;

            this.Tires = tires.ToList().AsReadOnly();
         }

        public string Model;
        public int EngineSpeed;
        public int EnginePower;
        public int CargoWeight;
        public string CargoType;

        public IReadOnlyCollection<Tire> Tires { get; }
    }
}
