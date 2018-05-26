using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewsUnitTest.PublicacaoService;

namespace NewsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestePublicacao()
        {
            var noticia = new Noticia()
            {
                Id = Guid.NewGuid(),
                Titulo = "Sonho do Dia",
                Conteudo = "Dólar cai a R$2,00",
                Publicacao = DateTime.Now,
                Expiracao = DateTime.Now.AddDays(1),
            };

            var client = new PublicacaoServiceClient();
            client.Open();
            var qtdNoticiasPublicadasAntes = client.ObterNoticiasPublicadas().Length;
            bool isPublicado = client.PublicarNoticia(noticia);
            var qtdNoticiasPublicadasDepois = client.ObterNoticiasPublicadas().Length;
            client.Close();

            Assert.IsTrue(isPublicado);
            Assert.AreEqual(qtdNoticiasPublicadasAntes+1, qtdNoticiasPublicadasDepois);
        }
    }
}
