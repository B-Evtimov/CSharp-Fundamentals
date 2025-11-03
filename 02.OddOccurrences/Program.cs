using System;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            Dictionary<string, int> wordCount = new();
            foreach (string word in words)
            {
                string lowerWord = word.ToLower();
                if (!wordCount.ContainsKey(lowerWord))
                {
                    wordCount[lowerWord] = 0;
                }
                wordCount[lowerWord]++;
            }
            List<string> oddOccurrences = new();
            foreach (var kvp in wordCount)
            {
                if (kvp.Value % 2 != 0)
                {
                    oddOccurrences.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(" ", oddOccurrences));

        }
    }
}
