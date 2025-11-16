using System;
using System.Collections.Generic;
using System.Linq;

namespace problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> messages;

            messages = new List<string>();


            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                List<string> tokens;
                tokens = command
                    .Split().ToList();
                string action = tokens[0];
                switch (action)
                {
                    case "Chat":
                        string message = tokens[1];
                        messages.Add(message);
                        break;


                    case "Delete":
                        string messageToDelete = tokens[1];
                        if (messages.Contains(messageToDelete))
                        {
                            messages.Remove(messageToDelete);
                        }
                        break;


                    case "Edit":
                        string messageToEdit = tokens[1];
                        string editedVersion = tokens[2];
                        if (messages.Contains(messageToEdit))
                        {
                            int index = messages.IndexOf(messageToEdit);
                            messages[index] = editedVersion;
                        }
                        break;


                    case "Pin":
                        string messageToPin = tokens[1];
                        if (messages.Contains(messageToPin))
                        {
                            messages.Remove(messageToPin);
                            messages.Add(messageToPin);
                        }
                        break;


                    case "Spam":
                        for (int i = 1; i < tokens.Count; i++)
                        {
                            string spamMessage = tokens[i];
                            messages.Add(spamMessage);
                        }
                        break;

                }
            }
            for (int i = 0; i < messages.Count; i++)
                Console.WriteLine(messages[i]);

        }
    }
}
