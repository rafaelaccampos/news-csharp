namespace news_csharp.ParametrosOpcionaisLambda
{
    public class Numero
    {
        public int Somar()
        {
            var soma = (int origem, int incremento = 1) => origem + incremento;
            return soma(5); //6
        }
    }
}
