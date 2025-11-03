using System;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            GetFactorialDivision(firstNumber, secondNumber);
        }

        static void GetFactorialDivision(int firstNum, int secondNum)
        {
            decimal firstFactorial = GetFactorial(firstNum);
            decimal secondFactorial = GetFactorial(secondNum);

            decimal result = firstFactorial / secondFactorial;
            Console.WriteLine($"{result:f2}");
        }

        static decimal GetFactorial(int num)
        {
            decimal result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
