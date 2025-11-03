using System;

namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static int totalOfEven = 0;
        static int totalOfOdd = 0;

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            GetMultipleOfEvenAndOdds(number);
        }

        static void GetMultipleOfEvenAndOdds(int num)
        {
            GetSumOfEvenDigits(num);
            GetSumOfOddDigits(num);
            int result = totalOfEven * totalOfOdd;
            Console.WriteLine(result);
        }

        static void GetSumOfEvenDigits(int EvenDigitsNum)
        {
            while (EvenDigitsNum > 0)
            {
                int digit = EvenDigitsNum % 10;
                if (digit % 2 == 0)
                {
                    totalOfEven += digit;
                }
                EvenDigitsNum /= 10;
            }
        }

        static void GetSumOfOddDigits(int OddDigitsNum)
        {
            while (OddDigitsNum > 0)
            {
                int digit = OddDigitsNum % 10;
                if (digit % 2 != 0)
                {
                    totalOfOdd += digit;
                }
                OddDigitsNum /= 10;
            }
        }
    }
}
