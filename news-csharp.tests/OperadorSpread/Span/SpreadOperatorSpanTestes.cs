using news_csharp.OperadorSpread.Span;

namespace news_csharp.tests.OperadorSpread.Span
{
    public class SpreadOperatorSpanTestes
    {
        [Test]
        public void CombinarReadonlySpans_DeveRetornarSubtextoCorreto()
        {
            var spreadOperator = new SpreadOperatorSpan();

            var resultado = spreadOperator.CombinarReadonlySpans();

            ReadOnlySpan<char> subtextoEsperado = "world!";
            Assert.That(subtextoEsperado.ToString(), Is.EqualTo(resultado.ToString()));
        }
    }
}
