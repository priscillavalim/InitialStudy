using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When is your birthday?");

            string answer = Console.ReadLine();
            DateTime birthday = DateTime.Parse(answer);

            if (birthday == DateTime.Today)
            {
                Console.WriteLine("Happy Birthday!");
            }
            else
            {
                int days = (DateTime.Today - birthday).Days;
                Console.WriteLine($"Days until your birthday:{days}");
            }
        }
    }
}
