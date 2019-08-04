using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
      This program will play madlibs with you.
      Author: Priscilla
      */


            Console.WriteLine(" Your story: This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.");
            // Let the user know that the program is starting:

            Console.WriteLine("Let's play!");

            // Give the Mad Lib a title:
            string title = "THE MORNING";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Enter a name:");
            string name = Console.ReadLine();
            Console.WriteLine("Now you need to think about 3 adjectives. Write the first adjective:");
            string adjective1 = Console.ReadLine();
            Console.WriteLine("Write the second adjective:");
            string adjective2 = Console.ReadLine();
            Console.WriteLine("Write the third adjective:");
            string adjective3 = Console.ReadLine();
            Console.WriteLine("Write a verb:");
            string verb = Console.ReadLine();
            Console.WriteLine("Write a noun:");
            string noun1 = Console.ReadLine();
            Console.WriteLine("Write a second noun:");
            string noun2 = Console.ReadLine();
            Console.WriteLine("Write an animal:");
            string animal = Console.ReadLine();
            Console.WriteLine("Write a food:");
            string food = Console.ReadLine();
            Console.WriteLine("Write a fruit:");
            string fruit = Console.ReadLine();
            Console.WriteLine("Write a superhero:");
            string superhero = Console.ReadLine();
            Console.WriteLine("Write a country:");
            string country = Console.ReadLine();
            Console.WriteLine("Write a dessert:");
            string dessert = Console.ReadLine();
            Console.WriteLine("Write a year:");
            string year = Console.ReadLine();






            // The template for the story:

            var story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";
            
            
            // Print the story:
            Console.WriteLine(story);
        }
    }
}
