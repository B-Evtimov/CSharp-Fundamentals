using System;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 1; number <= n; number++)
            {
                int sumOfDigits = 0;
                int current = number;

                while (current > 0)
                {
                    sumOfDigits += current % 10;
                    current /= 10;
                }

                bool isSpecial = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;
                Console.WriteLine($"{number} -> {isSpecial}");
            }
        }
    }
}
