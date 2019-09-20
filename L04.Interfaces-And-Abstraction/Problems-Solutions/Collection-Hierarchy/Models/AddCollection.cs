namespace Collection_Hierarchy.Models
{
    using System.Collections.Generic;
    using Collection_Hierarchy.Contracts;

    public class AddCollection<T> : IAddCollection<T>
    {
        private readonly List<T> addRemoveCollection;

        public AddCollection()
        {
            addRemoveCollection = new List<T>();
        }

        public virtual int Add(T element)
        {
            addRemoveCollection.Add(element);

            return addRemoveCollection.Count - 1;
        }
    }
}
