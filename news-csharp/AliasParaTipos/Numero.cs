namespace news_csharp.AliasParaTipos
{
    using Altura = (string, int);
    using ListaInteiros = int[];
    using Inteiro = int?;

    public class AliasService
    {
        public Altura RetornarAltura()
        {
            return ("Altura", 180); // Retorna uma tupla com o nome e valor
        }

        public ListaInteiros RetornarInteiros()
        {
            return [10, 20, 30, 40]; // Retorna um array de inteiros
        }

        public Inteiro GetDatabaseIntValue()
        {
            return 100; // Retorna um valor inteiro nulável
        }
    }
}
