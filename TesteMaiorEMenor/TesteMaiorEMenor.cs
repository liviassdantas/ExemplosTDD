using NUnit.Framework;
using Exemplo1TDDMaiorEMenor.Modelos;
namespace TesteExemplo1
{
    [TestFixture]
    public class TestaMaiorEMenor
    {
        [Test]
        public void OrdemDecrescente()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Geladeira", 450.0));
            carrinho.Adiciona(new Produto("Jogo de Pratos", 70.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.EncontraProduto(carrinho);

            Assert.That(algoritmo.Menor.Nome, Is.EqualTo("Jogo de Pratos"));
            Assert.That(algoritmo.Maior.Nome, Is.EqualTo("Geladeira"));
        }

    }
}