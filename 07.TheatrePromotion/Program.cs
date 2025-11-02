namespace _07.TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            bool isError = false;

            switch (day)
            {
                case "Weekday":
                    if (0 <= age && age <= 18)
                    {
                        price = 12;
                    }
                    else if (18 < age && age <= 64)
                    {
                        price = 18;
                    }
                    else if (64 < age && age <= 122)
                    {
                        price = 12;
                    }
                    else
                    {
                        isError = true;
                    }
                    break;

                case "Weekend":
                    if (0 <= age && age <= 18)
                    {
                        price = 15;
                    }
                    else if (18 < age && age <= 64)
                    {
                        price = 20;
                    }
                    else if (64 < age && age <= 122)
                    {
                        price = 15;
                    }
                    else
                    {
                        isError = true;
                    }
                    break;

                case "Holiday":
                    if (0 <= age && age <= 18)
                    {
                        price = 5;
                    }
                    else if (18 < age && age <= 64)
                    {
                        price = 12;
                    }
                    else if (64 < age && age <= 122)
                    {
                        price = 10;
                    }
                    else
                    {
                        isError = true;
                    }
                    break;
                default:
                    isError = true;
                    break;
            }

            if (isError)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{price}$");
            }
        }
    }
}
