using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> firstList = Console.ReadLine()!
                          .Split()
                          .Select(decimal.Parse)
                          .ToList();

            List<decimal> secondList = Console.ReadLine()!
                          .Split()
                          .Select(decimal.Parse)
                          .ToList();
            List<decimal> mergedList = new List<decimal>(firstList.Count + secondList.Count);
            int minCount = Math.Min(firstList.Count, secondList.Count);
            for (int i = 0; i < minCount; i++)
            {
                mergedList.Add(firstList[i]);
                mergedList.Add(secondList[i]);
            }
            if (firstList.Count > minCount)
            {
                mergedList.AddRange(firstList.GetRange(minCount, firstList.Count - minCount));
            }
            if (secondList.Count > minCount)
            {
                mergedList.AddRange(secondList.GetRange(minCount, secondList.Count - minCount));
            }
            Console.WriteLine(string.Join(" ", mergedList));

        }
    }
}
