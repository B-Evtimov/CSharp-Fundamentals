using System;
using System.Collections.Generic;

namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string[] secondLine = Console.ReadLine().Split();

            HashSet<string> firstSet = new HashSet<string>(firstLine);

            foreach (string word in secondLine)
            {
                if (firstSet.Contains(word))
                {
                    Console.Write(word + " ");
                }
            }
        }
    }
}
