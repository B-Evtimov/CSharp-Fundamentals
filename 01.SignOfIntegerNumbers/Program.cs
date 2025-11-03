using System;

namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WhatIsTheTypeOfNumber(int.Parse(Console.ReadLine()));
        }
        static void WhatIsTheTypeOfNumber(int number)
        {
            if (number == 0)
                Console.WriteLine($"The number {number} is zero.");
            else if (number < 0)
                Console.WriteLine($"The number {number} is negative.");
            else
                Console.WriteLine($"The number {number} is positive.");


        }
    }
}
