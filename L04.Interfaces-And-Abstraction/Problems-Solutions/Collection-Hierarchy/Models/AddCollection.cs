using Collection_Hierarchy.Contracts;
using System.Collections.Generic;

namespace Collection_Hierarchy.Models
{
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

            return addRemoveCollection.IndexOf(addRemoveCollection[addRemoveCollection.Count - 1]);
        }
    }
}
