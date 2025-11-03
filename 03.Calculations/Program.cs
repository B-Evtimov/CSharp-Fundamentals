using System;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintCalculationOfTwoNumbers(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        }
        static void PrintCalculationOfTwoNumbers(string operation, double firstNumber, double secondNumber)
        {
            switch (operation)
            {
                case "add":
                    Console.WriteLine(firstNumber + secondNumber);
                    break;
                case "multiply":
                    Console.WriteLine(firstNumber * secondNumber);
                    break;
                case "subtract":
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                case "divide":
                    Console.WriteLine(firstNumber / secondNumber);
                    break;
            }
        }
    }
}

