using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This programs purpose is to demonstrate the use of Validation, try catch, and working with arrays and lists properly.

            // This is a collection of the list of products, .add is used to add to the list that will be used in this program.
            List<string> products = new List<string>();
            products.Add("Ink");
            products.Add("TestSheet");
            products.Add("Squeeges");
            products.Add("Cleaner");
            products.Add("Adhesive");
            // like the list we are using an array this time to collect the same type, with list we can use more than just string.
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

                    if (userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4")
                    { 
                      try
                    {
                        switch (userInput)
                        {
                            case "1":

                                foreach (string product in products)
                                {
                                    Console.WriteLine(product);
                                }
                                break;
                            case "2":

                                for (int i = 0; i < products.Count; i++)
                                {
                                    Console.WriteLine(products[i] + " " + stock[i]);
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
                    } catch (FormatException)
                    {
                        Console.WriteLine("Invalid please try again");
                    }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please try again.");
                    }
            } // while debugging during the writing of this code, I noticed I could not get case 2 to display properly.
            // It would display the array and the list multiple times, I had written the logic wrong.
        }
    }
}
