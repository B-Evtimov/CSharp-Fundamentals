using System;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Input / Constraints
•	On the 1st line, you are going to receive the string.
•	On the next lines, until you receive "Abracadabra", you will be receiving commands.
•	All commands are case-sensitive.
Output
•	Print the output of the commands in the format described above.
*/

            string inputString = Console.ReadLine();


            string command = string.Empty;



            while ((command = Console.ReadLine()) != "Abracadabra")
            {
                string[] commandParts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = commandParts[0];
                switch (action)
                {
                    case "Abjuration":
                        inputString = inputString.ToUpper();
                        Console.WriteLine(inputString);
                        break;


                    case "Necromancy":
                        inputString = inputString.ToLower();
                        Console.WriteLine(inputString);
                        break;


                    case "Illusion":
                        int index = int.Parse(commandParts[1]);
                        char newChar = char.Parse(commandParts[2]);
                        if (index >= 0 && index < inputString.Length)
                        {
                            char[] charArray = inputString.ToCharArray();
                            charArray[index] = newChar;
                            inputString = new string(charArray);
                            Console.WriteLine("Done!");

                        }


                        else
                        {
                            Console.WriteLine("The spell was too weak.");
                        }
                        break;

                    case "Divination":


                        string firstSubstring = commandParts[1];
                        string secondSubstring = commandParts[2];
                        if (inputString.Contains(firstSubstring))
                        {
                            inputString = inputString.Replace(firstSubstring, secondSubstring);
                            Console.WriteLine(inputString);
                        }
                        else
                        {
                            Console.WriteLine("The spell did not work!");
                        }
                        break;



                    case "Alteration":
                        string substringToRemove = commandParts[1];
                        if (inputString.Contains(substringToRemove))
                        {
                            inputString = inputString.Replace(substringToRemove, ""
                                );
                            Console.WriteLine(inputString);

                        }

                        else
                        {
                            Console.WriteLine("The spell did not work!");
                        }

                        break;


                    default:
                        Console.WriteLine("The spell did not work!");
                        break;














                }



            }
        }
        /*SwordMaster
        Target Target Target
        Abjuration
        Necromancy
        Alteration master
        Abracadabra
        */
    }





}
