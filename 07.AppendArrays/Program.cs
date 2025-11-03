using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> arrays = input.Split('|')
                                       .Select(arr => arr.Trim())
                                       .Reverse()
                                       .ToList();

            List<string> result = new List<string>();

            foreach (string arr in arrays)
            {
                string[] numbers = arr.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(numbers);
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
