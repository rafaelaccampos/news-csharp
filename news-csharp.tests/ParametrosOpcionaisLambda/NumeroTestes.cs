using news_csharp.ParametrosOpcionaisLambda;

namespace news_csharp.tests.ParametrosOpcionaisLambda
{
    public class NumeroTestes
    {
        [Test]
        public void Somar_DeveRetornar6_QuandoIncrementoForPadrao()
        {
            var numero = new Numero();

            var soma = numero.Somar();

            Assert.That(6, Is.EqualTo(soma));
        }
    }
}
