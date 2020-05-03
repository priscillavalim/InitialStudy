using System;
using System.Collections.Generic;

namespace Exercícios_listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Declaração de lista

            List<int> numeros;
            List<string> palavras;
            List<Filme> filmes;

            string teste = "";

            //Inicializar lista

            numeros = new List<int>();
            palavras = new List<string>();
            filmes = new List<Filme>();

            //Adicionar itens na lista

            numeros.Add(1);
            numeros.Add(1);
            numeros.Add(1);

            //Remover itens da lista

            //Contar itens da lista
            numeros.Count;

            //Iterar sobre lista

            //Gerar nova lista de uma lista
        }
    }

    public class Filme
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Diretor { get; set; }
    }
}
