namespace Exercícios_classes
{
    public class Predio
    {
        public Predio(int colunas, int andares)
        {}
        public int Coluna
        {get; set;}
        public int Andares
        {get; set;}

        private int unidades;
        public int Unidades
        {
        get {return unidades;}
        set {unidades = colunas*andares;}
        }

        //Outra forma de escrita
        public int Unidades => colunas*andares;
    }
}