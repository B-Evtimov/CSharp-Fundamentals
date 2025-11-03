using System;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int litresInTheTank = 0;

            for (int i = 0; i < n; i++)
            {
                int pourAmount = int.Parse(Console.ReadLine());

                if (litresInTheTank + pourAmount > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    litresInTheTank += pourAmount;
                }
            }

            Console.WriteLine(litresInTheTank);
        }
    }
}
