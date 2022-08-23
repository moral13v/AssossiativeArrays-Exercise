using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cars = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] inputInfo = input.Split();

                string command = inputInfo[0];
                string username = inputInfo[1];

                switch (command)
                {
                    case "register":

                        string licensePlate = inputInfo[2];

                        if (!cars.ContainsKey(username))
                        {
                            cars.Add(username, licensePlate);
                            Console.WriteLine($"{username} registered {licensePlate} successfully");
                        }

                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        }

                        break;

                    case "unregister":

                        if (cars.ContainsKey(username))
                        {
                            Console.WriteLine($"{username} unregistered successfully");
                            cars.Remove(username);
                        }

                        else
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }

                        break;
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }
    }
}
