using System;
using System.Linq;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            GetPrintTheSmallest(a, b, c);
        }
        static void GetPrintTheSmallest(int a, int b, int c)
        {
            int[] numbers = { a, b, c };
            int smallest = numbers.Min();
            Console.WriteLine(smallest);
        }
    }
}
