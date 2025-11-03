using System;

namespace _02.PrintNumbersИnReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int[] numbers = new int[lines];
            for (int i = 0; i < lines; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = lines - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");

            }
            Console.WriteLine();
        }
    }
}
