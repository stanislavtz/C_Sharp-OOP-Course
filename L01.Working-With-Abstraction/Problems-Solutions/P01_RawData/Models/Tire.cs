namespace P01_RawData.Models

{
    public class Tire
    {
        public Tire(double presure, int age)
        {
            this.Presure = presure;
            this.Age = age;
        }

        public double Presure { get; private set; }

        public int Age { get; private set; }
    }
}
