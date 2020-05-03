using System;
using System.Collections.Generic;
using System.Linq;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float preco = 42.00f;

            List<Ordem> ordens = new List<Ordem>();
            
            ordens.Add(new Ordem{Item = "livro1", Quantidade = 2}); 
            ordens.Add(new Ordem{Item = "livro2", Quantidade = 2}); 
            ordens.Add(new Ordem{Item = "livro3", Quantidade = 2}); 
            ordens.Add(new Ordem{Item = "livro4", Quantidade = 1}); 
            ordens.Add(new Ordem{Item = "livro5", Quantidade = 1}); 
            
            float valorTotal = ordens.Sum(o => o.Quantidade) * preco;

            float desconto = ((((float)ordens.Count * 5F) - 5F) / 100F) * valorTotal;

            Console.WriteLine(valorTotal);
            Console.WriteLine(desconto);
            

            float valorFinal = valorTotal - desconto;

            Console.WriteLine(valorFinal); 

            

        }

       
    }

    public class Ordem 
    {
        public string Item {get; set;}
        public int Quantidade {get; set;}

    }
}

