namespace Exercícios_classes
{
    public class Computador
    {
        public Computador (int memoria, int espacoHD, string processador, string placadevideo)
        {
            Memoria = memoria;
            EspacoHD = espacoHD;
            Processador = processador; 
            Placadevideo = placadevideo;
        }

        public Computador (int memoria, int espacoHD, string processador)
        {}
        
        public int Memoria
        {get; set;}
        public int EspacoHD
        {get; set;}
        public string Processador
        {get; set;}
        public string Placadevideo
        {get; set;}



    


    }
}