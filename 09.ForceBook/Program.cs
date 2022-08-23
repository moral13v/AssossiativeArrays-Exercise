using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] inputArgs = input.Split(" | ");

                    string side = inputArgs[0];
                    string user = inputArgs[1];

                    if (!sides.ContainsKey(side))
                    {
                        sides.Add(side, new List<string>());
                    }

                    if (!sides[side].Contains(user) && !sides.Values.Any(x => x.Contains(user)))
                    {
                        sides[side].Add(user);
                    }


                }

                else if (input.Contains("->"))
                {

                    string[] inputArgs = input.Split(" -> ");

                    string side = inputArgs[1];
                    string user = inputArgs[0];

                    if (!sides.Values.Any(x => x.Contains(user)))
                    {
                        if (!sides.ContainsKey(side))
                        {
                            sides.Add(side, new List<string>());
                        }

                        sides[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }

                    else
                    {
                        foreach (var item in sides)
                        {
                            if (item.Value.Contains(user))
                            {
                                item.Value.Remove(user);
                            }
                        }

                        if (!sides.ContainsKey(side))
                        {
                            sides.Add(side, new List<string>());
                        }

                        sides[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");

                    }

                }

                input = Console.ReadLine();
            }

            sides = sides.OrderByDescending(u => u.Value.Count)
                .ThenBy(s => s.Key)
                .ToDictionary(s => s.Key, u => u.Value);

            foreach (var side in sides)
            {
                side.Value.Sort();

                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    Console.Write("! ");
                    Console.WriteLine(String.Join("\n! ", side.Value));

                }

            }
        }
    }
}
