using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> counts = new();

            foreach (int number in numbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts[number] = 0;
                }
                counts[number]++;

            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
