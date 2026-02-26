using System.Collections.Generic;
using System.Globalization;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();
            products.Add("Ink");
            products.Add("TestSheet");
            products.Add("Squeeges");
            products.Add("Cleaner");
            products.Add("Adhesive");

            int[] stock = { 3, 15, 5, 2, 0 };
            int sum = 0;

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n");
                Console.WriteLine("1. Display Inventory\n2. Show Total\n3. Show Average\n4. Exit Program");
                Console.Write("Please enter option: ");
                string userInput = Console.ReadLine();
                Console.WriteLine("\n");

                switch (userInput)
                {
                    case "1":
                        
                        foreach (string product in products)
                        {
                            Console.WriteLine(product);
                        }
                        break;
                    case "2": 

                        for (int i = 0; i < stock.Length; i++)
                        {
                            Console.WriteLine(stock[i]);
                        }
                        break;
                    case "3": 
                        foreach (int number in stock)
                        {
                            sum += number;
                        }
                        double average = (double)sum / stock.Length;

                        Console.WriteLine("Average is: " + average);
                        break;
                    case "4":
                        Console.WriteLine("End of program.");

                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;


                        
                }
            }
        }
    }
}
