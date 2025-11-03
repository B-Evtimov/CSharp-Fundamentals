using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
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
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split();
                string action = tokens[0];
                switch (action)
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        if (numberToRemove >= 0 && numberToRemove < numbers.Count)
                        {
                            numbers.RemoveAt(numberToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        if (index >= 0 && index < numbers.Count)
                        {
                            numbers.Insert(index, numberToInsert);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        string direction = tokens[1];
                        int count = int.Parse(tokens[2]);
                        count = count % numbers.Count;
                        if (direction == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int firstNumber = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(firstNumber);
                            }
                        }
                        else if (direction == "right")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int lastNumber = numbers[numbers.Count - 1];
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Insert(0, lastNumber);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
