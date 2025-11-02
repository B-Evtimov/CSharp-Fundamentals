namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfThePeople = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double pricePerPerson = 0;

            if (dayOfTheWeek == "Friday")
            {
                if (typeOfTheGroup == "Students")
                {
                    pricePerPerson = 8.45;
                    if (countOfThePeople >= 30)
                        pricePerPerson *= 0.85;
                }
                else if (typeOfTheGroup == "Business")
                {
                    pricePerPerson = 10.90;
                    if (countOfThePeople >= 100)
                        countOfThePeople -= 10;
                }
                else if (typeOfTheGroup == "Regular")
                {
                    pricePerPerson = 15.00;
                    if (countOfThePeople >= 10 && countOfThePeople <= 20)
                        pricePerPerson *= 0.95;
                }
            }
            else if (dayOfTheWeek == "Saturday")
            {
                if (typeOfTheGroup == "Students")
                {
                    pricePerPerson = 9.80;
                    if (countOfThePeople >= 30)
                        pricePerPerson *= 0.85;
                }
                else if (typeOfTheGroup == "Business")
                {
                    pricePerPerson = 15.60;
                    if (countOfThePeople >= 100)
                        countOfThePeople -= 10;
                }
                else if (typeOfTheGroup == "Regular")
                {
                    pricePerPerson = 20.00;
                    if (countOfThePeople >= 10 && countOfThePeople <= 20)
                        pricePerPerson *= 0.95;
                }
            }
            else if (dayOfTheWeek == "Sunday")
            {
                if (typeOfTheGroup == "Students")
                {
                    pricePerPerson = 10.46;
                    if (countOfThePeople >= 30)
                        pricePerPerson *= 0.85;
                }
                else if (typeOfTheGroup == "Business")
                {
                    pricePerPerson = 16.00;
                    if (countOfThePeople >= 100)
                        countOfThePeople -= 10;
                }
                else if (typeOfTheGroup == "Regular")
                {
                    pricePerPerson = 22.50;
                    if (countOfThePeople >= 10 && countOfThePeople <= 20)
                        pricePerPerson *= 0.95;
                }
            }

            double totalPrice = pricePerPerson * countOfThePeople;
            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
