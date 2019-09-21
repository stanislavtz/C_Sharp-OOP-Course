namespace Explicit_Interfaces.Contracts
{
    public interface IResident : ICitizen
    {
        string Country { get; }
    }
}
