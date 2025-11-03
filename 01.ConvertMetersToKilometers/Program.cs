using System;

namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int metres = int.Parse(Console.ReadLine());
            double kilometres = metres / 1000.0;
            Console.WriteLine($"{kilometres:f2}");
        }
    }
}
