using Collection_Hierarchy.Contracts;
using System.Collections.Generic;

namespace Collection_Hierarchy.Models
{
    public class MyList<T> : AddRemoveCollection<T>, IMyList<T>
    {
        private readonly List<T> myList;

        public MyList()
        {
            myList = new List<T>();
        }

        public int Used { get; private set; }

        public override void Remove(T element)
        {
            myList.;
        }
    }
}
