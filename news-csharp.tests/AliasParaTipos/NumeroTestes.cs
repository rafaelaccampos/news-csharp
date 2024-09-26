using news_csharp.AliasParaTipos;

namespace news_csharp.tests.AliasParaTipos
{
    public class NumeroTestes
    {
        [Test]
        public void RetornarAltura_DeveRetornarTuplaComNomeEAltura()
        {
            var numero = new Numero();
            var alturaEsperada = ("Altura", 180);

            var altura = numero.RetornarAltura();

            Assert.That(alturaEsperada, Is.EqualTo(altura));
        }

        [Test]
        public void RetornarInteiros_DeveRetornarArrayDeInteiros()
        {
            var numero = new Numero();
            var inteirosEsperados = new int[] { 10, 20, 30, 40 };

            var inteiros = numero.RetornarInteiros();

            Assert.That(inteirosEsperados, Is.EqualTo(inteiros));
        }

        [Test]
        public void RetornarInteiroNulavel_DeveRetornarValorInteiroNulavel()
        {
            var numero = new Numero();
            int? inteiroEsperado = 100;

            var inteiro = numero.RetornarInteiroNulavel();

            Assert.That(inteiroEsperado, Is.EqualTo(inteiro));
        }
    }
}
