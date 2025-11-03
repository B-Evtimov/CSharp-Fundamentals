using System;

namespace _08.TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double population = double.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());
            Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
        }
    }
}
