using System;

namespace Fizzbuzz
{
    class Program1
    {
        void Main1(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {                
                if(i % 5 == 0 && IsFizz(i))
                {
                    Console.WriteLine("Fizzbuzz");
                    continue;
                }

                if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                
                if(IsFizz(i))
                {
                    Console.WriteLine("Fizz");
                    continue;
                }  

                Console.WriteLine(i);

            }

            for (int i = 0; i < 100; i++)
            {                
                if(i % 5 == 0 && IsFizz(i))
                {
                    Console.WriteLine("Fizzbuzz");
                }

                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                
                else if(IsFizz(i))
                {
                    Console.WriteLine("Fizz");
                }  
                else
                {
                    Console.WriteLine(i);
                }

                Player playerPriscilla = new Player();

                playerPriscilla.canTripleShot = true;
                playerPriscilla.Nome = "Priscilla";
            }

        }

        public static bool IsFizz(int i)
        {
            return i % 3 == 0;
        }
    }
}

public class Player
{
    public string Nome { get; set; }
    public bool canTripleShot { get; set; }
}
