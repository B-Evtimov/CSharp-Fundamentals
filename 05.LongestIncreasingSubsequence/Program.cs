using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.LongestIncreasingSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int n = nums.Length;
            int[] len = new int[n];
            int[] prev = new int[n];

            for (int i = 0; i < n; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i] && len[j] + 1 > len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }
            }


            int maxLen = len.Max();
            int lastIndex = Array.IndexOf(len, maxLen);


            List<int> lis = new List<int>();
            while (lastIndex != -1)
            {
                lis.Add(nums[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            lis.Reverse();
            Console.WriteLine(string.Join(" ", lis));

        }
    }
}
