using System;
using System.Collections.Generic;

namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Company> companies = new Dictionary<string, Company>();

            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(" -> ");
                string companyName = arguments[0];
                string employeeId = arguments[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new Company(companyName);
                }
                companies[companyName].AddEmployee(employeeId);

            }
            foreach (var company in companies)
                Console.WriteLine(company.Value.ToString());


        }
    }

    public class Company
    {
        public Company(string name)
        {
            Name = name;
            EmployeeIds = new List<string>();
        }
        public string Name { get; set; }
        public List<string> EmployeeIds { get; set; }

        public override string ToString()
        {
            string result = $"{Name}\n";

            for (int i = 0; i < EmployeeIds.Count; i++)
            {
                result += $"-- {EmployeeIds[i]}\n";
            }

            return result.Trim();
        }

        public void AddEmployee(string employeeId)
        {
            if (!EmployeeIds.Contains(employeeId))
            {
                EmployeeIds.Add(employeeId);
            }
        }

    }
}
