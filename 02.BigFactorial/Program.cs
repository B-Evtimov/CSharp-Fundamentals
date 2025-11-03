using System;

namespace _02.BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            static string CalculateFactorial(int number)
            {
                System.Numerics.BigInteger factorial = 1;
                for (int i = 2; i <= number; i++)
                {
                    factorial *= i;
                }
                return factorial.ToString();
            }
            Console.WriteLine(CalculateFactorial(n));

        }
    }
}
