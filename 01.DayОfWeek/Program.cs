using System;

namespace _01.DayОfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int dayOfTheWeek = int.Parse(Console.ReadLine());

            if (dayOfTheWeek <= 0 || dayOfTheWeek > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine($"{days[dayOfTheWeek - 1]}");
            }

        }
    }
}
