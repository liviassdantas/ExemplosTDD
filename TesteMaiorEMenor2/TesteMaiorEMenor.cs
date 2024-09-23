using NUnit.Framework;
using Exemplo1TDDMaiorEMenor.Modelos;
using Microsoft.AspNetCore.Routing;
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

        [Test]
        public void ApenasUmProduto()
        {
            var carrinhoDeCompras = new CarrinhoDeCompras();
            carrinhoDeCompras.Adiciona(new Produto("Geladeira", 450.0));

            var algoritmo = new MaiorEMenor();
            algoritmo.EncontraProduto(carrinhoDeCompras);

            Assert.That(algoritmo.Maior.Nome, Is.EqualTo("Geladeira"));
            Assert.That(algoritmo.Menor.Nome, Is.EqualTo("Geladeira"));

        }
    }
}