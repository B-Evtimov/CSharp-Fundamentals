using System;
using System.Linq;

namespace _04.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToArray();

            int k = numbers.Length / 4;


            int[] leftFold = numbers.Take(k).Reverse().ToArray();
            int[] rightFold = numbers.Skip(3 * k).Take(k).Reverse().ToArray();
            int[] foldedRow = leftFold.Concat(rightFold).ToArray();


            int[] middleRow = numbers.Skip(k).Take(2 * k).ToArray();


            int[] result = new int[2 * k];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = foldedRow[i] + middleRow[i];
            }


            Console.WriteLine(string.Join(" ", result));

        }
    }
}
