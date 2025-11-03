using System;

namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int firstNum = int.Parse(input[0]);
                int secondNum = int.Parse(input[1]);

                if (i % 2 == 0)
                {
                    firstArray[i] = firstNum;
                    secondArray[i] = secondNum;
                }
                else
                {
                    firstArray[i] = secondNum;
                    secondArray[i] = firstNum;
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));

        }
    }
}
