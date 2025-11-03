using System;

namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                sum += int.Parse(number.ToString()[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
