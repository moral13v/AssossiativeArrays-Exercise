using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input.Split(" -> ");

                string company = inputArgs[0];
                string employeeID = inputArgs[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                }

                if (!companies[company].Contains(employeeID))
                {
                    companies[company].Add(employeeID);
                }

                input = Console.ReadLine();
            }

            foreach (var company in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{company.Key}");
                Console.Write("-- ");
                Console.WriteLine(String.Join("\n-- ", company.Value));
            }
        }
    }
}
