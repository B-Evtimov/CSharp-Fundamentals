using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new();
            numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new();
            int left = 0;
            int right = numbers.Count - 1;

            while (left < right)
            {
                result.Add(numbers[left] + numbers[right]);
                left++;
                right--;
            }
            if (left == right)
            {
                result.Add(numbers[left]);
            }
            Console.WriteLine(string.Join(" ", result));



        }

    }
}
