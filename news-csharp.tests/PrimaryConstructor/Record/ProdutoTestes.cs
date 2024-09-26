using news_csharp.PrimaryConstructor.Record;

namespace news_csharp.tests.PrimaryConstructor.Record
{
    public class ProdutoTestes
    {
        [Test]
        public void Produto_DeveIniciarCorretamente()
        {
            var nomeEsperado = "Notebook";
            var precoEsperado = 3000.00m;
            var quantidadeEsperada = 1;

            var produto = new Produto(nomeEsperado, precoEsperado, quantidadeEsperada);

            Assert.That(produto.Nome, Is.EqualTo(nomeEsperado));
            Assert.That(produto.Preco, Is.EqualTo(precoEsperado));
            Assert.That(produto.Quantidade, Is.EqualTo(quantidadeEsperada));
        }
    }
}
