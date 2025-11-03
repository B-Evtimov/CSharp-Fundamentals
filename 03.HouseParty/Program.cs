using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());
            var guestList = new List<string>();

            for (int i = 0; i < commandCount; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                bool isGoing = tokens[2] == "going!";

                if (isGoing)
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else
                {
                    if (!guestList.Remove(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            foreach (string guest in guestList)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
