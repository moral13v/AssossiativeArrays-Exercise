using System;
using System.Collections.Generic;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            bool legendaryItemObtained = false;
            string element = "";
            int quantity = 0;

            Dictionary<string, int> inventory = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split();


            while (!legendaryItemObtained)
            {

                for (int i = 0; i < input.Length; i += 2)
                {
                    if (i % 2 != 0)
                    {
                        element = input[i];

                    }
                    else
                    {
                        quantity = int.Parse(input[i]);

                    }

                    if (!inventory.ContainsKey(element))
                    {
                        inventory.Add(element, 0);
                    }

                    inventory[element] += quantity;

                    if (element == "Shards" && quantity >= 250
                        || element == "Fragments" && quantity >= 250
                        || element == "Motes" && quantity >= 250)
                    {
                        legendaryItemObtained = true;
                        break;
                    }
                }

                foreach (var item in inventory)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }

            }
        }
    }
}
