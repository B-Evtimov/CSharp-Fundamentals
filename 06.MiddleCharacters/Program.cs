using System;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            GetMiddleOfString(word);
        }
        static void GetMiddleOfString(string word)
        {
            if (word.Length % 2 == 0)
            {
                int firstIndex = word.Length / 2 - 1;
                int secondIndex = word.Length / 2;
                Console.WriteLine($"{word[firstIndex]}{word[secondIndex]}");
            }
            else
            {
                int middleIndex = word.Length / 2;
                Console.WriteLine(word[middleIndex]);

            }
        }
    }
}
