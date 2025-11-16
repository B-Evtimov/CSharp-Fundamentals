using System;

namespace problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Input / Constraints
The input data will consist of:
•	budget - a floating-point number in the range [0.00…1000.00]
•	students - an integer in the range [0…100]
•	price for a package of flour - a floating-point number in the range [0.00…100.00]
•	price for a single egg - a floating-point number in the range [0.00…100.00]
•	price for a single apron - a floating-point number in the range [0.00…100.00]
The input data will always be valid. There is no need to check it explicitly.

            */
            double budget = double.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());

            double pricePerPackageOfFlour = double.Parse(Console.ReadLine());

            double pricePerEgg = double.Parse(Console.ReadLine());

            double pricePerApron = double.Parse(Console.ReadLine());

            double totalPrice = 0;

            //Calculations
            int freePackagesOfFlour = (students / 5);
            double totalPriceForFlour = ((students - freePackagesOfFlour) * pricePerPackageOfFlour);
            double totalPriceForEggs = students * 10 * pricePerEgg;
            double totalPriceForAprons = (Math.Ceiling(students * 1.2) * pricePerApron);
            totalPrice = (totalPriceForFlour + totalPriceForEggs + totalPriceForAprons);
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Items purchased for {totalPrice:f2}$.");
            }
            else
            {
                Console.WriteLine($"{totalPrice - budget:f2}$ more needed.");
            }


        }

    }

}

