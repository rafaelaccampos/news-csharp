namespace news_csharp.InitOnlySetters
{
    public class Pessoa
    {
        //Restringe a atribuição do valor apenas uma vez
        public string Nome { get; init; }
        public int Idade { get; init; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
