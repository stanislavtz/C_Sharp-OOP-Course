using Collection_Hierarchy.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Collection_Hierarchy.Models
{
    public class AddRemoveCollection<T> : AddCollection<T>, IAddRemoveCollection<T>
    {
        private readonly Stack<T> addRemoveCollection;

        public AddRemoveCollection()
        {
            addRemoveCollection = new Stack<T>();
        }

        public override void Add(T element)
        {
            addRemoveCollection.Push(element);
        }

        public virtual void Remove(T element)
        {
            addRemoveCollection.Reverse();
            System.Console.WriteLine(addRemoveCollection.Pop());
        }
    }
}
