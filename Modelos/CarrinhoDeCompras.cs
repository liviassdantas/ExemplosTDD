namespace Exemplo1TDDMaiorEMenor.Modelos
{
    public class CarrinhoDeCompras
    {
        public List<Produto> Produtos = new List<Produto>();

        public void Adiciona(Produto produto)
        {
            Produtos.Add(produto);
            Console.WriteLine("Produto {0} adicionado!", produto.Nome);
            Console.WriteLine("Há {0} produtos no carrinho", Produtos.Count);
        }
    }
}
