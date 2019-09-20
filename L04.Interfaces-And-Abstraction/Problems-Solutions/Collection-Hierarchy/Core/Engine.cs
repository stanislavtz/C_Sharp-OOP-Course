using Collection_Hierarchy.Contracts;
using Collection_Hierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection_Hierarchy.Core
{
    public class Engine
    {
        public void Run()
        {
            IAddCollection<string> addCollection = new AddCollection<string>();
            IAddRemoveCollection<string> addRemoveColection = new AddRemoveCollection<string>();
            IMyList<string> myList = new MyList<string>();

            List<int> addCollectionPositions = new List<int>();
            List<int> addRemoveCollectionPositions = new List<int>();
            List<int> myListPositions = new List<int>();

            string[] input = Console.ReadLine().Split();

            foreach (var item in input)
            {
                addCollectionPositions.Add(addCollection.Add(item));
                addRemoveCollectionPositions.Add(addRemoveColection.Add(item));
                myListPositions.Add(myList.Add(item));
            }

            Console.WriteLine(string.Join(" ", addCollectionPositions));
            Console.WriteLine(string.Join(" ", addRemoveCollectionPositions));
            Console.WriteLine(string.Join(" ", myListPositions));

            int numberRemoves = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberRemoves; i++)
            {
                Console.Write(addRemoveColection.Remove() + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < numberRemoves; i++)
            {
                Console.Write(myList.Remove() + " ");
            }
        }
    }
}
