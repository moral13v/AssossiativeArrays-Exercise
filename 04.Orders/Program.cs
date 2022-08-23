using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] inputInfo = input.Split();

                string productName = inputInfo[0];
                double productPrice = double.Parse(inputInfo[1]);
                int productQuantity = int.Parse(inputInfo[2]);



                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new double[2]);
                }

                double previousQuantity = products[productName][1];

                double[] inventory = new double[] { productPrice, previousQuantity + productQuantity };
                products[productName] = inventory;
                
                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                double totalPrice = product.Value[0] * product.Value[1];
                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }



            
        }
    }
}
