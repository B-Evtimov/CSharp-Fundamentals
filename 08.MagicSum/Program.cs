using System;
using System.Linq;

namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()!
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int magicSum = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < integers.Length; i++)
            {
                for (int j = i + 1; j < integers.Length; j++)
                {
                    if (integers[i] + integers[j] == magicSum)
                    {
                        Console.WriteLine($"{integers[i]} {integers[j]}");
                    }

                }

            }
        }
    }
}
