using System;
using System.Linq;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            foreach (var username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool isValid = true;
                    foreach (var ch in username)
                    {
                        if (!char.IsLetterOrDigit(ch) && ch != '-' && ch != '_')
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }

        }
    }
}
