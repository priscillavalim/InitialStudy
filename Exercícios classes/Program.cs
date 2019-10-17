using System;

namespace Exercícios_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var gato = new Gato();
            gato.Nome = "Mariana";
            gato.Apelido = "Mari";
            gato.Raça = "Tricolor";-
            gato.TemHeterocromia = false; 
            gato.Ouvir("Mariana");

            Console.WriteLine(gato);
            Console.WriteLine(gato.Nome);

            var gato2 = new Gato();
            gato2.Nome = "Marina";
            gato2.Apelido = "Mari";
            gato2.Raça = "Tricolor";
            gato2.TemHeterocromia = false; 
            gato2.Ouvir("Marina");

            
            Console.WriteLine(gato2);
            Console.WriteLine(gato2.Nome);
        }
    }
}
