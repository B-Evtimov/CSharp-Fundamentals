namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadsets = 0;
            int trashedMice = 0;
            int trashedKeyboards = 0;
            int trashedDisplays = 0;

            int keyboardTrashCounter = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHeadsets++;
                }

                if (i % 3 == 0)
                {
                    trashedMice++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    trashedKeyboards++;
                    keyboardTrashCounter++;

                    if (keyboardTrashCounter % 2 == 0)
                    {
                        trashedDisplays++;
                    }
                }
            }

            double totalExpenses =
                trashedHeadsets * headsetPrice +
                trashedMice * mousePrice +
                trashedKeyboards * keyboardPrice +
                trashedDisplays * displayPrice;

            Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");

        }
    }
}
