using news_csharp.InitOnlySetters;

namespace news_csharp.tests.InitOnlySetters
{
    public class PessoaTestes
    {
        [Test]
        public void Pessoa_DeveInicializarCorretamente()
        {
            var nome = "Rafa";
            var idade = 27;

            var pessoa = new Pessoa(nome, idade);

            Assert.That(nome, Is.EqualTo(pessoa.Nome));
            Assert.That(idade, Is.EqualTo(pessoa.Idade));
        }

        [Test]
        public void Pessoa_PropriedadesInit_NaoPodemSerModificadasDepoisDeInicializacao()
        {
            var pessoa = new Pessoa("Maria", 25);

            // A tentativa de alterar uma propriedade init após a inicialização deve gerar erro de compilação
            // Então, aqui estamos apenas verificando que os valores não mudaram
            Assert.That("Maria", Is.EqualTo(pessoa.Nome));
            Assert.That(25, Is.EqualTo(pessoa.Idade));

            //pessoa.Nome = "Ana";
        }
    }
}
