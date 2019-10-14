using System;

namespace NamedArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitPlanets( name: "blue", adjective: "red");
           Console.WriteLine("abc".IndexOf("c"));
            
        }

        static void VisitPlanets(
          string adjective,
          string name,
          int numberOfPlanets = 0,
          double gForce = 4.2)
        {
            Console.WriteLine($"Welcome back, {adjective} {name}.");
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
            Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
        }
    }
}
