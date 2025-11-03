using System;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int result = Subtract(Sum(firstNumber, secondNumber), thirdNumber);
            Console.WriteLine(result);
        }
        static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        static int Subtract(int sum, int thirdNumber)
        {
            return sum - thirdNumber;
        }

    }
}
