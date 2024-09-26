using news_csharp.PrimaryConstructor.Struct;

namespace news_csharp.tests.PrimaryConstructor.Struct
{
    public class DistanciaTestes
    {
        [Test]
        public void Distancia_DeveCalcularMagnitudeCorretamente()
        {
            double dx = 3;
            double dy = 4;
            var magnitudeEsperada = 5;

            var distancia = new Distancia(dx, dy);

            Assert.That(magnitudeEsperada, Is.EqualTo(distancia.Magnitude));
        }

        [Test]
        public void Distance_DeveCalcularDirectionCorretamente()
        {
            double dx = 0;
            double dy = 1;
            var direcaoEsperada = Math.PI / 2;

            var distancia = new Distancia(dx, dy);

            Assert.That(direcaoEsperada, Is.EqualTo(distancia.Direction));
        }
    }
}
