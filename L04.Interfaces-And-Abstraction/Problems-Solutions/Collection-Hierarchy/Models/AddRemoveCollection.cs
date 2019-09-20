namespace Collection_Hierarchy.Models
{
    using System.Collections.Generic;
    using Collection_Hierarchy.Contracts;

    public class AddRemoveCollection<T> : AddCollection<T>, IAddRemoveCollection<T>
    {
        private readonly List<T> addRemoveCollection;

        public AddRemoveCollection()
        {
            addRemoveCollection = new List<T>();
        }

        public override int Add(T element)
        {
            addRemoveCollection.Insert(0, element);

            return addRemoveCollection.IndexOf(addRemoveCollection[0]);
        }

        public virtual T Remove()
        {
            T element = addRemoveCollection[addRemoveCollection.Count - 1];
            addRemoveCollection.RemoveAt(addRemoveCollection.Count - 1);

            return element;
        }
    }
}
