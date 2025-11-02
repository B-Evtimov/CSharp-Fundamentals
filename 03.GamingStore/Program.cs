namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            double balance = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double totalSpent = 0;

            while (command != "Game Time")
            {
                double gamePrice = 0;
                bool gameFound = true;

                if (command == "OutFall 4")
                    gamePrice = 39.99;
                else if (command == "CS: OG")
                    gamePrice = 15.99;
                else if (command == "Zplinter Zell")
                    gamePrice = 19.99;
                else if (command == "Honored 2")
                    gamePrice = 59.99;
                else if (command == "RoverWatch")
                    gamePrice = 29.99;
                else if (command == "RoverWatch Origins Edition")
                    gamePrice = 39.99;
                else
                {
                    Console.WriteLine("Not Found");
                    gameFound = false;
                }

                if (gameFound)
                {
                    if (balance >= gamePrice)
                    {
                        Console.WriteLine($"Bought {command}");
                        balance -= gamePrice;
                        totalSpent += gamePrice;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                command = Console.ReadLine();
            }

            if (balance > 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
            }

        }
    }
}
