using System.Collections.Generic;

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

            bool running = true;

            while (running)
            {
                Console.WriteLine("1. Display Inventory\n2. Show Total\n3. Show Average\n4. Exit Program");
                string userInput = Console.ReadLine();

                switch (userInput)
                {

                }
            }
        }
    }
}
