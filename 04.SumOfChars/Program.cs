using System;

namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int asciiSum = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                asciiSum += (int)currentChar;
            }
            Console.WriteLine($"The sum equals: {asciiSum}");

        }
    }
}
