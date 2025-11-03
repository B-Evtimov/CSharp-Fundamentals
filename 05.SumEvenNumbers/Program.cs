using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()!
                  .Split()
                  .Select(int.Parse)
                  .ToArray();
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    result += nums[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
