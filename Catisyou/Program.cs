using System;

namespace Catisyou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you prefer hamburger, french fries or pizza?");

            String answer = Console.ReadLine();

            if (answer == "hamburger")
            {
                Console.WriteLine("Black cat");
            }
            else if (answer == "french fries")
            {
                Console.WriteLine("Tiger cat");
            }
            else if (answer == "pizza")
            {
                Console.WriteLine("Three colored cat");
            }

        }
    }
}
