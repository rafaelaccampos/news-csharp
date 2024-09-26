namespace news_csharp.PrimaryConstructor.Class
{
    public class Produto(string nome, decimal preco, int quantidade)
    {
        public string Nome { get; private set; } = nome;
        public decimal Preco { get; private set; } = preco;
        public int Quantidade { get; private set; } = quantidade;
    }
}
