﻿using System;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {                
                if(i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                    continue;
                }

                if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                
                if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }  

                Console.WriteLine(i);

            }

            for (int i = 0; i < 100; i++)
            {                
                if(i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                }

                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }  
                else
                {
                    Console.WriteLine(i);
                }

            }          

        }
    }
}
