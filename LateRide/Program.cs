using System;

namespace LateRide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var result = lateRide(808);
        }

        static int lateRide(int n)
        {
            int hora = n / 60;
            float horaFlutuante = ((float)n / 60f) - (float)hora;
            float minutos = horaFlutuante * 60;

            int minutosTotais = (int)Math.Round(minutos);

            int somaHoras = (hora / 10) + (hora % 10);
            int somaMinutos = (minutosTotais / 10) + (minutosTotais % 10);

            int lateRide = somaHoras + somaMinutos;

            return lateRide;
        }
    }
}
