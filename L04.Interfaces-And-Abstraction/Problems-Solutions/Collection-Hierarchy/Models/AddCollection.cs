using Collection_Hierarchy.Contracts;
using System.Collections.Generic;

namespace Collection_Hierarchy.Models
{
    public class AddCollection<T> : IAddCollection<T>
    {
        private readonly List<T> addCollection;

        public AddCollection()
        {
            addCollection = new List<T>();
        }

        public virtual void Add(T element)
        {
            addCollection.Add(element);
        }
    }
}
