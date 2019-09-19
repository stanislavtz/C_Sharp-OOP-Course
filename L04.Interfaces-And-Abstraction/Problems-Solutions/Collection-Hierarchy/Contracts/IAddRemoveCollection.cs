namespace Collection_Hierarchy.Contracts
{
    public interface IAddRemoveCollection<T> : IAddCollection<T>
    {
        void Remove(T element);
    }
}
