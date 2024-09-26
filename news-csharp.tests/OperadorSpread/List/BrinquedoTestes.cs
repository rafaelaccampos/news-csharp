using news_csharp.OperadorSpread.List;

namespace news_csharp.tests.OperadorSpread.List
{
    public class BrinquedoTestes
    {
        [Test]
        public void CombinarBrinquedos_DeveRetornarListaComCincoBrinquedos()
        {
            var brinquedo = new Brinquedo();

            var brinquedos = brinquedo.CombinarBrinquedos();

            Assert.That(5, Is.EqualTo(brinquedos.Count));
        }

        [Test]
        public void CombinarBrinquedos_DeveIncluirTodosOsBrinquedosEsperados()
        {
            var brinquedo = new Brinquedo();

            var brinquedos = brinquedo.CombinarBrinquedos();

            var brinquedosEsperados = new List<string> { "Boneca", "Bola", "Nerf", "Patinete", "Patins" };
            CollectionAssert.AreEquivalent(brinquedosEsperados, brinquedos);
        }
    }
}
