using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> studentPoints = new Dictionary<string, int>();
            Dictionary<string, int> languageSubmissions = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "exam finished")
            {
                string[] inputArgs = input.Split("-");

                string student = inputArgs[0];
                string language = inputArgs[1];
                int points = 0;

                if (language == "banned")
                {
                    studentPoints.Remove(student);
                    input = Console.ReadLine();
                    continue;
                }

                if (!languageSubmissions.ContainsKey(language))
                {
                    languageSubmissions.Add(language, 0);
                }

                languageSubmissions[language]++;

                if (!studentPoints.ContainsKey(student))
                {
                    studentPoints.Add(student, 0);
                }

                points = int.Parse(inputArgs[2]);

                if (studentPoints[student] <= points)
                {
                    studentPoints[student] = points;
                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"Results:");

            foreach (var student in studentPoints.OrderByDescending(p => p.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine($"Submissions:");

            foreach (var language in languageSubmissions.OrderByDescending(s => s.Value).ThenBy(l => l.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
