using System;

namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                double height = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                GetRectangleArea(height, width);
            }
            static void GetRectangleArea(double height, double width)
            {
                Console.WriteLine($"{height * width:f0}");
            }
        }
    }
}
