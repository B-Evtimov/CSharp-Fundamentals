using System;
using System.Collections.Generic;
using System.Linq;

namespace problem
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /*
            •	The first input line will contain the usernames that need to be stored.
•	On the next input lines until "Report", you will receive commands.
•	All given names will be unique.

            */

            string[] numbers = Console.ReadLine()
                .Split(", ")
                .ToArray();

            string command = "";
            while ((command = Console.ReadLine()) != "Report")
            {
                List<string> tokens;
                tokens = command
                    .Split().ToList();

                switch (tokens)
                {


                    case var _ when tokens[0] == "Blacklist":
                        string nameToBlacklist = tokens[1];
                        if (numbers.Contains(nameToBlacklist))
                        {
                            int index = Array.IndexOf(numbers, nameToBlacklist);
                            numbers[index] = "Blacklisted";
                            Console.WriteLine($"{nameToBlacklist} was blacklisted.");
                        }
                        else
                        {
                            Console.WriteLine($"{nameToBlacklist} was not found.");
                        }
                        break;


                    case var _ when tokens[0] == "Error":
                        int indexToError = int.Parse(tokens[1]);
                        if (indexToError >= 0 && indexToError < numbers.Length)
                        {
                            if (numbers[indexToError] != "Blacklisted" && numbers[indexToError] != "Lost")
                            {
                                string lostName = numbers[indexToError];
                                numbers[indexToError] = "Lost";
                                Console.WriteLine($"{lostName} was lost due to an error.");
                            }
                        }
                        break;


                    case var _ when tokens[0] == "Change":
                        int indexToChange = int.Parse(tokens[1]);
                        string newName = tokens[2];
                        if (indexToChange >= 0 && indexToChange < numbers.Length)
                        {
                            string currentName = numbers[indexToChange];
                            numbers[indexToChange] = newName;
                            Console.WriteLine($"{currentName} changed his username to {newName}.");
                        }
                        break;
                }



            }



            int blacklistedCount = numbers.Count(n => n == "Blacklisted");
            int lostCount = numbers.Count(n => n == "Lost");
            Console.WriteLine($"Blacklisted names: {blacklistedCount}");
            Console.WriteLine($"Lost names: {lostCount}");
            Console.WriteLine(string.Join(" ", numbers));



        }


    }



}

