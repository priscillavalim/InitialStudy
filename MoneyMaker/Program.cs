using System;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Write the amount to converte to coins:");
            string totalAsString = Console.ReadLine();
            double totalAsDouble = Convert.ToDouble(totalAsString);
            // double totalAsDouble = double.Parse(totalAsString);
            Console.WriteLine($"{totalAsDouble} cents is equal to...");
            double goldCoin = 10;
            double silverCoin = 5;

            double resultGold = totalAsDouble / goldCoin;

            resultGold = Math.Floor(totalAsDouble / goldCoin);

            double remainder = totalAsDouble % goldCoin;

            double resultSilver = remainder / silverCoin;
            resultSilver = Math.Floor(remainder / silverCoin);
            remainder = remainder % silverCoin;

            Console.WriteLine($"Gold coins:{resultGold}");
            Console.WriteLine($"Silver coins: {resultSilver}");
            Console.WriteLine($"Bronze coins: {remainder}");
        }
    }
}
