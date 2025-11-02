namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalMoney = 0;

            string input = Console.ReadLine();
            while (input != "Start")
            {
                double coin = double.Parse(input);

                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    totalMoney += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                double price = 0;

                switch (input)
                {
                    case "Nuts": price = 2.0; break;
                    case "Water": price = 0.7; break;
                    case "Crisps": price = 1.5; break;
                    case "Soda": price = 0.8; break;
                    case "Coke": price = 1.0; break;
                    default:
                        Console.WriteLine("Invalid product");
                        input = Console.ReadLine();
                        continue;
                }

                if (totalMoney >= price)
                {
                    totalMoney -= price;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalMoney:F2}");

        }
    }
}
