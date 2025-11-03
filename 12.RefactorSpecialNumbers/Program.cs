using System;

namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = int.Parse(Console.ReadLine());

            for (int number = 1; number <= upperLimit; number++)
            {
                int currentNumber = number;
                int digitSum = 0;

                while (currentNumber > 0)
                {
                    digitSum += currentNumber % 10;
                    currentNumber /= 10;
                }

                bool isSpecial = digitSum == 5 || digitSum == 7 || digitSum == 11;
                Console.WriteLine($"{number} -> {isSpecial}");
            }
        }
    }
}
