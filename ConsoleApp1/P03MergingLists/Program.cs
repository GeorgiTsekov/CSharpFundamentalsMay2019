using System;
using System.Collections.Generic;
using System.Linq;

namespace P03MergingLists
{
    class Program
    {
        static void Main()
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> mergingList = new List<int>();

            for (int i = 0; i < firstList.Count + secondList.Count; i++)
            {
                if (i < firstList.Count)
                {
                    mergingList.Add(firstList[i]);
                }
                if (i < secondList.Count)
                {
                    mergingList.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", mergingList));
        }
    }
}
