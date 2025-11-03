using System;
using System.Linq;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToArray();
            int[] nums2 = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToArray();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1.Length != nums2.Length)
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                if (nums1[i] != nums2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }
            int sum = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                sum += nums1[i];
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");

        }
    }
}
