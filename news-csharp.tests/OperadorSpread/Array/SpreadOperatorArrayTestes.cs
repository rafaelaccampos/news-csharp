using news_csharp.OperadorSpread.Array;

namespace news_csharp.tests.OperadorSpread.Array
{
    public class SpreadOperatorArrayTestes
    {
        [Test]
        public void CombinarArrays_DeveRetornarArrayComNoveElementos()
        {
            var spreadOperator = new SpreadOperatorArray();

            var arrayInteiros = spreadOperator.CombinarArrays();

            Assert.That(9, Is.EqualTo(arrayInteiros.Length));
        }

        [Test]
        public void CombinarArrays_DeveIncluirTodosOsElementosEsperados()
        {
            var spreadOperator = new SpreadOperatorArray();

            var arrayInteiros = spreadOperator.CombinarArrays();

            int[] elementosEsperados = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            CollectionAssert.AreEquivalent(elementosEsperados, arrayInteiros);
        }
    }
}
