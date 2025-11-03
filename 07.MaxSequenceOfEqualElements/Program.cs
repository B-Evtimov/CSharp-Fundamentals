using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()!
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int maxCount = 1;
            int currentCount = 1;
            int number = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        number = numbers[i];
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(number + " ");
            }

        }
    }
}
