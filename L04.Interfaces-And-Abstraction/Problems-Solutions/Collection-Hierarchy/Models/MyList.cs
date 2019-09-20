namespace Collection_Hierarchy.Models
{
    using System.Collections.Generic;
    using Collection_Hierarchy.Contracts;

    public class MyList<T> : AddRemoveCollection<T>, IMyList<T>
    {
        private readonly List<T> myList;

        public MyList()
        {
            myList = new List<T>();
        }

        public int Used => myList.Count;

        public override int Add(T element)
        {
            myList.Insert(0, element);

            return myList.IndexOf(myList[0]);
        }

        public override T Remove()
        {
            T element = myList[0];

            myList.RemoveAt(0);

            return element;
        }
    }
}
