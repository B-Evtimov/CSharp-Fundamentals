using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToList();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandParts = command.Split();
                switch (commandParts[0])
                {
                    case "Delete":
                        int numberToRemove = int.Parse(commandParts[1]);
                        numbers.RemoveAll(n => n == numberToRemove);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(commandParts[1]);
                        int indexToInsert = int.Parse(commandParts[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                }


            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
