using System;

namespace Aula24ObjetosArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();
            Produto p1 = new Produto ("GTA 5", 1, 100f);
            Produto p2 = new Produto ("Celeste", 2, 200f);
            Produto p3 = new Produto ("Diablo III", 3, 300f);
            Produto p4 = new Produto ("Dark Souls", 4, 450f);

            cart.AdicionarProduto(p1);
            cart.AdicionarProduto(p2);
            cart.AdicionarProduto(p3);
            cart.AdicionarProduto(p4);

            Produto novoProduto = new Produto("Undertale", 5, 500f);
            cart.AlterarItem(2, novoProduto);

            cart.Ler();
            cart.SomarTotal();
        }
    }
}
