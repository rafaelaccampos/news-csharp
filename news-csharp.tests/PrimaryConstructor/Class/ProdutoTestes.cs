using news_csharp.PrimaryConstructor.Class;

namespace news_csharp.tests.PrimaryConstructor.Class
{
    public class ProdutoTestes
    {
        [Test]
        public void Produto_DeveIniciarCorretamente()
        {
            var nomeEsperado = "Celular";
            var precoEsperado = 1500.00m;
            var quantidadeEsperada = 2;

            var produto = new Produto(nomeEsperado, precoEsperado, quantidadeEsperada);

            Assert.That(produto.Nome, Is.EqualTo(nomeEsperado));
            Assert.That(produto.Preco, Is.EqualTo(precoEsperado));
            Assert.That(produto.Quantidade, Is.EqualTo(quantidadeEsperada));
        }
    }
}