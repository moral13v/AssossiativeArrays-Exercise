using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();                         

            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (letter != ' ')
                {
                    if (!letters.ContainsKey(letter))
                    {
                        letters.Add(letter, 0);
                    }

                    letters[letter]++;
                }
            }

            foreach (var item in letters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
