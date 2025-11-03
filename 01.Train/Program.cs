using System;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int totalPassengers = 0;
            int[] passengers = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                totalPassengers += passengers[i];
            }

            Console.WriteLine(string.Join(" ", passengers));
            Console.WriteLine(totalPassengers);

        }
    }
}
