using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool numbersChanged = false;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                var commandParts = command.Split();
                var action = commandParts[0];

                switch (action)
                {
                    case "Add":
                        int numberToAdd = int.Parse(commandParts[1]);
                        numbers.Add(numberToAdd);
                        numbersChanged = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(commandParts[1]);
                        numbers.Remove(numberToRemove);
                        numbersChanged = true;
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(commandParts[1]);
                        numbers.RemoveAt(indexToRemove);
                        numbersChanged = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(commandParts[1]);
                        int insertIndex = int.Parse(commandParts[2]);
                        numbers.Insert(insertIndex, numberToInsert);
                        numbersChanged = true;
                        break;
                    case "Contains":
                        int numberToCheck = int.Parse(commandParts[1]);
                        Console.WriteLine(numbers.Contains(numberToCheck) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        string condition = commandParts[1];
                        int number = int.Parse(commandParts[2]);
                        IEnumerable<int> filteredNumbers = condition switch
                        {
                            "<" => numbers.Where(n => n < number),
                            ">" => numbers.Where(n => n > number),
                            "<=" => numbers.Where(n => n <= number),
                            ">=" => numbers.Where(n => n >= number),
                            _ => Enumerable.Empty<int>()
                        };
                        Console.WriteLine(string.Join(" ", filteredNumbers));
                        break;
                }
            }

            if (numbersChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }
    }
}
