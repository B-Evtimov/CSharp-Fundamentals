using System;

namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculateOrderTotal(Console.ReadLine(), double.Parse(Console.ReadLine()));
        }
        static void calculateOrderTotal(string product, double quantity)
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine($"{quantity * 1.50:f2}");
                    break;

                case "water":
                    Console.WriteLine($"{quantity * 1.00:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{quantity * 1.40:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{quantity * 2.00:f2}");
                    break;
            }
        }
    }
}
