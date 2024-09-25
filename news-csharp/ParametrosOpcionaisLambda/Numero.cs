namespace news_csharp.ParametrosOpcionaisLambda
{
    public class Numero
    {
        public int Somar()
        {
            var soma = (int source, int increment = 1) => source + increment;
            return soma(5); //6
        }
    }
}
