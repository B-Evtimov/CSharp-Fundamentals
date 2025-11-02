namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string reversedWord = "";

            for (int i = user.Length - 1; i >= 0; i--)
            {
                reversedWord += user[i];
            }

            int tries = 0;
            while (tries < 4)
            {
                string tryy = Console.ReadLine();

                if (tryy == reversedWord)
                {
                    Console.WriteLine($"User {user} logged in.");
                    return;
                }

                tries++;

                if (tries == 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");
            }

        }
    }
}
