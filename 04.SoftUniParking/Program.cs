using System;
using System.Collections.Generic;

namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, User> users = new Dictionary<string, User>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = commandParts[0];
                string userName = commandParts[1];
                switch (command)
                {
                    case "register":
                        {
                            string licensePlateNumber = commandParts[2];
                            if (users.ContainsKey(userName))
                            {
                                Console.WriteLine($"ERROR: already registered with plate number {users[userName].LicensePlateNumber}");
                            }
                            else
                            {
                                User user = new User(userName, licensePlateNumber);
                                users.Add(userName, user);
                                Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                            }
                            break;
                        }
                    case "unregister":
                        {
                            if (!users.ContainsKey(userName))
                            {
                                Console.WriteLine($"ERROR: user {userName} not found");
                            }
                            else
                            {
                                users.Remove(userName);
                                Console.WriteLine($"{userName} unregistered successfully");
                            }
                            break;
                        }
                }

            }
            foreach (var user in users)
            {
                Console.WriteLine(user.Value.ToString());
            }
        }
    }
    public class User
    {
        public string UserName { get; set; }
        public string LicensePlateNumber { get; set; }

        public User(string userName, string licensePlateNumber)
        {
            UserName = userName;
            LicensePlateNumber = licensePlateNumber;
        }

        public override string ToString()
        {
            return $"{UserName} => {LicensePlateNumber}";
        }
    }
}
