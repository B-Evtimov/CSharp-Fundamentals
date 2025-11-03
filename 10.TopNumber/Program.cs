using System;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            for (int i = 1; i <= end; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsTopNumber(int number)
        {
            int sum = 0;
            bool hasOddDigit = false;
            int temp = number;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += digit;

                if (digit % 2 != 0)
                {
                    hasOddDigit = true;
                }

                temp /= 10;
            }

            return sum % 8 == 0 && hasOddDigit;
        }
    }
}
