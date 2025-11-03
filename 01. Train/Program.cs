using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandParts = command.Split();
                if (commandParts[0] == "Add")
                {
                    int passengersToAdd = int.Parse(commandParts[1]);
                    wagons.Add(passengersToAdd);
                }
                else
                {
                    int passengersToFit = int.Parse(commandParts[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengersToFit <= wagonCapacity)
                        {
                            wagons[i] += passengersToFit;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));

        }
    }
}
