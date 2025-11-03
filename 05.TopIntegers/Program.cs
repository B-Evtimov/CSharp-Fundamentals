using System;
using System.Linq;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()!
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            for (int i = 0; i < integers.Length; i++)
            {
                bool isTopInteger = true;
                for (int j = i + 1; j < integers.Length; j++)
                {
                    if (integers[i] <= integers[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write(integers[i] + " ");
                }
            }

        }
    }
}
