using System;
using System.Collections.Generic;

namespace Aula26Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();
            Produto p1 = new Produto (1, "Dell", 2000f);
            Produto p2 = new Produto (2, "LG", 4000f);
            Produto p3 = new Produto (3, "Samsung", 5000f);
            Produto p4 = new Produto (4, "Lenovo", 4500f);

                Console.WriteLine("Produtos:\n");
            
            carrinho.Incluir(p1);
            carrinho.Incluir(p2);
            carrinho.Incluir(p3);
            carrinho.Incluir(p4);

            carrinho.Ler();
            carrinho.SomarTotal();
        }
    }
}
