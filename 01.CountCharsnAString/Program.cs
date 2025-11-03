using System;
using System.Collections.Generic;

namespace _01.CountCharsnAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (string word in input)
            {
                foreach (char character in word)
                {
                    if (!charCount.ContainsKey(character))
                    {
                        charCount[character] = 0;
                    }
                    charCount[character]++;
                }

            }
            foreach (var result in charCount)
            {
                Console.WriteLine($"{result.Key} -> {result.Value}");
            }
        }
    }
}
